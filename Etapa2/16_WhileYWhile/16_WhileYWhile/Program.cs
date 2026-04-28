using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 100;
            int cont5 = 0;
            int cont6 = 0;
            Console.WriteLine("Números impares entre 0 y 100: ");
            while (cont < 100)
            {
                cont++;
                if (cont % 2 != 0)
                {
                    Console.WriteLine(cont);
                }
            }
            Console.WriteLine("Números pares entre 0 y 100");
            while (cont2 < 100)
            {
                cont2++;
                if (cont2 % 2 == 0)
                {
                    Console.WriteLine(cont2);
                }
            }
            Console.WriteLine("Números del 0 al 100");
            while (cont3 <= 100)
            {
                Console.WriteLine(cont3);
                cont3++;
            }
            Console.WriteLine("Números del 100 al 0");
            while (cont4 >= 0)
            {
                Console.WriteLine(cont4);
                cont4--;
            }
            Console.WriteLine("Números múltiplos de 3 entre 0 y 100");
            while (cont5 < 100)
            {
                cont5++;
                if (cont5 % 3 == 0)
                {
                    Console.WriteLine(cont5);
                }
            }
            Console.WriteLine("Números múltiplos de 3 y 2 entre 0 y 100");
            while (cont6 < 100)
            {
                cont6++;
                if (cont6 % 2 == 0 && cont6 % 3 == 0)
                {
                    Console.WriteLine(cont6);
                }
            }
            Console.ReadKey();
        }
    }
}
