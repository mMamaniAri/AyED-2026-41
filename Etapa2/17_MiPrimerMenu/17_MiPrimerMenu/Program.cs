using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int num1;
            int num2;
            double grados;
            double kelvin;
            int resultado;
            opcion = 0;
            while (opcion != 4)
            {
                opcion = 0;
                Console.WriteLine("Bienvenido al programa");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Elija una opción: ");
                Console.WriteLine(" ");
                Console.WriteLine("1.Saludo");
                Console.WriteLine("2.Producto de dos números");
                Console.WriteLine("3.Grados a Kelvin");
                Console.WriteLine("4.Salir");
                Console.WriteLine("--------------------------------");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Hola");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Ingrese un número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese otro número: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine(resultado);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Ingrese una cantidadd de grados celcius: ");
                        grados = double.Parse(Console.ReadLine());
                        kelvin = grados + 273.15;
                        Console.WriteLine("La cantidad de celcius es igual a "+kelvin+" kelvin");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            }
            
        }
    }
}
