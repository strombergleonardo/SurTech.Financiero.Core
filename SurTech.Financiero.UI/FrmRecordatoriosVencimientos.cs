using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Data.Context;

namespace SurTech.Financiero.UI.Modulos
{
    public partial class FrmRecordatoriosVencimientos : Form
    {
        private readonly Usuario _usuarioLogueado;

        // Estilo visual SurTech
        private readonly Color ColorFondoGeneral = Color.FromArgb(245, 247, 250);
        private readonly Color ColorAcentoNaranja = Color.FromArgb(255, 102, 0);

        public FrmRecordatoriosVencimientos(Usuario usuarioLogueado)
        {
            InitializeComponent();
            _usuarioLogueado = usuarioLogueado ?? throw new ArgumentNullException(nameof(usuarioLogueado));

            this.WindowState = FormWindowState.Maximized;
            AplicarEstiloVisual();
        }

        private void AplicarEstiloVisual()
        {
            this.BackColor = ColorFondoGeneral;

            btnActualizar.BackColor = ColorAcentoNaranja;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.FlatAppearance.BorderSize = 0;
        }

        private void FrmRecordatoriosVencimientos_Load(object sender, EventArgs e)
        {
            CargarAlertas();
        }

        private void CargarAlertas()
        {
            try
            {
                using (var context = new FacturacionDbContext())
                {
                    DateTime hoy = DateTime.Today;

                    // 1. FACTURAS DE VENTA (Donde TipoOperacion es "Venta")
                    var ventas = context.Comprobantes
                        .Where(c => c.TipoOperacion == "Venta" && c.FechaEmision >= hoy) // Ajusta si agregas una FechaVencimiento propia
                        .Select(c => new
                        {
                            Categoria = "Factura Venta",
                            Concepto = c.TipoComprobante + " - Entidad: " + c.NombreEntidad,
                            ClienteProveedor = c.NombreEntidad,
                            Monto = c.Total,
                            Vencimiento = c.FechaEmision // O FechaVencimiento si la incorporas al modelo
                        }).ToList();

                    // 2. FACTURAS DE COMPRA (Donde TipoOperacion es "Compra")
                    var compras = context.Comprobantes
                        .Where(c => c.TipoOperacion == "Compra" && c.FechaEmision >= hoy)
                        .Select(c => new
                        {
                            Categoria = "Factura Compra",
                            Concepto = c.TipoComprobante + " - Proveedor: " + c.NombreEntidad,
                            ClienteProveedor = c.NombreEntidad,
                            Monto = c.Total,
                            Vencimiento = c.FechaEmision
                        }).ToList();

                    // 3. CHEQUES A COBRAR / PAGAR (Donde FormaPago es "Cheque")
                    var cheques = context.Comprobantes
                        .Where(c => c.FormaPago == "Cheque" && c.FechaCheque != null && c.FechaCheque >= hoy)
                        .Select(c => new
                        {
                            Categoria = "Cheque (" + c.TipoOperacion + ")",
                            Concepto = "Cheque N° " + c.NumeroCheque + " (" + c.NombreEntidad + ")",
                            ClienteProveedor = c.NombreEntidad,
                            Monto = c.Total,
                            Vencimiento = c.FechaCheque.Value
                        }).ToList();

                    // 4. CUOTAS A VENCER (Donde FormaPago es "Cuotas" y CantidadCuotas > 1)
                    // Si generas cuotas como registros separados o simuladas por cantidad:
                    var cuotas = context.Comprobantes
                        .Where(c => c.FormaPago == "Cuotas" && c.CantidadCuotas > 1 && c.FechaEmision >= hoy)
                        .Select(c => new
                        {
                            Categoria = "Cuotas (" + c.TipoOperacion + ")",
                            Concepto = c.CantidadCuotas + " Cuotas - " + c.NombreEntidad,
                            ClienteProveedor = c.NombreEntidad,
                            Monto = c.Total / c.CantidadCuotas, // Monto aproximado por cuota
                            Vencimiento = c.FechaEmision.AddMonths(1) // Estimación del próximo vencimiento de cuota
                        }).ToList();

                    // Unificar todo en una sola lista cronológica
                    var consolidado = ventas
                        .Concat(compras)
                        .Concat(cheques)
                        .Concat(cuotas)
                        .OrderBy(x => x.Vencimiento)
                        .ToList();

                    dgvAlertas.DataSource = null;
                    dgvAlertas.DataSource = consolidado;

                    // Formato visual de la grilla
                    if (dgvAlertas.Columns["Monto"] != null)
                    {
                        dgvAlertas.Columns["Monto"].HeaderText = "Monto";
                        dgvAlertas.Columns["Monto"].DefaultCellStyle.Format = "C2";
                    }
                    if (dgvAlertas.Columns["Vencimiento"] != null)
                    {
                        dgvAlertas.Columns["Vencimiento"].HeaderText = "Próximo Vencimiento / Fecha";
                        dgvAlertas.Columns["Vencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los recordatorios: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarAlertas();
        }
    }
}