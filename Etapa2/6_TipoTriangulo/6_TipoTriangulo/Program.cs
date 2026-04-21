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
            Console.Write("Ingrese el lado de un triángulo: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro lado de un triángulo: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro lado de un triángulo: ");
            lado3 = int.Parse(Console.ReadLine());
            if (lado1 + lado2 <= lado3 || lado2 + lado3 <= lado1 || lado1 + lado3 <= lado2)
            {
                Console.WriteLine("No se puede formar un triángulo");
            }
            else if (lado2 + lado3 > lado1 || lado3 + lado1 > lado2 || lado1 + lado2 > lado3)
            {
                Console.WriteLine("Se puede formar un triangulo");

                if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                {
                    Console.WriteLine("Se forma un triángulo equilatero");
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    Console.WriteLine("Se forma un triángulo isosceles|");
                }
                else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("Se forma un triángulo escaleno");
                }
            }
            Console.ReadKey();



        }
    }
}
