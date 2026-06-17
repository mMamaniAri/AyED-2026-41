using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int participantes;
            Console.Write("Ingrese la cantidad de participantes: ");
            participantes = int.Parse(Console.ReadLine());
            int[] puntajes = new int[participantes];
            for (int i = 0; i < participantes; i++)
            {
                Console.Write("Ingrese el puntaje de un participante: ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(puntajes);
            Array.Reverse(puntajes);
            for (int n = 0; n < participantes; n++)
            {
                Console.Write("Puesto " + (n + 1) + ": " + puntajes[n] + " puntos" + "; ");
            }
            Console.ReadKey();
        }
    }
}
