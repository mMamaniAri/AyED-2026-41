using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool comida;
            bool refugio;
            bool bate;
            bool agua;
            bool botiquin;
            Console.WriteLine("Ingresar True si posee los siguientes elementos o False si no los posee: ");
            Console.Write("Comida: ");
            comida = bool.Parse(Console.ReadLine());
            Console.Write("Refugio: ");
            refugio = bool.Parse(Console.ReadLine());
            Console.Write("Bate: ");
            bate = bool.Parse(Console.ReadLine());
            Console.Write("Agua: ");
            agua = bool.Parse(Console.ReadLine());
            Console.Write("Botiquín: ");
            botiquin = bool.Parse(Console.ReadLine());
            if (comida == true && agua == true && botiquin == true)
            {
                Console.WriteLine("Usted podrá sobrevivir");
            }
            else
            {
                Console.WriteLine("Usted no podrá sobrevivir");
            }
            Console.ReadKey();



        }
    }
}
