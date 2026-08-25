using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] asientos = new string[80, 8];
            int opcion = 0;
            int disponibles = 80;
            int ocupados = 0;
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                    {
                        asientos[i, j] = Convert.ToString(i + 1);
                    }
                    else if (j == 1)
                    {
                        if (Convert.ToInt16(asientos[i, 0]) < 21)
                        {
                            asientos[i, j] = "Primera Clase";
                        }
                        else if (Convert.ToInt16(asientos[i, 0]) > 39 && Convert.ToInt16(asientos[i, 0]) < 44)
                        {
                            asientos[i, j] = "Salida de emergencia";
                        }
                    }
                    else if (j < 7 && j > 1)
                    {
                        asientos[i, j] = "vacio";
                    }
                    else
                    {
                        asientos[i, j] = "false";
                    }
                }
            }
            //bucle while
            while (opcion < 8)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine(" Menú Principal - AvengersAir vuelo Buenos Aires a Wakanda");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("  Asientos Disponibles: " + disponibles);
                Console.WriteLine();
                Console.WriteLine("  Asientos Ocupados: " + ocupados);
                Console.WriteLine();
                Console.WriteLine("1. Vender Asiento");
                Console.WriteLine();
                Console.WriteLine("2. Devolver Asiento");
                Console.WriteLine();
                Console.WriteLine("3. Modificar Asiento");
                Console.WriteLine();
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine();
                Console.WriteLine("5. Buscar Pasajeros por Edad");
                Console.WriteLine();
                Console.WriteLine("6. Obtener Pasajeros con DNI Par");
                Console.WriteLine();
                Console.WriteLine("7. Salir");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();
                Console.Write("Ingrese la opción deseada: ");
                opcion = int.Parse(Console.ReadLine());
                /*----------
                0 - Numero de asiento
                1- tipo de asiento
                2- nombre
                3- apellido
                4- edad
                5- DNI
                6- Nacionalidad
                7- ocupado
                ------------*/
                //opciones
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("N° Asiento tipo nombre apellido edad DNI nacionalidad ocupado");
                        for (int i = 0; i < 80; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Console.Write(asientos[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
            Console.ReadKey();
        }
    }
}
