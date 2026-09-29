using System;
using System.Drawing;
using System.Windows.Forms;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.UI.Modulos;

namespace SurTech.Financiero.UI
{
    public partial class FrmMenuPrincipal : Form
    {
        private readonly Usuario _usuarioLogueado;
        private Form _formularioActivo = null;

        // Estilo visual corporativo SurTech
        private readonly Color ColorFondoMenu = Color.FromArgb(51, 51, 51);      // #333333
        private readonly Color ColorAcentoNaranja = Color.FromArgb(255, 102, 0);  // #FF6600
        private readonly Color ColorTextoBlanco = Color.White;

        public FrmMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario ?? throw new ArgumentNullException(nameof(usuario));

            ConfigurarVentana();
            AplicarEstilosMenuDerecho();

            // Opcional: Mostrar por defecto la pestaña de recordatorios al iniciar sesión
            AbrirFormularioEnPanel(new FrmRecordatoriosVencimientos(_usuarioLogueado));
        }

        private void ConfigurarVentana()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = $"SurTech Financiero - Usuario: {_usuarioLogueado.NombreUsuario ?? "Operador"}";
        }

        private void AplicarEstilosMenuDerecho()
        {
            pnlMenuDerecha.BackColor = ColorFondoMenu;

            ConfigurarBotonMenu(btnVentas);
            ConfigurarBotonMenu(btnCompras);
            ConfigurarBotonMenu(btnStock);
            ConfigurarBotonMenu(btnRecordatorios);
            ConfigurarBotonMenu(btnCierre);
        }

        private void ConfigurarBotonMenu(Button btn)
        {
            if (btn == null) return;
            btn.BackColor = ColorFondoMenu;
            btn.ForeColor = ColorTextoBlanco;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            // Efecto hover corporativo
            btn.MouseEnter += (s, e) => { btn.BackColor = ColorAcentoNaranja; };
            btn.MouseLeave += (s, e) => { btn.BackColor = ColorFondoMenu; };
        }

        // Método central para gestionar las pestañas dentro del panel
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (_formularioActivo != null)
            {
                _formularioActivo.Close(); // Cierra el módulo anterior para liberar memoria y recursos
            }

            _formularioActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;
            formHijo.Show();
        }

        // --- EVENTOS DE LOS BOTONES DEL MENÚ DERECHO ---

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmVenta(_usuarioLogueado));
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmCompra(_usuarioLogueado));
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmStock(_usuarioLogueado));
        }

        private void BtnRecordatorios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmRecordatoriosVencimientos(_usuarioLogueado));
        }

        private void BtnCierre_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmCierreEjercicio(_usuarioLogueado));
        }
    }
}