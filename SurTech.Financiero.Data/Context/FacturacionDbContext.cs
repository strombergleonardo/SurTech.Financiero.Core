using Microsoft.EntityFrameworkCore;
using SurTech.Financiero.Core.Entities;
using System;
using System.IO;

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

        // Definición de tablas / entidades
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<AsientoContable> AsientosContables { get; set; }
        public DbSet<CuotaComprobante> CuotasComprobantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 1. Obtener la ruta AppData de la PC del usuario actual
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appDirectory = Path.Combine(appDataFolder, "SurTechFinanciero");

                // 2. Crear la carpeta automáticamente si no existe
                if (!Directory.Exists(appDirectory))
                {
                    Directory.CreateDirectory(appDirectory);
                }

                // 3. Definir la ruta del archivo SQLite
                string dbPath = Path.Combine(appDirectory, "surtech_financiero.db");

                // 4. Configurar SQLite
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comprobante>(entity =>
            {
                entity.Property(c => c.NetoGravado).HasColumnType("decimal(18,2)");
                entity.Property(c => c.ImporteIva).HasColumnType("decimal(18,2)");
                entity.Property(c => c.Total).HasColumnType("decimal(18,2)");
                entity.Property(c => c.PorcentajeInteres).HasColumnType("decimal(18,2)");
                entity.Property(c => c.CotizacionDolar).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<CuotaComprobante>(entity =>
            {
                entity.Property(c => c.MontoBase).HasColumnType("decimal(18,2)");
                entity.Property(c => c.PorcentajeInteres).HasColumnType("decimal(18,2)");
                entity.Property(c => c.MontoInteres).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.Property(a => a.PrecioUnitario).HasColumnType("decimal(18,2)");
            });
        }
    }
}