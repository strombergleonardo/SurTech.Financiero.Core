using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Data.Context;

namespace SurTech.Financiero.UI.Modulos
{
    public partial class FrmStock : Form
    {
        private readonly Usuario _usuarioLogueado;

        // Estilo visual SurTech
        private readonly Color ColorPrimarioOscuro = Color.FromArgb(51, 51, 51);
        private readonly Color ColorAcentoNaranja = Color.FromArgb(255, 102, 0);
        private readonly Color ColorFondoGeneral = Color.FromArgb(245, 247, 250);

        public FrmStock(Usuario usuarioLogueado)
        {
            InitializeComponent();
            _usuarioLogueado = usuarioLogueado ?? throw new ArgumentNullException(nameof(usuarioLogueado));

            this.WindowState = FormWindowState.Maximized;
            AplicarEstiloVisual();
        }

        private void AplicarEstiloVisual()
        {
            this.BackColor = ColorFondoGeneral;

            btnActualizarStock.BackColor = ColorAcentoNaranja;
            btnActualizarStock.ForeColor = Color.White;
            btnActualizarStock.FlatStyle = FlatStyle.Flat;
            btnActualizarStock.FlatAppearance.BorderSize = 0;

            btnBuscar.BackColor = ColorPrimarioOscuro;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            CargarGrillaStock();
        }

        private void CargarGrillaStock(string filtro = "")
        {
            try
            {
                using (var context = new FacturacionDbContext())
                {
                    var query = context.Articulos.AsQueryable();

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query = query.Where(a => a.Descripcion.Contains(filtro));
                    }

                    var lista = query.Select(a => new
                    {
                        a.IdArticulo,
                        a.Descripcion,
                        a.PrecioUnitario,
                        a.StockActual
                    }).ToList();

                    dgvStock.DataSource = null;
                    dgvStock.DataSource = lista;

                    // Formatear columnas del DataGridView si existe
                    if (dgvStock.Columns["IdArticulo"] != null)
                        dgvStock.Columns["IdArticulo"].HeaderText = "Código";
                    if (dgvStock.Columns["Descripcion"] != null)
                        dgvStock.Columns["Descripcion"].HeaderText = "Descripción del Artículo";
                    if (dgvStock.Columns["PrecioUnitario"] != null)
                    {
                        dgvStock.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                        dgvStock.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
                    }
                    if (dgvStock.Columns["StockActual"] != null)
                        dgvStock.Columns["StockActual"].HeaderText = "Stock Actual";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            CargarGrillaStock(filtro);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Búsqueda en tiempo real opcional
            string filtro = txtBuscar.Text.Trim();
            CargarGrillaStock(filtro);
        }

        private void BtnActualizarStock_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un artículo de la lista para modificar su stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idArticulo = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["IdArticulo"].Value);
            string descripcion = dgvStock.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            int stockActual = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["StockActual"].Value);

            // Ventana emergente simple para pedir el nuevo valor de stock
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Ingrese el nuevo stock físico para '{descripcion}':",
                "Ajuste Manual de Stock",
                stockActual.ToString());

            if (int.TryParse(input, out int nuevoStock))
            {
                if (nuevoStock < 0)
                {
                    MessageBox.Show("El stock no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (var context = new FacturacionDbContext())
                    {
                        var articuloDb = context.Articulos.Find(idArticulo);
                        if (articuloDb != null)
                        {
                            articuloDb.StockActual = nuevoStock;
                            context.SaveChanges();
                        }
                    }

                    MessageBox.Show("¡Stock actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaStock(txtBuscar.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el nuevo stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}