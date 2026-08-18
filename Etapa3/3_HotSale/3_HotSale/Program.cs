using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int vendidos;
            int bajo;
            int alto;
            int max;
            Console.Write("Ingrese la cantidad de productos vendidos: ");
            vendidos = int.Parse(Console.ReadLine());
            int[] precios = new int[vendidos];
            for (int i = 0; i < vendidos; i++)
            {
                Console.Write("Ingrese el precio de un producto: ");
                precios[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(precios);
            max = vendidos - 1;
            bajo = precios[0];
            alto = precios[max];
            Console.WriteLine("Precio más bajo: " + bajo);
            Console.WriteLine("Precio más alto: " + alto);
            Console.ReadKey();
        }
    }
}
