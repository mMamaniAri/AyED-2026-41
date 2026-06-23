using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int[] vidasPokemones = new int[6];
            int enLista = 0;
            int siguiente = 0;
            while (opcion < 13)
            {
                opcion = 0;
                Console.WriteLine("------------------------------------");
                Console.WriteLine("C E N T R O  P O K É - R E M E D I O");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Elija una opcióbn: ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1- Registrar un nuevo pokemón");
                Console.WriteLine("2- Mostrar la vida de todos los pokemones");
                Console.WriteLine("3- Curar un pokemón");
                Console.WriteLine("4- Dañar un pokemon");
                Console.WriteLine("5- Curar a todos los pokemones");
                Console.WriteLine("6- Mostrar pokemones debilitados");
                Console.WriteLine("7- Mostrar el pokemon con mayor vida");
                Console.WriteLine("8- Mostrar el pokemon con menor vida");
                Console.WriteLine("9- Calcular promedio de vida del equipo");
                Console.WriteLine("10- Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("11- Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("12- Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            if (enLista < 6)
                            {
                                Console.Write("Ingrese la vida del pokemon: ");
                                vidasPokemones[siguiente] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Pokemon registrado correctamente en la posición " + siguiente);
                                siguiente++;
                            }
                            else
                            {
                                Console.WriteLine("No se pueden registrar más pokemones, el centro está lleno");
                            }
                            break;
                        }
                    case 2:
                        {
                            for (int i = 0; i < vidasPokemones.Length; i++)
                            {
                                Console.WriteLine("Pokemon " + (i + 1) + " - Vida: " + vidasPokemones[i]);
                            }
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
