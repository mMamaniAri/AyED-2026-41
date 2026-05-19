using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros[0] = 2;
            numeros[1] = 4;
            numeros[2] = 6;
            numeros[3] = 8;

            Array.Reverse(numeros);

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();

        }
    }
}
