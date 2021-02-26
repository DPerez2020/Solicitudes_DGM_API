namespace Solicitudes_DGM.Persistence.Estado
{
    public class EstadoRepository : GenericRepository<Domain.Entities.Estado.Estado>,IEstadoRepository
    {
        public EstadoRepository(SolicitudesDBContext context)
            : base(context)
        {
        }
    }
}
