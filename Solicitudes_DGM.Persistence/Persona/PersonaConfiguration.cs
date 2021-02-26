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
            builder.Property(x => x.Pasaporte).HasMaxLength(9).IsRequired(true);
            builder.HasIndex(x => x.Pasaporte).IsUnique();
            builder.Property(x => x.FechaCreacion).ValueGeneratedOnAdd();
            builder.Property(x => x.Sexo).HasMaxLength(1).IsRequired(true);
            builder.Property(x => x.Nombre).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Apellido).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Direccion).HasMaxLength(70).IsRequired(true);
            builder.Property(x => x.Estatus).HasDefaultValue(true);
        }
    }
}
