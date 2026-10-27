using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Data.Context;

namespace SurTech.Financiero.Services.BusinessLogic
{
    public class ContabilidadYStockService
    {
        // Genera el asiento contable automático para una Compra
        public void RegistrarAsientoCompra(Comprobante compra)
        {
            using (var context = new FacturacionDbContext())
            {
                var asiento = new AsientoContable
                {
                    Fecha = compra.FechaEmision,
                    Concepto = $"Compra según {compra.TipoComprobante} a {compra.NombreEntidad}"
                };

                asiento.Detalles.Add(new AsientoDetalle { Cuenta = "Mercaderías (Stock)", Debe = compra.NetoGravado, Haber = 0 });
                asiento.Detalles.Add(new AsientoDetalle { Cuenta = "IVA Crédito Fiscal", Debe = compra.ImporteIva, Haber = 0 });
                asiento.Detalles.Add(new AsientoDetalle { Cuenta = "Proveedores / Acreedores", Debe = 0, Haber = compra.Total });

                context.Set<AsientoContable>().Add(asiento);
                context.SaveChanges();
            }
        }

        // Genera el asiento contable automático para una Venta y calcula CMV
        public void RegistrarAsientoVenta(Comprobante venta, decimal costoMercaderiaVendida)
        {
            using (var context = new FacturacionDbContext())
            {
                var asientoVenta = new AsientoContable
                {
                    Fecha = venta.FechaEmision,
                    Concepto = $"Venta según {venta.TipoComprobante} a {venta.NombreEntidad}"
                };

                asientoVenta.Detalles.Add(new AsientoDetalle { Cuenta = "Deudores por Ventas / Caja", Debe = venta.Total, Haber = 0 });
                asientoVenta.Detalles.Add(new AsientoDetalle { Cuenta = "Ventas", Debe = 0, Haber = venta.NetoGravado });
                asientoVenta.Detalles.Add(new AsientoDetalle { Cuenta = "IVA Débito Fiscal", Debe = 0, Haber = venta.ImporteIva });

                context.Set<AsientoContable>().Add(asientoVenta);

                if (costoMercaderiaVendida > 0)
                {
                    var asientoCmv = new AsientoContable
                    {
                        Fecha = venta.FechaEmision,
                        Concepto = $"CMV s/ Venta a {venta.NombreEntidad}"
                    };

                    asientoCmv.Detalles.Add(new AsientoDetalle { Cuenta = "Costo de Mercadería Vendida (CMV)", Debe = costoMercaderiaVendida, Haber = 0 });
                    asientoCmv.Detalles.Add(new AsientoDetalle { Cuenta = "Mercaderías (Stock)", Debe = 0, Haber = costoMercaderiaVendida });

                    context.Set<AsientoContable>().Add(asientoCmv);
                }

                context.SaveChanges();
            }
        }

        // Obtiene la Posición Final de IVA del periodo
        public (decimal totalDebito, decimal totalCredito, decimal saldoTecnico) ObtenerPosicionIva()
        {
            using (var context = new FacturacionDbContext())
            {
                var compras = context.Comprobantes.Where(c => c.TipoOperacion == "Compra").ToList();
                var ventas = context.Comprobantes.Where(c => c.TipoOperacion == "Venta").ToList();

                decimal totalCredito = compras.Sum(c => c.ImporteIva);
                decimal totalDebito = ventas.Sum(v => v.ImporteIva);
                decimal saldoTecnico = totalDebito - totalCredito;

                return (totalDebito, totalCredito, saldoTecnico);
            }
        }

        // Anula/Elimina un comprobante erróneo y revierte automáticamente su stock
        public bool AnularComprobante(int idComprobante)
        {
            using (var context = new FacturacionDbContext())
            {
                var comprobante = context.Comprobantes
                    .Include(c => c.Detalles)
                    .FirstOrDefault(c => c.IdComprobante == idComprobante);

                if (comprobante == null)
                    return false;

                foreach (var detalle in comprobante.Detalles)
                {
                    var articulo = context.Articulos.Find(detalle.IdArticulo);
                    if (articulo != null)
                    {
                        if (comprobante.TipoOperacion == "Compra")
                        {
                            articulo.StockActual -= detalle.Cantidad;
                        }
                        else if (comprobante.TipoOperacion == "Venta")
                        {
                            articulo.StockActual += detalle.Cantidad;
                        }
                    }
                }

                context.Comprobantes.Remove(comprobante);
                context.SaveChanges();
                return true;
            }
        }
    }
}