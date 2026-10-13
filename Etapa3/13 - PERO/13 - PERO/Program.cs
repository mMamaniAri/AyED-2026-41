using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___PERO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] misiones = new int[30, 5];
            int filaActual = 0;
            int opcion;
            int mayor = 0;
            int prom1 = 0;
            int prom2 = 0;
            int prom3 = 0;
            int cant1 = 0;
            int cant2 = 0;
            int cant3 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de pegrilo por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        misiones[filaActual, 0] = filaActual + 1;
                        //-
                        Console.WriteLine("Ingrese el mapa de la misión: \n- 1 = Hagwarts \n- 2 = La Casa del Viejo \n- 3 = El Laboratorio");
                        misiones[filaActual, 1] = int.Parse(Console.ReadLine());
                        while (misiones[filaActual, 1] < 1 || misiones[filaActual, 1] > 3)
                        {
                            Console.WriteLine("Inválido, ingrese el mapa de la misión: \n- 1 = Hagwarts \n- 2 = La Casa del Viejo \n- 3 = El Laboratorio");
                            misiones[filaActual, 1] = int.Parse(Console.ReadLine());
                        }
                        //-
                        misiones[filaActual, 2] = rand.Next(1, 70);
                        //-
                        Console.Write("Ingrese el nivel de peligro(número entre 1(bajo) y 5(muerte segura)): ");
                        misiones[filaActual, 3] = int.Parse(Console.ReadLine());
                        while (misiones[filaActual, 3] < 1 || misiones[filaActual, 3] > 5)
                        {
                            Console.Write("Inválido, ingrese el nivel de peligro(número entre 1(bajo) y 5(muerte segura)): ");
                            misiones[filaActual, 3] = int.Parse(Console.ReadLine());
                        }
                        //-
                        misiones[filaActual, 4] = 0;
                        //-
                        filaActual++;
                        // Punto 1: Registrar nueva misión
                        break;
                    case 2:
                        for (int i = 0; i < filaActual; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(misiones[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        // Punto 2: Ver todas las misiones
                        break;
                    case 3:
                        Console.Write("Ingrese la fila a la cual le quiere cambiar el estado de misión: ");
                        opcion = int.Parse(Console.ReadLine());
                        if (misiones[opcion - 1, 4] < 2)
                        {
                            misiones[opcion - 1, 4]++;
                        }
                        else
                        {
                            Console.WriteLine("Esta misión ya está finalizada.");
                        }
                        // Punto 3: Cambiar estado de misión
                        break;
                    case 4:
                        for (int i = 0; i < filaActual; i++)
                        {
                            if (misiones[i, 4] == 1)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    Console.Write(misiones[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        // Punto 4: Listar misiones en curso
                        break;
                    case 5:
                        //mayor = 0;
                        for(int i = 0; i < filaActual; i++)
                        {
                            if (misiones[i, 2] > mayor)
                            {
                                mayor = misiones[i, 2];
                            }
                        }
                        Console.WriteLine(mayor);
                        for (int i = 0; i < filaActual; i++)
                        {
                            if (misiones[i, 2] == mayor)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    Console.Write(misiones[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        // Punto 5: Misión con más objetos a extraer
                        break;
                    case 6:
                        for (int i = 0; i < filaActual; i++)
                        {
                            if (misiones[i, 1] == 1)
                            {
                                prom1 = prom1 + misiones[i, 1];
                            }
                            cant1++;
                        }
                        for (int i = 0; i < filaActual; i++)
                        {
                            if (misiones[i, 1] == 2)
                            {
                                prom2 = prom2 + misiones[i, 1];
                            }
                            cant2++;
                        }
                        for (int i = 0; i < filaActual; i++)
                        {
                            if (misiones[i, 1] == 3)
                            {
                                prom3 = prom3 + misiones[i, 1];
                            }
                            cant3++;
                        }
                        // Punto 6: Promedio de peligro por mapa
                        break;
                    case 7:
                        // Punto 7: Filtrar por mapa
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
    }
}