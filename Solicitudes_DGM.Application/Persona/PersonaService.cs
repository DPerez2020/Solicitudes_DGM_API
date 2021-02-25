namespace Solicitudes_DGM.Application.Persona
{
    using Solicitudes_DGM.Persistence.Persona;

    public class PersonaService
        : GenericService<Domain.Entities.Persona.Persona>, IPersonaService
    {
        private IPersonaRepository personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
            : base(personaRepository)
        {
            this.personaRepository = personaRepository;
        }
    }
}
