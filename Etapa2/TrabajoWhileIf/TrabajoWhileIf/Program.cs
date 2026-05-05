using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoWhileIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;
            while (numero != 5)
            {
                numero = 0;
                num1 = 0;
                num2 = 0;
                Console.WriteLine("Seleccione una de estas opciones: ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("|1. Hola Mundo                  |");
                Console.WriteLine("|2. Adios                       |");
                Console.WriteLine("|3. Suma de 2 Números           |");
                Console.WriteLine("|4. Usted seleccionó 4          |");
                Console.WriteLine("|5. SALIR                       |");
                Console.WriteLine("---------------------------------");



                numero = int.Parse(Console.ReadLine());
                if (numero == 1)
                {
                    Console.WriteLine("Hola Mundo");
                }
                else if (numero == 2)
                {
                    Console.WriteLine("Adios");
                }
                else if (numero == 3)
                {
                    Console.WriteLine("Escriba un número: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba otro número: ");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (numero == 4)
                {
                    Console.WriteLine("Usted seleccionó 4");
                }
                else if (numero > 5 || numero < 1)
                {
                    Console.WriteLine(numero + ".Error");
                }


                Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Saliendo del programa");
            Console.ReadKey();
        }
    }
}
