using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            while (op != 5)
            {
                Console.WriteLine("Iniciar partida 1");
                Console.WriteLine("Ver stats 2");
                Console.WriteLine("Elegir personaje 3");
                Console.WriteLine("Comprar mejora 4");
                Console.WriteLine("Salir 5");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Partida iniciada");
                        break;
                    case 2:
                        Console.WriteLine("Nivel 10");
                        break;
                    case 3:
                        Console.WriteLine("Personaje elegido");
                        break;
                    case 4:
                        Console.WriteLine("Mejora comprada");
                        break;
                    case 5:
                        Console.WriteLine("Salir");
                        break;
                }
            }
            Console.ReadKey();
        }        
    }
}
