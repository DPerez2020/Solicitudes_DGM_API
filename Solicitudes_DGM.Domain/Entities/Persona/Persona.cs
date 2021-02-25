namespace Solicitudes_DGM.Domain.Entities.Persona
{
    using System;
    using System.Collections.Generic;
    using Solicitudes_DGM.Domain.Entities.Solicitud;
    using Solicitudes_DGM.Domain.Enums;

    public class Persona
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Pasaporte { get; set; }

        public string Direccion { get; set; }

        public Sexo Sexo { get; set; }

        public string Foto { get; set; }

        public bool Estatus { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<Solicitud> Solicitudes { get; set; }
    }
}
