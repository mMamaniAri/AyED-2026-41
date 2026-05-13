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
            bool siguienteDia;
            int ataqueNoche;
            bool derrota = false;
            bool victoria = false;
            while(opcion != 8 && derrota == false && victoria == false)
            {
                opcion = 0;
                siguienteDia = true;
                Console.WriteLine("------------------------");
                Console.WriteLine("SUPERVIVENCIA EN LA ISLA");
                Console.WriteLine("------------------------");
                Console.WriteLine("Dia: " + dias);
                Console.WriteLine("Vidas: "+vida);
                Console.WriteLine("Hambre: "+hambre);
                Console.WriteLine("Material: " + material);
                Console.WriteLine("Comida cruda: " + comidaCruda);
                Console.WriteLine("Comida cocida: " + comidaCocida);
                Console.WriteLine("refugio: " + refugio);
                Console.WriteLine("fogata: " + fogata);
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
                        if (vida > 0)
                        {
                            vida--;
                        }
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
                            vida = vida - 2;
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
                            siguienteDia = false;
                        }
                        else
                        {
                            Console.WriteLine("Necesitas 10 de material para construir un refugio");
                            siguienteDia = false;
                        }
                           
                        break;
                    case 4:
                        if (material >= 4 && fogata == false)
                        {
                            fogata = true;
                            Console.WriteLine("Lograste encender una fogata");
                            Console.WriteLine("Encender la fogata te costó 4 materiales");
                            material = material - 4;
                        }
                        else if (fogata == true)
                        {
                            Console.WriteLine("La fogata ya está encendida");
                            siguienteDia = false;
                        }
                        else
                        {
                            Console.WriteLine("Necesitas 4 de material para encender la fogata");
                            siguienteDia = false;
                        }
                        break;
                    case 5:
                        if (fogata == true && comidaCruda >= 1)
                        {
                            Console.WriteLine("Cocinas la comida cruda");
                            Console.WriteLine("Se te resta 1 de comida cruda y obtienes 1 de comida cocida");
                            comidaCruda--;
                            comidaCocida++;
                        }
                        else
                        {
                            Console.WriteLine("Necesitas una fogata encendida y al menos 1 pedazo de comida cruda para poder cocinar");
                            siguienteDia = false;
                        }
                        break;
                    case 6:
                        siguienteDia = false;
                        if (comidaCocida >= 1)
                        {
                            Console.WriteLine("Comes comida cocida");
                            Console.WriteLine("Se te resta 1 de comida cocida");
                            Console.WriteLine("Recuperas 4 puntos de hambre");
                            comidaCocida--;
                            if (hambre <= 5)
                            {
                                hambre = hambre + 4;
                            }
                            else if (hambre >= 6 && hambre < 10)
                            {
                                while (hambre < 10)
                                {
                                    hambre++;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tienes comida cocida para comer");
                        }
                        break;
                    case 7:
                        if (refugio == true)
                        {
                            Console.WriteLine("Descansas en el refugio");
                            Console.WriteLine("Recuperas 3 puntos de vida");
                            if (vida <= 6)
                            {
                                vida = vida + 3;
                            }
                            else if (vida >= 7 && vida < 10)
                            {
                                while (vida < 10)
                                {
                                    vida++;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Descansas");
                            Console.WriteLine("Recuperas 1 punto de vida");
                            if (vida < 10)
                            {
                                vida++;
                            }
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Cerrando juego...");
                        break;
                    default:
                        Console.WriteLine("Elija una opción válida");
                        siguienteDia = false;
                        break;
                }
                if (siguienteDia == true)
                {
                    if (refugio == false)
                    {
                        ataqueNoche = rand.Next(1, 10);
                        if (ataqueNoche > 6)
                        {
                            Console.Clear();
                            Console.WriteLine("Como no tenías refugio, unos lobos te atacaron en la noche");
                            Console.WriteLine("Perdiste 1 puntos de vida y 1 comida cocida");
                            vida--;
                            if (comidaCocida > 0)
                            {
                                comidaCocida--;
                            }
                            Console.ReadKey();
                        }
                    dias++;
                    if (hambre == 0)
                    {
                        if (vida > 0)
                        {
                            vida = vida - 2;
                        }
                    }
                    else if (hambre > 0)
                    {
                        hambre = hambre - 2;
                    }
                }
                Console.ReadKey();
                }
                if (vida <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("PERDISTE");
                    derrota = true;
                    Console.ReadKey();
                }
                if (dias >= 10 && vida > 0)
                {
                    Console.Clear();
                    Console.WriteLine("¡Has logrado sobrevvir 10 días!");
                    Console.WriteLine("GANASTE");
                    victoria = true;
                    Console.ReadKey();
                }
                

                Console.Clear();
            }
            ///-
            

        }
    }
}
