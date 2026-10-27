using System.ComponentModel.DataAnnotations;

namespace SurTech.Financiero.Core.Entities
{
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; } = string.Empty; // Ej: "Cocina"
        public decimal PrecioUnitario { get; set; }
        public int StockActual { get; set; }
    }
}