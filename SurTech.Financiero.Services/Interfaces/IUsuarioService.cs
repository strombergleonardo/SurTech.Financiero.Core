using SurTech.Financiero.Core.Entities;

namespace SurTech.Financiero.Services.Interfaces
{
    public interface IUsuarioService
    {
        Usuario? Login(string nombreUsuario, string contrasenia);
        bool RegistrarUsuario(Usuario nuevoUsuario, out string mensajeError);
    }
}