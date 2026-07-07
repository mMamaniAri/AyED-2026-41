using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MatrizAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n;
            int m;
            Console.Write("Ingrese la cantidad de filas: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
