using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3MapaCoordenadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Cual es la Coordenada x");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Cual es la Coordenada y");
                double y = Convert.ToDouble(Console.ReadLine());

                Coordenadas(x, y);
            }

            public static void Coordenadas(double x, double y)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primer cuadrante.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo cuadrante.");

                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Tercer cuadrante.");

                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Cuarto cuadrante.");
                }
                else
                {
                    Console.WriteLine("Escribe los datos correctamente");
                }
                Console.ReadKey();
            }
        }
}
