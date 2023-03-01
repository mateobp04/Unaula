using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTEMPERATURA
{
    internal class Program
    {/// <summary>
    /// Mateo Becerra
    /// 28/02/2023
    /// Cambio de temperatura
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
     
            Console.WriteLine("Digitar 1 si lo necesita de celsius a farenheit");
            Console.WriteLine("Digitar 2 si lo necesita de farenheit a celsius");
            double Convertido = 0;
            string TipoDeTemperatura = "";
            TipoDeTemperatura=Console.ReadLine();
  

            if (TipoDeTemperatura == "1")
            {
                Console.WriteLine("Ingrese la temperatura en grados celsius");
         
                Console.WriteLine("celsius a farenheit es: " + ConversionTemperaturaCelsius(Convertido));
              
            }
            else if (TipoDeTemperatura == "2")
            {
                Console.WriteLine("Ingrese la temperatura en grados farenheit");
                Console.WriteLine("farenheit a celsius es: " + ConversionTemperaturaFarenheit(Convertido));

            }


            Console.ReadKey();
        }
      
        private static double ConversionTemperaturaCelsius(double Convertido)
        {
            double  Temperatura = 0;
           
             Temperatura = double.Parse(Console.ReadLine());
             Convertido = (Temperatura * (9 / 5) + 32);


            return Convertido;
        }
    
        private static double ConversionTemperaturaFarenheit(double Convertido)
        {
            double Temperatura = 0;
            Temperatura = double.Parse(Console.ReadLine());
            Convertido = (Temperatura - 32) * 5 / 9;


            return Convertido;
        
        }

    }
}
