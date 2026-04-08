using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            int horas;
            int restoMinutos;
            Console.Write("Ingrese una cantidad en minutos: ");
            minutos = int.Parse(Console.ReadLine());
            horas = minutos / 60;
            restoMinutos = minutos % 60;
            Console.Write("Equivale a ");
            Console.Write(horas);
            Console.Write(" horas y ");
            Console.Write(restoMinutos);
            Console.WriteLine(" minutos");
            Console.ReadKey();
        }
    }
}
