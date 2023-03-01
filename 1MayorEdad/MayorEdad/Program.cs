using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorEdad
{/// <summary>
/// Mateo Becerra
/// 28/02/2023
/// Primer punto taller
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            

                Console.WriteLine("Escribe cual es tu nombre");
                string Nombre = Console.ReadLine();

                Console.WriteLine(Nombre + " cual es tu edad");
                int edad = Convert.ToInt16(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine(Nombre + " Super eres mayor de edad");

                }
                else
                {
                    Console.WriteLine(Nombre + " Que mal eres menor de edad");
                }
                Console.ReadKey();
            
        }

    }
}
