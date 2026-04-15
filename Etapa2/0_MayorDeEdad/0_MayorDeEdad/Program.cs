using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted no es mayor de edad");
            }
            Console.ReadKey();
        }  
    }
}
