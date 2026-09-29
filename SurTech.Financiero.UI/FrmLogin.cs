using System;
using System.Linq;
using System.Windows.Forms;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Services.BusinessLogic;
using SurTech.Financiero.Services.Interfaces;

namespace SurTech.Financiero.UI
{
    public partial class FrmLogin : Form
    {
        private readonly IUsuarioService _usuarioService;

        public FrmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();

            // Inicializar base de datos y usuario docente predeterminado (Virginia / Prof123)
            InicializarBaseDeDatosYDocente();
        }

        private void InicializarBaseDeDatosYDocente()
        {
            try
            {
                using (var context = new SurTech.Financiero.Data.Context.FacturacionDbContext())
                {
                    context.Database.EnsureCreated(); // Crea la base SQLite si no existe

                    // Verificar si existe la profesora Virginia
                    if (!context.Usuarios.Any(u => u.NombreUsuario == "Virginia"))
                    {
                        context.Usuarios.Add(new Usuario
                        {
                            NombreUsuario = "Virginia",
                            Contrasenia = "Prof123",
                            Perfil = "Docente"
                        });
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioLogueado = _usuarioService.Login(usuario, contrasenia);

            if (usuarioLogueado != null)
            {
                MessageBox.Show($"¡Bienvenido, {usuarioLogueado.NombreUsuario}!\nPerfil: {usuarioLogueado.Perfil}", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ocultar login, abrir el menú principal y cerrar al salir
                this.Hide();
                var frmMenuPrincipal = new FrmMenuPrincipal(usuarioLogueado);
                frmMenuPrincipal.ShowDialog();
                this.Close();
            }
            else
            {   
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Para registrarse, complete los campos de Usuario y Contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Todos los registros nuevos se crean estrictamente como Alumnos
            var nuevoAlumno = new Usuario
            {
                NombreUsuario = usuario,
                Contrasenia = contrasenia,
                Perfil = "Alumno"
            };

            if (_usuarioService.RegistrarUsuario(nuevoAlumno, out string mensajeError))
            {
                MessageBox.Show("¡Usuario Alumno registrado con éxito! Ya puede iniciar sesión.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContrasenia.Clear();
            }
            else
            {
                MessageBox.Show(mensajeError, "Error en el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}