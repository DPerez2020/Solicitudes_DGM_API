namespace Solicitudes_DGM.Persistence.Estado
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Solicitudes_DGM.Domain.Entities.Estado;

    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Nombre).IsUnique();
            builder.Property(x => x.Nombre).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.FechaCreacion).ValueGeneratedOnAdd();
            builder.Property(x => x.Estatus).HasDefaultValue(true);
        }
    }
}
