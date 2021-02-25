namespace Solicitudes_DGM.Persistence.Solicitud
{
    public class SolicitudRepository:GenericRepository<Domain.Entities.Solicitud.Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(SolicitudesDBContext context)
            : base(context)
        {
        }
    }
}
