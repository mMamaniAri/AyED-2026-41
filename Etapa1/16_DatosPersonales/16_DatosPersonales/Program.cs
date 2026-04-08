using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string edad;
            string ciudad;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = Console.ReadLine();
            Console.Write("Ingrese la ciudad en donde vive: ");
            ciudad = Console.ReadLine();
            Console.Write("Su nombre es ");
            Console.Write(nombre);
            Console.Write(" tiene ");
            Console.Write(edad);
            Console.Write(" años y vive en ");
            Console.WriteLine(ciudad);
            Console.ReadKey()
        }
    }
}
