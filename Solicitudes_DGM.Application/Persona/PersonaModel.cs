namespace Solicitudes_DGM.Application.Persona
{
    using System;

    public class PersonaModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Pasaporte { get; set; }

        public string Direccion { get; set; }

        public string Sexo { get; set; }

        public string Foto { get; set; }
    }
}
