using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un número entero positivo: ");
            numero = int.Parse(Console.ReadLine());
            while (numero>=0)
            {
                Console.WriteLine(numero);
                numero--;
            }
            Console.ReadKey();
        }
    }
}
