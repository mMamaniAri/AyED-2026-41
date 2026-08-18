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
            int[] edades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese una edad:");
                edades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Edades cargadas:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(edades[i]+", ");
            }
            Console.ReadKey();
        }
    }
}
