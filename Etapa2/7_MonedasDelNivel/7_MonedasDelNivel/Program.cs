using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int monedaPlata;
            int monedaOro;
            int cantPlata;
            int cantOro;
            int puntos;
            monedaPlata = 2;
            monedaOro = 10;
            Console.Write("Ingrese la cantidad de monedas de plata que consiguió: ");
            cantPlata = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de monedas de oro que consiguió: ");
            cantOro = int.Parse(Console.ReadLine());
            puntos = cantOro * monedaOro + cantPlata * monedaPlata;
            if (puntos < 50)
            {
                Console.WriteLine("Nivel insuficienrte");
            }
            else if (puntos >= 50 && puntos < 100)
            {
                Console.WriteLine("Nivel superado");
            }
            else
            {
                Console.WriteLine("Nivel completado");
            }
            Console.ReadKey();



        }
    }
}
