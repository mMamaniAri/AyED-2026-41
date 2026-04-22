using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            contador = 0;
            while (contador<100)
            {
                contador++;
                if (contador % 3 == 0 && contador % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (contador % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (contador % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(contador);
                }
                
            }
            Console.ReadKey();
        }
    }
}
