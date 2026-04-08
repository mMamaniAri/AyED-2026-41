using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float ancho;
            float alto;
            float area;
            Console.Write("Ingrese el ancho de un triangulo: ");
            ancho = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el alto de un triangulo: ");
            alto = float.Parse(Console.ReadLine());
            area = (ancho * alto) / 2;
            Console.Write("El area del triángulo es: ");
            Console.WriteLine(area);
            Console.ReadKey();
            
        }
    }
}
