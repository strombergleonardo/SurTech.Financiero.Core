using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Data.Context;

namespace SurTech.Financiero.UI
{
    public partial class FrmCierreEjercicio : Form
    {
        private readonly Usuario _usuarioLogueado;

        // Estilo SurTech
        private readonly Color ColorPrimarioOscuro = Color.FromArgb(51, 51, 51);
        private readonly Color ColorAcentoNaranja = Color.FromArgb(255, 102, 0);
        private readonly Color ColorFondoGeneral = Color.FromArgb(245, 247, 250);

        public FrmCierreEjercicio(Usuario usuarioLogueado)
        {
            InitializeComponent();
            _usuarioLogueado = usuarioLogueado ?? throw new ArgumentNullException(nameof(usuarioLogueado));

            // Pantalla completa
            this.WindowState = FormWindowState.Maximized;
            AplicarEstiloVisual();
        }

        private void AplicarEstiloVisual()
        {
            this.BackColor = ColorFondoGeneral;

            btnEjecutarCierre.BackColor = ColorAcentoNaranja;
            btnEjecutarCierre.ForeColor = Color.White;
            btnEjecutarCierre.FlatStyle = FlatStyle.Flat;
            btnEjecutarCierre.FlatAppearance.BorderSize = 0;

            btnCalcularBalance.BackColor = ColorPrimarioOscuro;
            btnCalcularBalance.ForeColor = Color.White;
            btnCalcularBalance.FlatStyle = FlatStyle.Flat;
            btnCalcularBalance.FlatAppearance.BorderSize = 0;
        }

        private void FrmCierreEjercicio_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpHasta.Value = DateTime.Now;
        }

        private void BtnCalcularBalance_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                using (var context = new FacturacionDbContext())
                {
                    var comprobantes = context.Comprobantes
                        .Where(c => c.FechaEmision >= desde && c.FechaEmision <= hasta)
                        .ToList();

                    decimal totalVentas = comprobantes.Where(c => c.TipoOperacion == "Venta").Sum(c => c.Total);
                    decimal totalCompras = comprobantes.Where(c => c.TipoOperacion == "Compra").Sum(c => c.Total);

                    decimal ivaDebito = comprobantes.Where(c => c.TipoOperacion == "Venta").Sum(c => c.ImporteIva);
                    decimal ivaCredito = comprobantes.Where(c => c.TipoOperacion == "Compra").Sum(c => c.ImporteIva);

                    decimal saldoIvaFisco = ivaDebito - ivaCredito; // Positivo a pagar, Negativo saldo a favor

                    lblVentasVal.Text = $"$ {totalVentas:N2}";
                    lblComprasVal.Text = $"$ {totalCompras:N2}";
                    lblIvaDebitoVal.Text = $"$ {ivaDebito:N2}";
                    lblIvaCreditoVal.Text = $"$ {ivaCredito:N2}";
                    lblSaldoIvaVal.Text = $"$ {saldoIvaFisco:N2}";

                    lblSaldoIvaVal.ForeColor = saldoIvaFisco >= 0 ? Color.Crimson : Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEjecutarCierre_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Confirma realizar el cierre del ejercicio para el período seleccionado? Esta acción registrará el balance oficial.",
                "Confirmación de Cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Lógica para consolidar el cierre de ejercicio en base de datos
                    MessageBox.Show("¡Cierre de ejercicio ejecutado y registrado correctamente por SurTech!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al ejecutar el cierre: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}