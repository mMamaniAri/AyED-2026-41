using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int examenes;
            int trabajos;
            int promedioExamen = 0;
            int totalExamen = 0;
            Console.Write("Ingrese la cantidad de examenes que tiene en la materia: ");
            examenes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de TPs que tiene en la materia: ");
            trabajos = int.Parse(Console.ReadLine());
            int[] notasExamen = new int[examenes];
            for (int i = 0; i < examenes; i++)
            {
                Console.Write("Ingrese una nota entre 1 y 10 de un examen: ");
                notasExamen[i] = int.Parse(Console.ReadLine());
            }
            int[] notasTP = new int[trabajos];
            for (int n = 0; n < trabajos; n++)
            {
                Console.Write("Ingrese una nota entre 1 y 10 de un TP: ");
                notasTP[n] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < examenes; x++)
            {
                totalExamen = totalExamen + notasExamen[x];
            }
            promedioExamen = totalExamen / examenes;
            int tpFiltrado = 0;
            for (int y = 0; y < trabajos; y++)
            {
                if (notasTP[y] >= 6)
                {
                    tpFiltrado++;
                }
            }
            if (promedioExamen >= 6 && tpFiltrado >= trabajos * 0.75)
            {
                Console.Write("Pueden aprobar la materia");
            }
            else
            {
                Console.WriteLine("No pueden aprobar la materia");
            }
            Console.WriteLine(trabajos*0.75);
            Console.ReadKey();
        }
    }
}
