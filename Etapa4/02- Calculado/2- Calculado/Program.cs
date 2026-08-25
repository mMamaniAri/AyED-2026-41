using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Calculado
{
    class Program
    {
        static void Main(string[] args)
        {
            calculadora(2, 8, 6);
            Console.ReadKey();
        }
        static int suma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        static int resta(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        static int multiplicacion(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        static int division(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        static void calculadora(int opcion, int valor1, int valor2)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine(suma(valor1, valor2));
                    break;
                case 2:
                    Console.WriteLine(resta(valor1, valor2));
                    break;
                case 3:
                    Console.WriteLine(multiplicacion(valor1, valor2));
                    break;
                case 4:
                    Console.WriteLine(division(valor1, valor2));
                    break;
            }
        }
    }
}