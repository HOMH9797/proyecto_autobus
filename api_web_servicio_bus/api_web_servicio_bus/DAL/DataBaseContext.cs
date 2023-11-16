using api_web_servicio_bus.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_web_servicio_bus.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Direccion>().HasIndex("address", "Availability", "id_cliente").IsUnique();
            modelBuilder.Entity<Telefono>().HasIndex("phone_number", "id_cliente").IsUnique();
            modelBuilder.Entity<Reserva>().HasIndex("number_ticket", "id_cliente").IsUnique();

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
