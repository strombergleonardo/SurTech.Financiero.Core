using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // <-- Agregar este namespace

namespace SurTech.Financiero.Core.Entities
{
    public class CuotaComprobante
    {
        [Key]
        public int IdCuota { get; set; }

        [ForeignKey("Comprobante")]
        public int IdComprobante { get; set; }

        public virtual Comprobante Comprobante { get; set; }

        public int NumeroCuota { get; set; }
        public decimal MontoBase { get; set; }
        public decimal PorcentajeInteres { get; set; }
        public decimal MontoInteres { get; set; }
        public decimal MontoTotalCuota => MontoBase + MontoInteres;
        public DateTime FechaVencimiento { get; set; }
        public bool Pagada { get; set; } = false;
    }
}