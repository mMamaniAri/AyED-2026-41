using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01__Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumar(5, 3));
            Console.ReadKey();
        }
        static int sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
    }
}
