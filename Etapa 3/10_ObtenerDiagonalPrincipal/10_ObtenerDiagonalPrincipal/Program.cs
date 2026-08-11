using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int tamaño;
            tamaño = int.Parse(Console.ReadLine());
            int [,] matriz = new int[tamaño, tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    matriz[i, j] = rand.Next(0, 100);
                }
            }
            Console.WriteLine("Matriz: ");
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] diagonal = new int[tamaño];
            int cont = 0;
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    if (i == j)
                    {
                        diagonal[cont] = matriz[i, j];
                        cont++;
                    }
                }
            }
            Console.Write("Diagonal: ");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write(diagonal[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
