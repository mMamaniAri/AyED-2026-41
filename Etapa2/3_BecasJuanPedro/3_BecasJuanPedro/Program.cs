using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int ingresos;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese sus ingresos mensuales: ");
            ingresos = int.Parse(Console.ReadLine());
            if (edad > 19 && ingresos <= 100000)
            {
                Console.Write("Usted puede cobrar la beca");
            }
            else if (edad < 19 && ingresos == 0)
            {
                Console.Write("Usted puede cobrar la beca");
            }
            else if (edad == 19 && ingresos < 50000)
            {
                Console.Write("Usted puede cobrar la beca");
            }
            else
            {
                Console.Write("Usted no puede cobrar la beca");
            }
            Console.ReadKey();
        }
    }
}
