namespace Solicitudes_DGM.Domain.Entities.Solicitud
{
    using System;
    using Solicitudes_DGM.Domain.Entities.Estado;
    using Solicitudes_DGM.Domain.Entities.Persona;

    public class Solicitud
    {
        public long Id { get; set; }

        public int PersonaId { get; set; }

        public int EstadoId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }

        public bool Estatus { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
