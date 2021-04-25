using Microsoft.EntityFrameworkCore;
using Proyecto_final.Data.Models;

namespace Proyecto_final.Data
{
    public class SistemaDbContext : DbContext
    {
        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reservacion> Reservaciones { get; set; }

        public SistemaDbContext(DbContextOptions<SistemaDbContext> options)
            : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //     optionsBuilder.UseSqlite("Data Source = sistema.db");
        // }
    }
}
