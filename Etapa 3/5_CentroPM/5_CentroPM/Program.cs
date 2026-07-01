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
            Random rand = new Random();
            int opcion = 0;
            int[] vidasPokemones = new int[6];
            int enLista = 0;
            int siguiente = 0;
            int elegido;
            int curacion;
            int restar;
            int dañado;
            int daño;
            int cantDebilitados;
            bool debilitados;
            int mayor = 0;
            int menor = 0; 
            int indiceMayor;
            int indiceMenor;
            int totalVidas;
            int promedioVidas;
            int ataqueRandom;
            while (opcion < 13)
            {
                opcion = 0;
                elegido = 0;
                curacion = 0;
                restar = 0;
                dañado = 0;
                daño = 0;
                indiceMayor = 0;
                indiceMenor = enLista;
                debilitados = false;
                cantDebilitados = 0;
                totalVidas = 0;
                promedioVidas = 0;
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
                Console.WriteLine(enLista);
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                            if (enLista < 6)
                            {
                                Console.Write("Ingrese la vida del pokemon: ");
                                vidasPokemones[siguiente] = int.Parse(Console.ReadLine());
                                while (vidasPokemones[siguiente] < 0 || vidasPokemones[siguiente] > 100)
                                {
                                    Console.Write("Ingrese la vida del pokemon (entre 0 y 100): ");
                                    vidasPokemones[siguiente] = int.Parse(Console.ReadLine());                                       
                                }
                                Console.WriteLine("Pokemon registrado correctamente en la posición " + siguiente);
                                siguiente++;
                                enLista++;
                            }
                            else
                            {
                                Console.WriteLine("No se pueden registrar más pokemones, el centro está lleno");
                            }
                            Console.ReadKey();
                            break;
                    case 2:
                            for (int i = 0; i < enLista; i++)
                            {
                                Console.WriteLine("Pokemon " + (i + 1) + " - Vida: " + vidasPokemones[i]);
                            }
                            Console.ReadKey();
                            break;
                    case 3:
                            Console.Write("Ingrese la posición del pokemon a curar (entre 1 y 6): ");
                            elegido = int.Parse(Console.ReadLine()) - 1;
                            Console.Write("Ingrese puntos de vida a recuperar: ");
                            curacion = int.Parse(Console.ReadLine());
                            vidasPokemones[elegido] = vidasPokemones[elegido] + curacion;
                            if (vidasPokemones[elegido] > 100)
                            {
                                restar = vidasPokemones[elegido] - 100;
                                vidasPokemones[elegido] = vidasPokemones[elegido] - restar;
                            }
                            Console.WriteLine("El pokemón fue curado");
                            Console.WriteLine("Vida actual: " + vidasPokemones[elegido]);
                            Console.ReadKey();
                            break;
                    case 4:
                            Console.Write("Ingrese la posición del pokemon atacado: ");
                            dañado = int.Parse(Console.ReadLine()) - 1;
                            Console.Write("Ingrese daño recibido: ");
                            daño = int.Parse(Console.ReadLine());
                            vidasPokemones[dañado] = vidasPokemones[dañado] - daño;
                            if (vidasPokemones[dañado] < 0 )
                            {
                                vidasPokemones[dañado] = 0;
                            }
                            Console.WriteLine("El pokemon recibió daño");
                            Console.WriteLine("Vida actual: " + vidasPokemones[dañado]);
                            Console.ReadKey();
                            break;
                    case 5:
                            curacion = 0;
                            Console.Write("Ingrese puntos de curación general: ");
                            curacion = int.Parse(Console.ReadLine());
                            for (int n = 0; n < enLista; n++)
                            {
                                vidasPokemones[n] = vidasPokemones[n] + curacion;
                                if (vidasPokemones[n] > 100)
                                {
                                    vidasPokemones[n] = 100;
                                }
                            }
                            Console.WriteLine("Todos los pokemones fueron curados");
                            Console.ReadKey();
                            break;
                    case 6:
                            for(int x = 0; x < enLista; x++)
                            {
                                if (vidasPokemones[x] == 0)
                                {
                                    debilitados = true;
                                }
                            }
                            if (debilitados == true)
                            {
                                Console.WriteLine("Pokemones debilitados:");
                                for (int p = 0; p < enLista; p++)
                                {
                                    if (vidasPokemones[p] == 0)
                                    {
                                        Console.WriteLine("Pokemon en posición " + p);
                                        cantDebilitados = cantDebilitados + 1;
                                    }
                                }
                            Console.WriteLine("Cantidad total de pokemones debilitados: " + cantDebilitados);
                            }
                            else
                            {
                                Console.WriteLine("No hay pokemones debilitados");
                            }
                            Console.ReadKey();
                            break;
                    case 7:
                            for (int z = 0; z < enLista-1; z++)
                            {
                                if (vidasPokemones[z] > mayor)
                                {
                                    mayor = vidasPokemones[z];
                                    indiceMayor++;
                                }
                            }
                            Console.WriteLine("El pokemon con la mayor vida está en la posición " + (indiceMayor - 1));
                            Console.WriteLine(mayor);
                            Console.ReadKey();
                            break;
                    case 8:
                            menor = 101;
                            for (int z = (enLista - 1); z > -1; z--)
                            {
                                if (vidasPokemones[z] < menor)
                                {
                                    menor = vidasPokemones[z];
                                    indiceMenor--;
                                }
                            }
                            Console.WriteLine("El pokemon con la menor vida está en la posición " + indiceMenor);
                            Console.WriteLine(menor);
                            Console.ReadKey();
                            break;
                    case 9:
                            for (int m = 0;m < enLista;m++)
                            {
                                totalVidas = totalVidas + vidasPokemones[m];
                                promedioVidas = totalVidas / enLista;
                            }
                            if (promedioVidas <= 30)
                            {
                                Console.WriteLine("El equipo está en peligro");
                            }
                            else if (promedioVidas > 30 && promedioVidas < 70)
                            {
                                Console.WriteLine("El equipo necesita curación");
                            }
                            else
                            {
                                Console.WriteLine("El equipo está en buen estado");
                            }
                            Console.ReadKey();
                            break;
                    case 10:
                            Array.Sort(vidasPokemones,0,enLista);
                            break;
                    case 11:
                            Array.Sort(vidasPokemones);
                            Array.Reverse(vidasPokemones);
                            break;
                    case 12:
                            ataqueRandom = rand.Next(5, 25);
                            for (int v = 0; v < enLista; v++)
                            {
                                vidasPokemones[v] = vidasPokemones[v] - ataqueRandom;
                                if (vidasPokemones[v] < 0)
                                {
                                    vidasPokemones[v] = 0;
                                }
                            }
                            Console.WriteLine("¡Un pokemon salvaje atacó al equipo!");
                            Console.WriteLine("Daño recibido por todos: " + ataqueRandom);
                            Console.WriteLine("Las vidas fueron actualizadas");
                            Console.ReadKey();
                            break; 
                    case 13:
                            Console.WriteLine("Gracias por utilizar el sistema del Centro Poké-Renedio");
                            Console.ReadKey();
                            break;
                }
                Console.Clear();
            }

        }
    }
}
