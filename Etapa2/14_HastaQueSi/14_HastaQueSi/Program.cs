using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string si;
            si = "SI";
            Console.Write("¿Desea terminar el programa?: ");
            palabra = Console.ReadLine();
            while (palabra != si)
            {
                Console.Write("¿Desea terminar el programa?: ");
                palabra = Console.ReadLine();
            }
            Console.ReadKey();
            


        }
    }
}
