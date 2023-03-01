using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lado del cuadrado");
            double lado = Convert.ToDouble(Console.ReadLine());

            Perimetro(lado);
            Superficie(lado);

            Console.ReadKey();
        }


        public static void Perimetro(double lado)
        {
            double perimetro = lado * 4;
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
        }
        public static void Superficie(double lado)
        {
            double superficie = lado * lado;
            Console.WriteLine("La superficie del cuadrado es: " + superficie);
        }
    }
}
