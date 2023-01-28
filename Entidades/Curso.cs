using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string id { get; private set; }
        public string Nombre { get; set; }

        public Jornada Jornadas { get; set; }

        public List<Alumnos> Alumnos { get; set; }
        public List<Asignatura> Asignaturas { get; set; }

        public Curso()
        {
          id=Guid.NewGuid().ToString();  
        }
    }
}