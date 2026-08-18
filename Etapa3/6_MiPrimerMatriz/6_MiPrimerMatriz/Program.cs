using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            Console.Write("Ingrese la cantidad de filas: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
