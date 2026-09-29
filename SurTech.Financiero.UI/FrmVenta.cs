using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Data.Context;

namespace SurTech.Financiero.UI.Modulos
{
    public partial class FrmVenta : Form
    {
        private readonly Usuario _usuarioLogueado;
        private readonly List<ComprobanteDetalle> _detallesVenta = new List<ComprobanteDetalle>();

        // Colores de la identidad SurTech
        private readonly Color ColorPrimarioOscuro = Color.FromArgb(51, 51, 51);
        private readonly Color ColorAcentoNaranja = Color.FromArgb(255, 102, 0);
        private readonly Color ColorFondoGeneral = Color.FromArgb(245, 247, 250);

        public FrmVenta(Usuario usuarioLogueado)
        {
            InitializeComponent();
            _usuarioLogueado = usuarioLogueado ?? throw new ArgumentNullException(nameof(usuarioLogueado));

            // Pantalla completa
            this.WindowState = FormWindowState.Maximized;
            AplicarEstiloVisual();
            InicializarVisorPdfVenta();
        }

        private void AplicarEstiloVisual()
        {
            this.BackColor = ColorFondoGeneral;

            btnGuardarVenta.BackColor = ColorAcentoNaranja;
            btnGuardarVenta.ForeColor = Color.White;
            btnGuardarVenta.FlatStyle = FlatStyle.Flat;
            btnGuardarVenta.FlatAppearance.BorderSize = 0;

            btnAgregarDetalle.BackColor = ColorPrimarioOscuro;
            btnAgregarDetalle.ForeColor = Color.White;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.FlatAppearance.BorderSize = 0;
        }

        private void InicializarVisorPdfVenta()
        {
            // Propiedades y eventos del botón controlado desde el código (si ya está en el diseñador, puedes omitir el new y solo asignar propiedades y eventos)
            btnVerPdfVenta.Text = "Cargar / Ver PDF Venta";
            btnVerPdfVenta.Location = new Point(20, 620);
            btnVerPdfVenta.Size = new Size(180, 35);
            btnVerPdfVenta.BackColor = ColorPrimarioOscuro;
            btnVerPdfVenta.ForeColor = Color.White;
            btnVerPdfVenta.FlatStyle = FlatStyle.Flat;
            btnVerPdfVenta.Cursor = Cursors.Hand;
            btnVerPdfVenta.FlatAppearance.BorderSize = 0;
            btnVerPdfVenta.Click += BtnVerPdfVenta_Click;

            // Control WebBrowser para renderizar el PDF dentro de la pestaña
            webBrowserPdfVenta.Location = new Point(210, 620);
            webBrowserPdfVenta.Size = new Size(600, 250);
            webBrowserPdfVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webBrowserPdfVenta.ScriptErrorsSuppressed = true;
        }

