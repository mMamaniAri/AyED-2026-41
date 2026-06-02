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
            int promedioComida;
            Console.Write("Ingrese la cantidad de invitados: ");
            cantidadInvitados = int.Parse(Console.ReadLine());
            while (cantidadInvitados < 1 || cantidadInvitados > 100)
            {
                Console.WriteLine("Inválido, Ingrese una cantidad entre 1 y 100");
                cantidadInvitados = int.Parse(Console.ReadLine());
            }
            int[] cantidadComida = new int[cantidadInvitados];

            Console.ReadKey();
        }
    }
}
