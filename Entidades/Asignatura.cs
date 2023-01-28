using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string Id { get; private set; }

        public string Nombre { get; set; }

        public Asignatura()
        {
            Id=Guid.NewGuid().ToString();  
        }
    }
}