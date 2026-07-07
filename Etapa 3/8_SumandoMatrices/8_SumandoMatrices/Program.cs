using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n;
            Console.Write("Ingrese el tamaño de la matriz: ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz= new int[n, n];
            int[,] matriz2= new int[n, n];
            int[,] matriz3 = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                    matriz2[i, j] = rand.Next(1, 100);
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matriz3[i, j] = matriz[i, j] + matriz2[i, j];
                    Console.Write(matriz3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
