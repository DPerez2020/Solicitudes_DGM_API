namespace Solicitudes_DGM.Application.Solicitud
{
    using Solicitudes_DGM.Persistence.Solicitud;

    public class SolicitudService
        : GenericService<Domain.Entities.Solicitud.Solicitud>, ISolicitudService
    {
        private ISolicitudRepository solicitudRepository;

        public SolicitudService(ISolicitudRepository personaRepository)
            : base(personaRepository)
        {
            this.solicitudRepository = personaRepository;
        }
    }
}
