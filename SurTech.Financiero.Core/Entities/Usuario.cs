using System.ComponentModel.DataAnnotations;

namespace SurTech.Financiero.Core.Entities
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string Contrasenia { get; set; } = string.Empty;
        public string Perfil { get; set; } = "Alumno"; // "Alumno" o "Docente"
    }
}