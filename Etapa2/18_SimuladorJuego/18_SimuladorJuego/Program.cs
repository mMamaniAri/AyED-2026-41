using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int opcion = 0;
            int vida = 10;
            int hambre = 10;
            int dias = 1;
            int comidaCruda = 0;
            int comidaCocida = 0;
            bool refugio = false;
            bool fogata = false;
            int material = 0;
            int busquedaComida;
            int exploracion;
            while(opcion != 8)
            {
                opcion = 0;
                Console.WriteLine("------------------------");
                Console.WriteLine("SUPERVIVENCIA EN LA ISLA");
                Console.WriteLine("------------------------");
                Console.WriteLine("Dia: " + dias);
                Console.WriteLine("Vidas: "+vida);
                Console.WriteLine("Hambre: "+hambre);
                Console.WriteLine("Material: " + material);
                Console.WriteLine("------------------------");
                Console.WriteLine("Elija que hacer este dia:");
                Console.WriteLine(" ");
                Console.WriteLine("1.Buscar comida");
                Console.WriteLine("2.Explorar la isla");
                Console.WriteLine("3.Construir refugio");
                Console.WriteLine("4.Encender fogata");
                Console.WriteLine("5.Cocinar comida");
                Console.WriteLine("6.Comer comida cocida");
                Console.WriteLine("7.Descansar");
                Console.WriteLine("8.Salir");
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        busquedaComida = rand.Next(1, 10);
                        Console.WriteLine("Vas a buscar comida y...");
                        Console.ReadKey();
                        if (busquedaComida > 6)
                        {
                            Console.WriteLine("Encuentras 2 pedazos de carne cruda");
                            Console.WriteLine("Ir a buscar comida te consume energía, pierdes 1 punto vida");
                            comidaCruda = comidaCruda + 2;
                        }
                        else
                        {
                            Console.WriteLine("No pudiste encontrar nada");
                            Console.WriteLine("Ir a buscar comida te consume energía, pierdes 1 punto vida");
                        }
                        vida--;
                        break;
                    case 2:
                        exploracion = rand.Next(1, 10);
                        Console.WriteLine("Exploras la isla y...");
                        Console.ReadKey();
                        if (exploracion > 5)
                        {
                            Console.WriteLine("Encontraste materiales para constrtuir");
                            Console.WriteLine("+5 de material");
                            material = material + 5;
                        }
                        else if (exploracion > 2 && exploracion <5)
                        {
                            Console.WriteLine("No encontraste nada útil");
                        }
                        else
                        {
                            Console.WriteLine("Sufriste un accidente durante la exploración");
                            Console.WriteLine("Pierdes 2 puntos de vida");
                        }
                        break;
                    case 3:
                        if (refugio == false && material >= 10)
                        {
                            Console.WriteLine("Lograste construir un refugio");
                            refugio = true;
                        }
                        else if (refugio == true)
                        {
                            Console.WriteLine("No es necesario construir un refugio");
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente material para construir un refugio");
                        }
                           
                        break;
                }
                dias++;
                if (hambre == 0)
                {
                    vida--;
                }
                else if (hambre > 0)
                {
                    hambre = hambre - 2;
                }
                Console.ReadKey();
                Console.Clear();
            }
 
            //Console.WriteLine(num);
            

        }
    }
}
