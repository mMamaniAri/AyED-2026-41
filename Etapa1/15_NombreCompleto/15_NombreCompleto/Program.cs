using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Tu nombre completo es: ");
            Console.Write(nombre);
            Console.Write(" ");
            Console.Write(apellido);
            Console.ReadKey();


        }
    }
}
