using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            float horasTrabajo;
            float valorHora;
            float sueldoTotal;
            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            horasTrabajo = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de valor por hora: ");
            valorHora = float.Parse(Console.ReadLine());
            sueldoTotal = horasTrabajo * valorHora;
            Console.Write("Tu sueldo total es de: ");
            Console.WriteLine(sueldoTotal);
            Console.ReadKey();
        }
    }
}
