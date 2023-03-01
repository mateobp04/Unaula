using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            do
            {
                Console.WriteLine("Ingrese un valor entero para ver su tabla de multiplicar (-1 para salir):");
                valor = int.Parse(Console.ReadLine());

                if (valor != -1)
                {
                    Console.WriteLine("Tabla de multiplicar de "+ valor);
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", valor, i, valor * i);
                    }
                    Console.ReadKey();
                }
            } while (valor != -1);

        
        }
    }
    }

