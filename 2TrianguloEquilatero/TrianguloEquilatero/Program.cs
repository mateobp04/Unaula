using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEquilatero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el primer lado");
            double L1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo Lado");
            double L2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer Lado ");
            double L3 = Convert.ToDouble(Console.ReadLine());

            Mayor(L1, L2, L3);
        }


        public static void Mayor(double L1, double L2, double L3)
        {
            if (L1 > L2 & L1 > L3)
            {
                Console.WriteLine("El primer lado es el mayor");
            }
            else if (L2 > L1 & L2 > L3)
            {
                Console.WriteLine("El segundo lado es el mayor");
            }
            else if (L3 > L1 & L3 > L2)
            {
                Console.WriteLine("El tercer lado es el mayor");
            }
            else
            {
                EntoncesEquilatero();

            }
            Console.ReadKey();

        }

        public static void EntoncesEquilatero()
        {
            Console.WriteLine("El triangulo es equilatero");
        }

    }
}
