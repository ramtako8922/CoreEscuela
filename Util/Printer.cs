using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
       public static void DibujarLinea(int tam=10){

        WriteLine("".PadLeft(tam,'='));
       }

       public static void EscribirTitulo(string titulo){
        DibujarLinea(titulo.Length);
        WriteLine($"{titulo}");
        DibujarLinea(titulo.Length);

       } 

       public static void Pitar( int hz,int tiempo, int cantidad){
        while (cantidad>0)
        {
           System.Console.Beep(hz,tiempo);
           cantidad--;  
        }
       

       }
    }
}