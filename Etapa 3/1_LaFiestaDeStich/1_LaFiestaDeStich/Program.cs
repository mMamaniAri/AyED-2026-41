using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStich
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadInvitados;
            int promedioComida = 0;
            int totalComida = 0;
            Console.Write("Ingrese la cantidad de invitados: ");
            cantidadInvitados = int.Parse(Console.ReadLine());
            while (cantidadInvitados < 1 || cantidadInvitados > 100)
            {
                Console.WriteLine("Inválido, Ingrese una cantidad entre 1 y 100");
                cantidadInvitados = int.Parse(Console.ReadLine());
            }
            int[] cantidadComida = new int[cantidadInvitados];
            for (int i = 0;i<cantidadInvitados;i++)
            {
                Console.Write("Ingrese la cantidad de comida para una persona: ");
                cantidadComida[i] = int.Parse(Console.ReadLine());
                while(cantidadComida[i] < 1 || cantidadComida[i] > 100)
                {
                    Console.Write("Inválido, Ingrese una cantidad entre 1 y 100: ");
                    cantidadComida[i] = int.Parse(Console.ReadLine());
                }
            }
            for (int n = 0;n < cantidadInvitados;n++)
            {
                totalComida = totalComida + cantidadComida[n];
            }
            promedioComida = totalComida / cantidadInvitados;
            Console.Write("El promedio de comida para cada invitado es de: ");
            Console.WriteLine(promedioComida);
            Console.ReadKey();
        }
    }
}
