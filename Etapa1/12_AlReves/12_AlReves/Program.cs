using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            string letras;
            Console.Write("Ingrese 3 letras: ");
            letras = Console.ReadLine();
            Console.Write("En orden inverso: ");
            Console.Write(letras[2]);
            Console.Write(letras[1]);
            Console.Write(letras[0]);
            Console.ReadKey();



        }
    }
}
