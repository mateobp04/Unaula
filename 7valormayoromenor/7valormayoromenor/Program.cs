using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7valormayoromenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            // Encuentra el mayor de los tres números
            int mayor = num1;
            if (num2 > mayor)
            {
                mayor = num2;
            }
            if (num3 > mayor)
            {
                mayor = num3;
            }

            // Encuentra el menor de los tres números
            int menor = num1;
            if (num2 < menor)
            {
                menor = num2;
            }
            if (num3 < menor)
            {
                menor = num3;
            }

            Console.WriteLine("El mayor número es: " + mayor);
            Console.WriteLine("El menor número es: " + menor);
            Console.ReadKey();
    }
    }
}
