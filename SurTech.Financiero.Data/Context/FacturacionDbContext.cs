using Microsoft.EntityFrameworkCore;
using SurTech.Financiero.Core.Entities;

namespace SurTech.Financiero.Data.Context
{
    public class FacturacionDbContext : DbContext
    {
        public FacturacionDbContext()
        {
        }

        public FacturacionDbContext(DbContextOptions<FacturacionDbContext> options)
            : base(options)
        {
        }

        // Definición exacta basada en tus entidades existentes
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<AsientoContable> AsientosContables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SurTechFinancieroDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ajustes opcionales de precisión decimal si tus entidades usan decimales
            // modelBuilder.Entity<Comprobante>().Property(c => c.Total).HasColumnType("decimal(18,2)");
        }
    }
}