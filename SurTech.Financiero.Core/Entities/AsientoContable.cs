using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SurTech.Financiero.Core.Entities
{
    public class AsientoContable
    {
        [Key]
        public int IdAsiento { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Concepto { get; set; } = string.Empty;
        public List<AsientoDetalle> Detalles { get; set; } = new List<AsientoDetalle>();
    }

    public class AsientoDetalle
    {
        [Key]
        public int IdAsientoDetalle { get; set; }
        public int IdAsiento { get; set; }
        public string Cuenta { get; set; } = string.Empty; // Ej: "Caja", "Mercaderías", "IVA Crédito Fiscal", etc.
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
    }
}