namespace Solicitudes_DGM.Persistence.Persona
{
    public class PersonaRepository : GenericRepository<Domain.Entities.Persona.Persona>, IPersonaRepository
    {
        public PersonaRepository(SolicitudesDBContext context)
            : base(context)
        {
        }
    }
}
