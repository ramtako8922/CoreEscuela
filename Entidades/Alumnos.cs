using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Entidades
{
    public class Alumnos
    {
        public string Id { get; private set; }

        public string Nombre { get; set; }

        public Alumnos()
        {
            Id=Guid.NewGuid().ToString();  
        }
    }
}