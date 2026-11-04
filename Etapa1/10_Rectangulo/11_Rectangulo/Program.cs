using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double perimetro;
            double area;
            double diagonal;
            Console.Write("Ingrese un valor para x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Ingrese un valor para y: ");
            y = double.Parse(Console.ReadLine());
            diagonal = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            perimetro = (x + y) * 2;
            area = x * y;
            Console.Write("La diagonal del rectangulo es: ");
            Console.WriteLine(diagonal);
            Console.Write("El perimetro del rectangulo es: ");
            Console.WriteLine(perimetro);
            Console.Write("El ârea del rectangulo es: ");
            Console.WriteLine(area);
            Console.ReadKey();



        }
    }
}
