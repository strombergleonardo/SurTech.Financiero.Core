using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Data.Context;

namespace SurTech.Financiero.UI
{
    public partial class FrmCompra : Form
    {
        private readonly Usuario _usuarioLogueado;
        private readonly List<ComprobanteDetalle> _detallesCompra = new List<ComprobanteDetalle>();

        // Estilo visual SurTech
        private readonly Color ColorPrimarioOscuro = Color.FromArgb(51, 51, 51);
        private readonly Color ColorAcentoNaranja = Color.FromArgb(255, 102, 0);
        private readonly Color ColorFondoGeneral = Color.FromArgb(245, 247, 250);

        public FrmCompra(Usuario usuarioLogueado)
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

            btnGuardarCompra.BackColor = ColorAcentoNaranja;
            btnGuardarCompra.ForeColor = Color.White;
            btnGuardarCompra.FlatStyle = FlatStyle.Flat;
            btnGuardarCompra.FlatAppearance.BorderSize = 0;

            btnAgregarDetalle.BackColor = ColorPrimarioOscuro;
            btnAgregarDetalle.ForeColor = Color.White;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.FlatAppearance.BorderSize = 0;

            btnQuitarDetalle.BackColor = Color.FromArgb(100, 100, 100);
            btnQuitarDetalle.ForeColor = Color.White;
            btnQuitarDetalle.FlatStyle = FlatStyle.Flat;
            btnQuitarDetalle.FlatAppearance.BorderSize = 0;
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            ConfigurarAutocompletadoArticulos();
            CargarArticulosCombo();
            if (cmbCondicionIvaProveedor.Items.Count > 0)
                cmbCondicionIvaProveedor.SelectedIndex = 0;

            ActualizarGrillaYTotales();
        }

        private void ConfigurarAutocompletadoArticulos()
        {
            // Permite escribir texto libremente además de seleccionar de la lista
            cmbArticulos.DropDownStyle = ComboBoxStyle.DropDown;
            cmbArticulos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbArticulos.AutoCompleteSource = AutoCompleteSource.ListItems;
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

        private void CmbCondicionIvaProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrillaYTotales();
        }

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {
            string descripcionIngresada = cmbArticulos.Text.Trim();

            if (string.IsNullOrEmpty(descripcionIngresada))
            {
                MessageBox.Show("Ingrese o seleccione un artículo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)numCantidad.Value;
            decimal precio = numPrecio.Value;

            if (cantidad <= 0 || precio <= 0)
            {
                MessageBox.Show("Ingrese cantidad y precio válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new FacturacionDbContext())
                {
                    // Búsqueda flexible ignorando mayúsculas/minúsculas para evitar duplicados por variaciones ortográficas
                    var articuloAUsar = context.Articulos
                        .FirstOrDefault(a => a.Descripcion.ToLower() == descripcionIngresada.ToLower());

                    if (articuloAUsar == null)
                    {
                        // Si no existe, se registra automáticamente al vuelo
                        articuloAUsar = new Articulo
                        {
                            Descripcion = descripcionIngresada,
                            PrecioUnitario = precio,
                            StockActual = 0
                        };

                        context.Articulos.Add(articuloAUsar);
                        context.SaveChanges(); // Genera el ID del nuevo artículo
                    }

                    int idArticuloFinal = articuloAUsar.IdArticulo;
                    decimal subtotal = cantidad * precio;

                    _detallesCompra.Add(new ComprobanteDetalle
                    {
                        IdArticulo = idArticuloFinal,
                        Cantidad = cantidad,
                        PrecioUnitario = precio,
                        Subtotal = subtotal
                    });
                }

                ActualizarGrillaYTotales();
                CargarArticulosCombo(); // Actualiza el origen de datos para incluir el nuevo artículo en las sugerencias

                cmbArticulos.Text = string.Empty;
                cmbArticulos.SelectedIndex = -1;
                numCantidad.Value = 1;
                numPrecio.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnQuitarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                int index = dgvDetalles.SelectedRows[0].Index;
                _detallesCompra.RemoveAt(index);
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
            dgvDetalles.DataSource = _detallesCompra;

            decimal subtotalBruto = _detallesCompra.Sum(d => d.Subtotal);
            string condicionProveedor = cmbCondicionIvaProveedor.SelectedItem?.ToString() ?? "Responsable Inscripto";

            decimal iva = 0m;
            if (condicionProveedor == "Responsable Inscripto")
            {
                iva = Math.Round(subtotalBruto * 0.21m, 2);
                lblIvaTexto.Text = "IVA (21% Crédito Fiscal):";
            }
            else
            {
                iva = 0m;
                lblIvaTexto.Text = "IVA (No Discriminable / Monotributo):";
            }

            decimal totalFinal = subtotalBruto + iva;
            string simbolo = cmbMoneda?.SelectedItem?.ToString() == "USD" ? "U$S" : "$";

            lblNetoVal.Text = $"{simbolo} {subtotalBruto:N2}";
            lblIvaVal.Text = $"{simbolo} {iva:N2}";
            lblTotalVal.Text = $"{simbolo} {totalFinal:N2}";
        }

        private void BtnGuardarCompra_Click(object sender, EventArgs e)
        {
            if (!_detallesCompra.Any())
            {
                MessageBox.Show("Agregue al menos un producto a la compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string proveedor = txtProveedor.Text.Trim();
            string cuit = txtCuit.Text.Trim();

            if (string.IsNullOrEmpty(proveedor) || string.IsNullOrEmpty(cuit))
            {
                MessageBox.Show("Complete los datos del proveedor y su CUIT.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal neto = _detallesCompra.Sum(d => d.Subtotal);
            string condicionProveedor = cmbCondicionIvaProveedor.SelectedItem?.ToString() ?? "Responsable Inscripto";
            decimal iva = (condicionProveedor == "Responsable Inscripto") ? Math.Round(neto * 0.21m, 2) : 0m;
            decimal totalFinal = neto + iva;

            var comprobanteCompra = new Comprobante
            {
                IdUsuario = _usuarioLogueado.IdUsuario,
                TipoOperacion = "Compra",
                TipoComprobante = cmbTipoComprobante.SelectedItem?.ToString() ?? "Factura A",
                NombreEntidad = proveedor,
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
                    context.Comprobantes.Add(comprobanteCompra);

                    // Aumentar stock al registrar la compra
                    foreach (var det in _detallesCompra)
                    {
                        var articuloDb = context.Articulos.Find(det.IdArticulo);
                        if (articuloDb != null)
                        {
                            articuloDb.StockActual += det.Cantidad;
                        }
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("¡Compra registrada con éxito y stock actualizado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}