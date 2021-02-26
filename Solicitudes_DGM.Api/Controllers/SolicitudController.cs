// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solicitudes_DGM.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Solicitudes_DGM.Application.Solicitud;

    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {

        private readonly ISolicitudService solicitudService;

        public SolicitudController(ISolicitudService personaService)
        {
            this.solicitudService = personaService;
        }

        // GET: api/<SolicitudController>
        [HttpGet]
        public async Task<IEnumerable<Domain.Entities.Solicitud.Solicitud>> Get()
        {
            try
            {
                var solicitudes = await this.solicitudService.GetAll();

                return solicitudes;
            }
            catch (Exception)
            {               
                throw;
            }
        }

        // GET api/<SolicitudController>/5
        [HttpGet("{state}")]
        public string Get(string state)
        {
            return "value";
        }

        // POST api/<SolicitudController>
        [HttpPost]
        public async Task<Domain.Entities.Solicitud.Solicitud> Post([FromBody] Domain.Entities.Solicitud.Solicitud solicitud)
        {
            try
            {
                var result = await this.solicitudService.Insert(solicitud);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // PUT api/<SolicitudController>/5
        [HttpPut("{id}")]
        public async Task<Domain.Entities.Solicitud.Solicitud> Put(int id, [FromBody] Domain.Entities.Solicitud.Solicitud solicitud)
        {
            try
            {
                var entity = await this.solicitudService.Update(solicitud);
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/<SolicitudController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                await this.solicitudService.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
