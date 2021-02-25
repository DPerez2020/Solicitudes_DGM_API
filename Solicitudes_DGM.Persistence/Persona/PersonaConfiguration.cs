namespace Solicitudes_DGM.Persistence.Persona
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Solicitudes_DGM.Domain.Entities.Persona;

    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
