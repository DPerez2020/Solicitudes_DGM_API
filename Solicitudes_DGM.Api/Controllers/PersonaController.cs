namespace Solicitudes_DGM.Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Solicitudes_DGM.Application.Persona;

    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService personaService;

        public PersonaController(IPersonaService personaService)
        {
            this.personaService = personaService;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<IEnumerable<PersonaModel>> Get()
        {
            try
            {
                var lista = await this.personaService.GetAll();
                return lista;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonaController>
        [HttpPost]
        public async Task<Domain.Entities.Persona.Persona> Post([FromBody] Domain.Entities.Persona.Persona persona)
        {
            return await this.personaService.Insert(persona);
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public async Task<Domain.Entities.Persona.Persona> Put(int id, [FromBody] Domain.Entities.Persona.Persona persona)
        {
            return await this.personaService.Update(persona);
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await this.personaService.Delete(id);
        }
    }
}
