using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__El_EterNota
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int filaActual = 0;
            int mayor = 0;
            int[,] refugios = new int [20, 5];
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        agregarRefugio(refugios, filaActual);
                        filaActual++;
                        break;
                    case 2:
                        mostrarRefugios(refugios, filaActual);
                        break;
                    case 3:
                        ocuparRefugio(refugios, filaActual, opcion);
                        break;
                    case 4:
                        refugiosOcupados(refugios, filaActual);
                        break;
                    case 5:
                        masSuministros(refugios, filaActual, mayor);
                        break;
                    case 6:
                        // Lógica para promedio por zona
                        break;
                    case 7:
                        // Lógica para filtrar por zona
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
        static void agregarRefugio(int [,] refugios, int filaActual)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("Ingrese el código de refugio numérico y único: ");
                    refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    while (refugios[filaActual, j] < 0)
                    {
                        Console.WriteLine("Inválido, ingrese el código de refugio numérico y único: ");
                        refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    }
                }
                else if (j == 1)
                {
                    Console.WriteLine("Ingrese la capacidad máxima que el refugio puede albergar: ");
                    refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    while (refugios[filaActual, j] < 0)
                    {
                        Console.WriteLine("Inválido, ingrese la capacidad máxima que el refugio puede albergar: ");
                        refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    }
                }
                else if (j == 2)
                {
                    Console.WriteLine("Ingrrese un número que represente la cantidad de suministros disponibles: ");
                    refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    while (refugios[filaActual, j] < 0)
                    {
                        Console.WriteLine("Inválido, ingrese un número que represente la cantidad de suministros disponibles: ");
                        refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    }
                }
                else if (j == 3)
                {
                    Console.WriteLine("Ingrese el número de zona");
                    Console.WriteLine("1 = 'NORTE'(Congreso) \n2 = 'SUR'(Constitucion) \n3 = 'OESTE'(Flores) \n4 = 'CENTRAL'(Microcentro)");
                    refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    while (refugios[filaActual, j] < 1 || refugios[filaActual, j] > 4)
                    {
                        Console.WriteLine("Zona invàlida, esa parte ya està perdida");
                        Console.WriteLine("Ingrese el número de zona");
                        Console.WriteLine("1 = 'NORTE'(Congreso) \n2 = 'SUR'(Constitucion) \n3 = 'OESTE'(Flores) \n4 = 'CENTRAL'(Microcentro)");
                        refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese 1 si hay personas en el refugio o 0 si no las hay: ");
                    refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    while (refugios[filaActual, j] < 0 || refugios[filaActual, j] > 1)
                    {
                        Console.WriteLine("Inválido, ingrese 1 si hay personas en el refugio o 0 si no las hay: ");
                        refugios[filaActual, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        static void mostrarRefugios(int [,] refugios, int filaActual)
        {
            for (int i = 0; i < filaActual; i++)
            {
                Console.Write("Refugio " + (i + 1) + " : ");
                for (int j = 0; j < refugios.GetLength(1); j++)
                {
                    Console.Write(refugios[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void ocuparRefugio(int [,] refugios, int filaActual, int opcion)
        {
            Console.WriteLine("Refugios diponibles: ");
            for (int i = 0; i < filaActual; i++)
            {
                if (refugios[i, 4] != 1)
                {
                    Console.Write("Refugio " + (i + 1) + " : ");
                    for (int j = 0; j < refugios.GetLength(1); j++)
                    {
                        Console.Write(refugios[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.Write("Seleccione el refugio que quiere ocupar: ");
            opcion = (int.Parse(Console.ReadLine())) - 1;
            while (refugios[opcion, 4] != 0 || opcion > filaActual)
            {
                if (refugios[opcion, 4] != 0)
                {
                    Console.Write("No somos Okupas, esto ya està ocupado, seleccioine el refugio que quiere ocupar: ");
                    opcion = (int.Parse(Console.ReadLine())) - 1;
                }
                if (opcion > filaActual - 1)
                {
                    Console.Write("Refugio no registrado, seleccione el refugio que quiere ocupar: ");
                    opcion = (int.Parse(Console.ReadLine())) - 1;
                }
            }
            refugios[opcion, 4] = 1;
        }
        static void refugiosOcupados(int [,] refugios, int filaActual)
        {
            Console.WriteLine("Refugios ocupados: ");
            for (int i = 0; i < filaActual; i++)
            {
                if (refugios[i, 4] != 0)
                {
                    Console.Write("Refugio " + (i + 1) + " : ");
                    for (int j = 0; j < refugios.GetLength(1); j++)
                    {
                        Console.Write(refugios[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void masSuministros(int[,] refugios, int filaActual, int mayor)
        {
            int contador = 0;
            Console.WriteLine("Refugio con más suministros: ");
            for (int i = 0; i < filaActual; i++)
            {
                if (refugios[i, 2] > mayor)
                {
                    mayor = refugios[i, 2];
                }
            }
            for (int i = 0; i < filaActual; i++)
            {
                if (refugios[i, 2] == mayor)
                {
                    contador++;
                    Console.Write("Refugio " + (i + 1) + " : ");
                    for (int j = 0; j < refugios.GetLength(1); j++)
                    {
                        Console.Write(refugios[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (contador > 1)
            {
                Console.WriteLine("Hay más de un refugio con la mayor cantidad de suministros");
            }
        }
        static void promedioZona(int [,] refugios, int filaActual)
        {
            int totalNorte = 0;
            int totalSur = 0;
            int totalOeste = 0;
            int totalCentro = 0;
            int promedioNorte = 0;
            int promedioSur = 0;
            int promedioOeste = 0;
            int promedioCentro = 0;
            for (int i = 0; i < filaActual; i++)
            {
                if (refugios[i, 3] == 1)
                {
                    totalNorte = totalNorte + refugios[i, 3];
                }
                else if (refugios[i, 3] == 2)
                {
                    totalSur = totalSur + refugios[i, 3];
                }
                else if (refugios[i, 3] == 3)
                {
                    totalOeste = totalOeste + refugios[i, 3];
                }
                else if (refugios[i, 3] == 4)
                {
                    totalCentro = totalCentro + refugios[i, 3];
                }
            }
        }
    }
}