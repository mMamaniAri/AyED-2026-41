using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double numero3;
            double promedio;
            Console.Write("Ingrese un número: ");
            numero1 = double.Parse( Console.ReadLine());
            Console.Write("Ingrese un segundo número: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese un tercer número: ");
            numero3 = double.Parse(Console.ReadLine());
            promedio = (numero1 + numero2 + numero3) / 3;
            Console.Write("El promedio de los números es: ");
            Console.WriteLine(promedio);
            Console.ReadKey();

        }
    }
}
