using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.Write("Ingrese un año: ");
            año = int.Parse(Console.ReadLine());
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0 && año % 100 == 0)
            {
                Console.Write("El año ingresado es un año bisiesto");
            }
            else
            {
                Console.Write("El año ingresado no es un año bisiesto");
            }
            Console.ReadKey();
        }
    }
}
