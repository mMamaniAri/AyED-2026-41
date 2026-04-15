using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un núnmero entero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par");
            }
            else
            {
                Console.WriteLine("El número ingresado es impar");
            }
            Console.ReadKey();
            //Simplemente se cumplirá la condición ya que 0 dividido por 2 es cero y el resto también es cero
        }
    }
}
