namespace Solicitudes_DGM.Persistence.Solicitud
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Solicitudes_DGM.Domain.Entities.Solicitud;

    public class SolicitudConfiguration : IEntityTypeConfiguration<Solicitud>
    {
        public void Configure(EntityTypeBuilder<Solicitud> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