        private void BtnVerPdfVenta_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Archivos PDF (*.pdf)|*.pdf";
                openFile.Title = "Seleccionar Comprobante PDF de Venta";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    webBrowserPdfVenta.Navigate(openFile.FileName);
                }
            }
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            CargarArticulosCombo();
            if (cmbCondicionIvaCliente.Items.Count > 0)
                cmbCondicionIvaCliente.SelectedIndex = 0;

            ActualizarGrillaYTotales();
        }

        private void CargarArticulosCombo()
        {
            try
            {
                using (var context = new FacturacionDbContext())
                {
                    var lista = context.Articulos.ToList();
                    cmbArticulos.DataSource = null;
                    cmbArticulos.DataSource = lista;
                    cmbArticulos.DisplayMember = "Descripcion";
                    cmbArticulos.ValueMember = "IdArticulo";
                    cmbArticulos.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar artículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedItem is Articulo art)
            {
                numPrecio.Value = art.PrecioUnitario;
            }
        }

        private void CmbCondicionIvaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrillaYTotales();
        }

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedItem is Articulo artSeleccionado)
            {
                int cantidad = (int)numCantidad.Value;
                decimal precio = numPrecio.Value;

                if (cantidad <= 0 || precio <= 0)
                {
                    MessageBox.Show("Ingrese cantidad y precio válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar stock disponible
                using (var context = new FacturacionDbContext())
                {
                    var artDb = context.Articulos.Find(artSeleccionado.IdArticulo);
                    if (artDb != null && artDb.StockActual < cantidad)
                    {
                        MessageBox.Show($"Stock insuficiente. Stock actual disponible: {artDb.StockActual}", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                decimal subtotal = cantidad * precio;
                _detallesVenta.Add(new ComprobanteDetalle
                {
                    IdArticulo = artSeleccionado.IdArticulo,
                    Cantidad = cantidad,
                    PrecioUnitario = precio,
                    Subtotal = subtotal
                });

                ActualizarGrillaYTotales();
                cmbArticulos.SelectedIndex = -1;
                numCantidad.Value = 1;
                numPrecio.Value = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un artículo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnQuitarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                int index = dgvDetalles.SelectedRows[0].Index;
                _detallesVenta.RemoveAt(index);
                ActualizarGrillaYTotales();
            }
            else
            {
                MessageBox.Show("Seleccione un ítem para quitar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarGrillaYTotales()
        {
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = _detallesVenta;

            decimal subtotalBruto = _detallesVenta.Sum(d => d.Subtotal);
            string condicionCliente = cmbCondicionIvaCliente.SelectedItem?.ToString() ?? "Responsable Inscripto";

            decimal iva = 0m;
            if (condicionCliente == "Responsable Inscripto")
            {
                iva = Math.Round(subtotalBruto * 0.21m, 2);
                lblIvaTexto.Text = "IVA (21% Débito Fiscal):";
            }
            else
            {
                iva = 0m;
                lblIvaTexto.Text = "IVA (Consumidor Final / Monotributo - Incluido):";
            }

            decimal totalFinal = subtotalBruto + iva;
            string simbolo = cmbMoneda?.SelectedItem?.ToString() == "USD" ? "U$S" : "$";

            lblNetoVal.Text = $"{simbolo} {subtotalBruto:N2}";
            lblIvaVal.Text = $"{simbolo} {iva:N2}";
            lblTotalVal.Text = $"{simbolo} {totalFinal:N2}";
        }

        private void BtnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (!_detallesVenta.Any())
            {
                MessageBox.Show("Agregue al menos un producto a la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cliente = txtCliente.Text.Trim();
            string cuit = txtCuit.Text.Trim();

            if (string.IsNullOrEmpty(cliente) || string.IsNullOrEmpty(cuit))
            {
                MessageBox.Show("Complete los datos del cliente y su CUIT/DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal neto = _detallesVenta.Sum(d => d.Subtotal);
            string condicionCliente = cmbCondicionIvaCliente.SelectedItem?.ToString() ?? "Responsable Inscripto";
            decimal iva = (condicionCliente == "Responsable Inscripto") ? Math.Round(neto * 0.21m, 2) : 0m;
            decimal totalFinal = neto + iva;

            var comprobanteVenta = new Comprobante
            {
                IdUsuario = _usuarioLogueado.IdUsuario,
                TipoOperacion = "Venta",
                TipoComprobante = cmbTipoComprobante.SelectedItem?.ToString() ?? "Factura B",
                NombreEntidad = cliente,
                CuitEntidad = cuit,
                FechaEmision = dtpFecha.Value,
                NetoGravado = neto,
                ImporteIva = iva,
                Total = totalFinal,
                Moneda = cmbMoneda.SelectedItem?.ToString() == "USD" ? "USD" : "ARS",
                CotizacionDolar = numCotizacionDolar.Value,
                FormaPago = cmbFormaPago.SelectedItem?.ToString() ?? "Contado"
            };

            try
            {
                using (var context = new FacturacionDbContext())
                {
                    context.Comprobantes.Add(comprobanteVenta);

                    // Descontar stock al vender
                    foreach (var det in _detallesVenta)
                    {
                        var articuloDb = context.Articulos.Find(det.IdArticulo);
                        if (articuloDb != null)
                        {
                            if (articuloDb.StockActual < det.Cantidad)
                            {
                                throw new InvalidOperationException($"Stock insuficiente para el artículo {articuloDb.Descripcion}");
                            }
                            articuloDb.StockActual -= det.Cantidad;
                        }
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("¡Venta registrada con éxito y stock descontado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}