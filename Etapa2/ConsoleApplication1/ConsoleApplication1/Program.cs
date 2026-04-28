using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la Temperatura: ");
            int grados = int.Parse(Console.ReadLine());

            if (grados <= 0)
            { 
                Console.WriteLine("Se congela");
            }
            else if (grados >= 100)
            { 
                Console.WriteLine("Hierve");
            }
            else
            {
                Console.WriteLine("Esta Líquido");
             }
            Console.ReadKey();
        }
    }
}
