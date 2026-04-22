using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contador;
            Console.Write("Ingrese una palabra: ");
            palabra = Console.ReadLine();
            contador = 0;
            while (contador < 10)
            {
                contador++;
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
        }
    }
}
