using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado;
            float perimetro;
            float superficie;
            Console.Write("Ingrese la longitud de un lado de un cuadrado: ");
            lado = float.Parse(Console.ReadLine());
            perimetro = lado * 4;
            superficie = lado * lado;
            Console.Write("El perimetro del cuadrado con esa longitud de lado es: ");
            Console.WriteLine(perimetro);
            Console.Write("La superficie del cuadrado con esa longitud de lado es: ");
            Console.WriteLine(superficie);
            Console.ReadKey();

        }
    }
}
