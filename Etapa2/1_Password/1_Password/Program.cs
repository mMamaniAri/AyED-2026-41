using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            password = "contraseña";
            string passwordU;
            Console.Write("Ingrese la contraseña: ");
            passwordU = Console.ReadLine();
            if (password.ToLower() == passwordU.ToLower())
            {
                Console.WriteLine("La contraseña coincide con la guardada");
            }
            else
            {
                Console.WriteLine("La contraseña no coincide con la guardada");
            }
            Console.ReadKey();
            


        }
    }
}
