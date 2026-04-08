using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiMultiplicaciôn
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.Write("Ingrese un nûmero entero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro nûmero entero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.Write("El resultado de la multiplicaciôn es: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
