namespace Solicitudes_DGM.Application.Persona
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FluentValidation.Results;
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

        public new async Task<List<PersonaModel>> GetAll()
        {
            var personList = await this.personaRepository.GetAll();
            return personList.AsQueryable().Select(x => new PersonaModel
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Direccion = x.Direccion,
                FechaNacimiento = x.FechaNacimiento,
                Pasaporte = x.Pasaporte,
                Foto = x.Foto,
                Sexo = x.Sexo == "M" ? "Masculino" : "Femenino",
            }).ToList();
        }

        public async Task<Domain.Entities.Persona.Persona> InsertValidate(Domain.Entities.Persona.Persona persona)
        {
            //var person = new Domain.Entities.Persona.Persona
            //{
            //    Nombre = persona.Nombre,
            //    Apellido = persona.Apellido,
            //    Sexo = persona.Sexo,
            //    Pasaporte = persona.Pasaporte,
            //    FechaNacimiento = persona.FechaNacimiento,
            //    Direccion = persona.Direccion,
            //    Foto = persona.Foto,
            //};

            var validation = new PersonaValidator();

            ValidationResult result = await validation.ValidateAsync(persona);

            if (!result.IsValid)
            {
                var message = " ";
                foreach (var item in result.Errors)
                {
                    message += item.ErrorMessage + Environment.NewLine;
                }

                throw new Exception("Ha ocurrido un error al intentar crear la persona.\n" + message);
            }
            else
            {
                return await this.personaRepository.Insert(persona);

                //return new PersonaModel
                //{
                //    Id = x.Id,
                //    Nombre = x.Nombre,
                //    Apellido = x.Apellido,
                //    Direccion = x.Direccion,
                //    FechaNacimiento = x.FechaNacimiento,
                //    Pasaporte = x.Pasaporte,
                //    Foto = x.Foto,
                //    Sexo = x.Sexo == "M" ? "Masculino" : "Femenino",
                //};

            }
        }
    }
}
