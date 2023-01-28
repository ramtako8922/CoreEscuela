using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string Id { get; private set; }

        public string Nombre { get; set; }

        public Alumnos Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        public Evaluaciones()
        {
            Id=Guid.NewGuid().ToString();  
        }
    }
}