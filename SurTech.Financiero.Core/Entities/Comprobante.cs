using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // <-- Necesario para el atributo ForeignKey

namespace SurTech.Financiero.Core.Entities
{
    public class Comprobante
    {
        [Key]
        public int IdComprobante { get; set; }
        public int IdUsuario { get; set; }
        public string TipoOperacion { get; set; } = "Venta"; // "Compra" o "Venta"
        public string TipoComprobante { get; set; } = "Factura B";
        public string NombreEntidad { get; set; } = string.Empty; // Proveedor o Cliente
        public string CuitEntidad { get; set; } = string.Empty;
        public string Moneda { get; set; } = "ARS"; // "ARS" o "USD"
        public decimal CotizacionDolar { get; set; } = 1.0m;
        public string FormaPago { get; set; } = "Contado"; // "Contado", "Cuotas", "Cheque"
        public int CantidadCuotas { get; set; } = 1;
        public decimal PorcentajeInteres { get; set; } = 0.0m;
        public string NumeroCheque { get; set; } = string.Empty; // Inicializado para evitar nulos en BD
        public DateTime? FechaCheque { get; set; } = null;
        public DateTime FechaEmision { get; set; } = DateTime.Now;
        public decimal NetoGravado { get; set; }
        public decimal ImporteIva { get; set; }
        public decimal Total { get; set; }

        public List<ComprobanteDetalle> Detalles { get; set; } = new List<ComprobanteDetalle>();

        // Relación de navegación para las cuotas asociadas al comprobante
        public List<CuotaComprobante> Cuotas { get; set; } = new List<CuotaComprobante>();
    }

    public class ComprobanteDetalle
    {
        [Key]
        public int IdComprobanteDetalle { get; set; }

        [ForeignKey("Comprobante")] // <-- Esto le indica a EF que la FK es IdComprobante
        public int IdComprobante { get; set; }

        // Propiedad de navegación opcional hacia el comprobante principal
        public virtual Comprobante Comprobante { get; set; }

        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}