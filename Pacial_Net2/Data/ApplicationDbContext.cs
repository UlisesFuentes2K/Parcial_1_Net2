using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Pacial_Net2.Models;

namespace Pacial_Net2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Vehiculo> vehiculos { get; set; }
        public DbSet<Venta> ventas { get; set; }

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Marca>( m => m.ToTable("marca").HasKey(m => m.Id ));
            modelBuilder.Entity<Vehiculo>(v => v.ToTable("vehiculo").HasKey(v => v.Id));
            modelBuilder.Entity<Venta>(ve => ve.ToTable("venta").HasKey(ve => ve.Id));
        }
    }
}
