using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double presupuesto;
            double ginecologia;
            double traumatologia;
            double pediatria;
            Console.Write("Ingrese un presupuesto anual: ");
            presupuesto = double.Parse(Console.ReadLine());
            ginecologia = presupuesto * 0.40;
            traumatologia = presupuesto * 0.30;
            pediatria = presupuesto * 0.30;
            Console.Write("Presupuesto para ginecologia: ");
            Console.WriteLine(ginecologia);
            Console.Write("Presupuesto para traumatologia : ");
            Console.WriteLine(traumatologia);
            Console.Write("Presupuesto para pediatria: ");
            Console.WriteLine(pediatria);
            Console.ReadKey();


        }
    }
}
