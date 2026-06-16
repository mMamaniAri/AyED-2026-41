using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numeros= new int [10];
            int suma = 0;
            int contador = 0;

            for (int i = 0;i < 10 ;i++)
            {
                Console.WriteLine("ingrese el numero ;");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("elementos pares de pocisiones impares");

            for(int i = 1; i<10; i+=2)
            {
                 if(numeros[i]%2==0)
                    {

                    Console.WriteLine("pocision:"+ i + " - valor" + numeros[i]);
                    suma += numeros[i];

                    contador++;

                    }
            }

            Console.Write("cantidad encontrados:" + contador + "  ,  ");

            Console.Write("la suma ; " + suma);

            Console.ReadKey();
        }
    }
}
