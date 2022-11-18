using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio77
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> diccio = new SortedList<string, string>();
            
            diccio.Add("rojo", "red");
            diccio.Add("azul", "blue");
            diccio["verde"] = "green";
            diccio["amarillo"] = "yellow";
            diccio["blanco"] = "white";
            diccio["negro"] = "black";
            diccio["rosa"] = "pink";
            diccio["violeta"] = "violet";
            diccio["púrpura"] = "purple";


            string color;
            Console.WriteLine("Traductor de colores españo-ingles");
            Console.WriteLine("Ingrese un color:");
            color = Console.ReadLine();

            while (color != "salir") 
            {
                Console.WriteLine("La traduccion del color es:");
                Console.WriteLine(diccio[color]);
                Console.WriteLine("Ingrese otro color o ingrese ¨salir¨ para salir:");
                color = Console.ReadLine();
            }

          
           

        }
    }
}
