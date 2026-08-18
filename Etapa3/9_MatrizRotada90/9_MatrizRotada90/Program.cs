using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamañoCuadrado;
            int contador = 1;
            Console.Write("Ingrese un tamaño para la matriz: ");
            tamañoCuadrado = int.Parse(Console.ReadLine());
            int[,] matriz = new int[tamañoCuadrado, tamañoCuadrado];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = contador;
                    contador++;
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] matriz90 = new int[tamañoCuadrado, tamañoCuadrado];
            int cont2;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                cont2 = (matriz.GetLength(0) - 1);
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    matriz90[j, cont2] = matriz[i, j];
                    cont2--;
                }
            }
            Console.WriteLine("Matriz rotada: ");
            for (int i = 0; i < matriz90.GetLength(0); i++)
            {
                for (int j = 0; j < matriz90.GetLength(1); j++)
                {
                    Console.Write(matriz90[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
