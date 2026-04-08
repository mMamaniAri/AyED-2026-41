using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            double cilindros;
            double pistasCilindro;
            double sectoresPista;
            double kilobytes;
            double megabytes;
            double gigabytes;
            Console.Write("Ingrese la cantidad de cilindros: ");
            cilindros = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de pistas por cilindro: ");
            pistasCilindro = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de sectores por pista de un disco duro: ");
            sectoresPista = double.Parse(Console.ReadLine());
            kilobytes = (512 * sectoresPista * pistasCilindro * cilindros) / 1000;
            megabytes = (512 * sectoresPista * pistasCilindro * cilindros) / 1000000;
            gigabytes = (512 * sectoresPista * pistasCilindro * cilindros) / 1000000000;
            Console.Write("Cantidad en kilobytes: ");
            Console.WriteLine(kilobytes);
            Console.Write("Cantidad en megabytes: ");
            Console.WriteLine(megabytes);
            Console.Write("Cantidad en gigabytes: ");
            Console.WriteLine(gigabytes);
            Console.ReadKey();

        }
    }
}
