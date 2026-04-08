using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius;
            double farenheit;
            double kelvin;
            Console.Write("Ingrese una temperatura en Celcius: ");
            celcius = int.Parse(Console.ReadLine());
            farenheit = celcius * 1.8 + 32;
            kelvin = celcius + 273.15;
            Console.Write("Pasahe a Farenheit: ");
            Console.WriteLine(farenheit);
            Console.Write("Pasaje a Kelvin: ");
            Console.WriteLine(kelvin);
            Console.ReadKey();




        }
    }
}
