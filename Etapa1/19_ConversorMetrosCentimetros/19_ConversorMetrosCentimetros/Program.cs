using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            float metros;
            float centimetros;
            float milimetros;
            Console.Write("Ingrese una medidda en metros: ");
            metros = float.Parse(Console.ReadLine());
            centimetros = metros * 100;
            milimetros = metros * 1000;
            Console.Write("Su cantidad en centimetros: ");
            Console.WriteLine(centimetros);
            Console.Write("Su cantidad en milimetros: ");
            Console.Write(milimetros);
            Console.ReadKey();
            
        }
    }
}
