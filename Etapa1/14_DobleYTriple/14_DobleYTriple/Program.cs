using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int doble;
            int triple;
            Console.Write("Ingrese un número entero: ");
            numero = int.Parse(Console.ReadLine());
            doble = numero * 2;
            triple = numero * 3;
            Console.Write("El doble del número es: ");
            Console.WriteLine(doble);
            Console.Write("El triple del número es: ");
            Console.WriteLine(triple);
            Console.ReadKey();


        }
    }
}
