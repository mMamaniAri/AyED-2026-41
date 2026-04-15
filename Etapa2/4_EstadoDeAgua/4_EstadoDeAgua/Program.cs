using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            Console.Write("Ingrese una temperatura en grados celcius: ");
            temperatura = int.Parse(Console.ReadLine());
            if (temperatura <= 0)
            {
                Console.WriteLine("El agua está congelada");
            }
            else if (temperatura >= 100)
            {
                Console.WriteLine("El agua esta hirviendo");
            }
            else
            {
                Console.WriteLine("El agua esta líquida");
            }
            Console.ReadKey();

        }
    }
}
