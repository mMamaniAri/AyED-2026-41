using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;
            Console.Write("Ingrese el lado de un triánguklo: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro lado de un triánguklo: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro lado de un triánguklo: ");
            lado3 = int.Parse(Console.ReadLine());
            if (lado1 > lado2 && lado1 > lado3)
            {

            }
            if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("Se forma un triángulo isosceles");
            }
            Console.ReadKey();
        }
    }
}
