using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Impuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Sueldo");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            MostrarDatos(nombre, sueldo);
            Impuesto(sueldo);
            Console.ReadKey();
        }
        public static void MostrarDatos(string nombre, double sueldo)
        {
            Console.Write(" Nombre: " + nombre);
            Console.WriteLine(" Sueldo: " + sueldo);

        }

        public static void Impuesto(double sueldo)
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debes de pagar impuestos");
            }
            else
            {
                Console.WriteLine("No pagas impuestos");
            }
        }
    }
}
