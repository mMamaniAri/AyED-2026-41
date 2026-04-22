using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int cont;
            Console.Write("Ingrese un número entero: ");
            n = int.Parse(Console.ReadLine());
            cont = 0;
            while (cont < n)
            {
                cont++;
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
            }
            Console.ReadKey();
        }
    }
}
