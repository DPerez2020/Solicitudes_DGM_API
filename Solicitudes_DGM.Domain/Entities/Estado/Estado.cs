namespace Solicitudes_DGM.Domain.Entities.Estado
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Estado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool Estatus { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}
