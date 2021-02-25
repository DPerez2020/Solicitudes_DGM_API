namespace Solicitudes_DGM.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using Solicitudes_DGM.Persistence.Estado;
    using Solicitudes_DGM.Persistence.Persona;
    using Solicitudes_DGM.Persistence.Solicitud;

    public class SolicitudesDBContext : DbContext
    {
        public SolicitudesDBContext(DbContextOptions<SolicitudesDBContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Entities.Persona.Persona> Persona { get; set; }

        public DbSet<Domain.Entities.Solicitud.Solicitud> Solicitud { get; set; }

        public DbSet<Domain.Entities.Estado.Estado> Estado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonaConfiguration());
            modelBuilder.ApplyConfiguration(new SolicitudConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
        }
    }
}
