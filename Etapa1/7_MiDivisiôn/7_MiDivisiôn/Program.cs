using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiDivisiôn
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            float resultado;
            Console.Write("Ingrese un nûmero entero: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro nûmero entero: ");
            numero2 = float.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.Write("El resultado de la divisiôn es: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
