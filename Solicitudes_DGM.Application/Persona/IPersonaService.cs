
namespace Solicitudes_DGM.Application.Persona
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPersonaService : IGenericService<Domain.Entities.Persona.Persona>
    {
        new Task<List<PersonaModel>> GetAll();

        Task<Domain.Entities.Persona.Persona> Insert(Domain.Entities.Persona.Persona persona);
    }
}
