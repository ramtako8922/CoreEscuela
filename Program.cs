// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.EscribirTitulo("BIENVENIDOS A LA ESCUELA");
            Printer.Pitar(10000, 3000, cantidad: 10);
            ImpimirCursosEscuela(engine.Escuela);
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {

            Printer.EscribirTitulo("cursos de la Escuela");


            if (escuela?.cursos != null)
            {
                foreach (var curso in escuela.cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id  {curso.id}");
                }
            }
        }
    }
}