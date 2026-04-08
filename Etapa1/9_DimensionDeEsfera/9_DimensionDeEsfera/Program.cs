using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi;
            double radio;
            double superficie;
            double volumen;
            pi = 3.14159265;
            Console.Write("Ingrese el radio de una esfera: ");
            radio = double.Parse(Console.ReadLine());
            superficie = 4 * pi * Math.Pow(radio, 2);
            volumen =4/3 *pi* Math.Pow(radio, 3);
            Console.Write("La superficie de la esfera es: ");
            Console.WriteLine(superficie);
            Console.Write("El volumen de la esfera es: ");
            Console.WriteLine(volumen);  
            Console.ReadKey();

        }
    }
}
