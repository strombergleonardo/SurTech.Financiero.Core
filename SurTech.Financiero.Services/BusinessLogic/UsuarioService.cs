using System.Linq;
using SurTech.Financiero.Core.Entities;
using SurTech.Financiero.Data.Context;
using SurTech.Financiero.Services.Interfaces;

namespace SurTech.Financiero.Services.BusinessLogic
{
    public class UsuarioService : IUsuarioService
    {
        public Usuario? Login(string nombreUsuario, string contrasenia)
        {
            using (var context = new FacturacionDbContext())
            {
                return context.Usuarios
                    .FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contrasenia == contrasenia);
            }
        }

        public bool RegistrarUsuario(Usuario nuevoUsuario, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var context = new FacturacionDbContext())
            {
                if (context.Usuarios.Any(u => u.NombreUsuario == nuevoUsuario.NombreUsuario))
                {
                    mensajeError = "El nombre de usuario ya existe.";
                    return false;
                }

                context.Usuarios.Add(nuevoUsuario);
                context.SaveChanges();
                return true;
            }
        }
    }
}