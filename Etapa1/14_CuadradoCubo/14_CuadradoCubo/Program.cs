using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            cuadrado = Math.Pow(numero,2);
            cubo = Math.Pow(numero,3);
            Console.Write("El cuadrado del número es: ");
            Console.WriteLine(cuadrado);
            Console.Write("El cubo del número es: ");
            Console.WriteLine(cubo);
            Console.ReadKey();
        }
    }
}
