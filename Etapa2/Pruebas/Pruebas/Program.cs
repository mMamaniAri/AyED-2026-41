using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = { 18, 21, 19, 23, 16 };
            int buscado;
            bool encontrado = false;
            Console.WriteLine("Ingrese una edad para buscar");
            buscado = int.Parse(Console.ReadLine());
            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] == buscado)
                {
                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("La edad no se encuentra en la lista");
            }
            else
            {
                Console.WriteLine("La edad se encuentra en la lista");
            }



            //Array.Reverse(numeros);
            /*foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }*/
            Console.ReadKey();

        }
    }
}
