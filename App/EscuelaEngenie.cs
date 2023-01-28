using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academay", 2012, TiposEscuela.primaria,
            ciudad: "Bogotá", pais: "Colombia"
            );

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
              {
          
            foreach(var curso in Escuela.cursos)
            {
                foreach(var asignatura in curso.Asignaturas)
                {
                    foreach(var alumnos in curso.Alumnos)

                    {
                         Random rnd = new Random(System.Environment.TickCount); 
                         for (int i = 0; i < 5; i++)
                         {
                            var ev=new Evaluaciones(){
                                Nombre=$"{asignatura.Nombre} EV{i+1}",
                                Nota=(float)(5*rnd.NextDouble()),
                                Alumno=alumnos
                                
                            };
                         }
                    }
                }
            }
        }   

        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas"} ,
                            new Asignatura{Nombre="Educación Física"},
                            new Asignatura{Nombre="Castellano"},
                            new Asignatura{Nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumnos> GenerarAlumnosAlAzar( int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumnos{ Nombre=$"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy( (al)=> al.Id ).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornadas = Jornada.Mañana },
                        new Curso() {Nombre = "201", Jornadas = Jornada.Mañana},
                        new Curso{Nombre = "301", Jornadas = Jornada.Mañana},
                        new Curso(){ Nombre = "401", Jornadas = Jornada.Tarde },
                        new Curso() {Nombre = "501", Jornadas = Jornada.Tarde},
            };
            
            Random rnd = new Random();
            foreach(var c in Escuela.cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}