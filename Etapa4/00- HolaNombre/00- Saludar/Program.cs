using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00__Saludar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(holaNombre("Nombre"));
            Console.ReadKey();
        }
        static string holaNombre(string nombre)
        {
            return "Hola " + nombre;
        }
    }
}