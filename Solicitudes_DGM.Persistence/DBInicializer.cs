namespace Solicitudes_DGM.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using Solicitudes_DGM.Domain.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class DBInicializer
    {

        public static void Initialize(SolicitudesDBContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Persona.Any())
            {
                return;   // DB has been seeded
            }

            var personas = new Domain.Entities.Persona.Persona[]
            {
            new Domain.Entities.Persona.Persona {
                Nombre = "Dawin" , Apellido = "Perez",
                Direccion="Los rios",Sexo=Sexo.M,
                Estatus=true,Pasaporte="123456789",FechaNacimiento=DateTime.Parse("2001-05-04"),
                FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now,Foto = "",
            },
            new Domain.Entities.Persona.Persona{
                Nombre = "Frederick" , Apellido = "Luciano",
                Direccion="Charles summer",Sexo=Sexo.M,
                Estatus=true,Pasaporte="123456879",FechaNacimiento=DateTime.Parse("2001-05-04"),
                FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now,Foto = "",
            },
            new Domain.Entities.Persona.Persona{
                Nombre = "Pedro" , Apellido = "Sosa",
                Direccion="Pantoja",Sexo=Sexo.M,
                Estatus=true,Pasaporte="123456793",FechaNacimiento=DateTime.Parse("2001-05-04"),
                FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now,Foto = "",
            }
            };
            foreach (var p in personas)
            {
                context.Persona.Add(p);
            }
            context.SaveChanges();

            var estados = new Domain.Entities.Estado.Estado[]
            {
            new Domain.Entities.Estado.Estado{Nombre="Abiertas",Estatus=true,FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now},
            new Domain.Entities.Estado.Estado{Nombre="Cerradas",Estatus=true,FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now},
            new Domain.Entities.Estado.Estado{Nombre="Canceladas",Estatus=true,FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now}
            };
            foreach (var e in estados)
            {
                context.Estado.Add(e);
            }
            context.SaveChanges();

            var solicitudes = new Domain.Entities.Solicitud.Solicitud[]
            {
            new Domain.Entities.Solicitud.Solicitud{PersonaId=1,EstadoId=1,Estatus=true,FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now},
            new Domain.Entities.Solicitud.Solicitud{PersonaId=2,EstadoId=2,Estatus=true,FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now},
            new Domain.Entities.Solicitud.Solicitud{PersonaId=3,EstadoId=3,Estatus=true,FechaCreacion=DateTime.Now,FechaModificacion=DateTime.Now},
            };
            foreach (var s in solicitudes)
            {
                context.Solicitud.Add(s);
            }
            context.SaveChanges();
        }

    }
}
