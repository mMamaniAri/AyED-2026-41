using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            Console.Write("Ingrese la cantidad de estudiantes: ");
            filas = int.Parse(Console.ReadLine());
            string[,] estudiantes = new string[filas, 3];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int x = 0; x < filas; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            Console.Write(estudiantes[x, y] + " ");
                        }
                        Console.WriteLine();
                    }
                    if (j == 0)
                    {
                        Console.Write("Ingrese el nombre del estudiante: ");
                    }
                    else if (j == 1)
                    {
                        Console.Write("Ingrese la edad del estudiante: ");
                    }
                    else
                    {
                        Console.Write("Ingrese la calificación del estudiante: ");
                    }
                    estudiantes[i, j] = Console.ReadLine();
                    Console.Clear();
                }
            }
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(estudiantes[x, y] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}