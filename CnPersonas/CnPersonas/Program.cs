using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnPersonas
{/// <summary>
/// Mateo Becerra
/// 28/02/2023
/// Mayoria de edad
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Eres mayor de edad?");
            Console.WriteLine("1 Sí");
            Console.WriteLine("2 No");
            string Mayor = Console.ReadLine();

            if (Mayor == "1")
            {

                Formulario();

            }
            else if (Mayor == "2")
            {
                Console.WriteLine("Eres menor de edad");

            }
            Console.ReadKey();
        }
        private static void Formulario()
        {

          
            Console.WriteLine("Apellido?");
            Console.ReadLine();
            Console.WriteLine("Edad");
            Console.ReadLine();
            Console.WriteLine("Correo electronico");
            Console.ReadLine();
            Console.WriteLine("adios");
         
        }
       
    }
}

