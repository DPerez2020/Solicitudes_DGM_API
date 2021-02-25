namespace Solicitudes_DGM.Domain.Entities.Estado
{
    using System;

    public class Estado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool Estatus { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}
