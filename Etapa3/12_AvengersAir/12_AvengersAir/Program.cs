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
            string[,] asientos = new string[80, 9];
            int opcion = 0;
            int disponibles = 80;
            int ocupados = 0;
            int recaudacion = 0;
            string edad;
            int dni;
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 9; j++)
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
                        else
                        {
                            asientos[i, j] = "Económica";
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
            while (opcion != 7)
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
                recaudacion = 0;
                /*------------
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
                        Console.WriteLine("N° Asiento tipo");
                        for (int i = 0; i < 80; i++)
                        {
                            //if (asientos[i, 8] == "false")
                            //{
                                for (int j = 0; j < 9; j++)
                                {
                                    Console.Write(asientos[i, j] + " ");
                                }
                                Console.WriteLine();
                            //}
                        }
                        Console.Write("Ingrese el asiento que quiere vender: ");
                        opcion = (int.Parse(Console.ReadLine())) - 1;
                        if (asientos[opcion, 8] == "true")
                        {
                            int opcion2;
                            Console.Write("Asiento ya vendido, ingrese el asiento que quiere vender: ");
                            opcion2 = int.Parse(Console.ReadLine());
                            while (opcion2 == int.Parse(asientos[opcion, 0]))
                            {
                                Console.Write("Asiento ya vendido, ingrese el asiento que quiere vender: ");
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            opcion = opcion2 - 1;
                        }
                        Console.Write("Ingrese su nombre: ");
                        asientos[opcion, 2] = Console.ReadLine();
                        Console.Write("Ingrese su apellido: ");
                        asientos[opcion, 3] = Console.ReadLine();
                        Console.Write("Ingrese su edad: ");
                        asientos[opcion, 4] = Console.ReadLine();
                        Console.Write("Ingrese su DNI: ");
                        asientos[opcion, 5] = Console.ReadLine();
                        Console.Write("Ingrese su nacionalidad: ");
                        asientos[opcion, 6] = Console.ReadLine();
                        Console.Write("Ingrese el estado de ocupación del asiento(ocupado = true / libre = false): ");
                        asientos[opcion, 7] = Console.ReadLine();
                        while (asientos[opcion, 7] != "true" || asientos[opcion, 7] != "false")
                        {
                            Console.Write("Respuesta inválida, ingrese el estado de ocupación del asiento(ocupado = true / libre = false): ");
                            asientos[opcion, 7] = Console.ReadLine();
                        }
                        asientos[opcion, 8] = "true";
                        break;
                    case 2:
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 8] == "true")
                            {
                                for (int j = 0; j < 9; j++)
                                {
                                    Console.Write(asientos[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.Write("Ingrese el asiento que quiere devolver: ");
                        opcion = int.Parse(Console.ReadLine());
                        if (asientos[opcion, 7] == "true")
                        {
                            for (int j = 2; j < 7; j++)
                            {
                                asientos[opcion, j] = "vacio";
                            }
                        }
                        else
                        {
                            Console.WriteLine("El asiento está libre, no se realizará ninguna acción adicional.");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 7] == "true")
                            {
                                for (int j = 0; j < 9; j++)
                                {
                                    Console.Write(asientos[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.Write("Ingrese el asiento que desea modficar: ");
                        opcion = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese su nombre: ");
                        asientos[opcion, 2] = Console.ReadLine();
                        Console.Write("Ingrese su apellido: ");
                        asientos[opcion, 3] = Console.ReadLine();
                        Console.Write("Ingrese su edad: ");
                        asientos[opcion, 4] = Console.ReadLine();
                        Console.Write("Ingrese su DNI: ");
                        asientos[opcion, 5] = Console.ReadLine();
                        Console.Write("Ingrese su nacionalidad: ");
                        asientos[opcion, 6] = Console.ReadLine();
                        Console.Write("Ingrese el estado de ocupación del asiento(ocupado = true / libre = false): ");
                        asientos[opcion, 7] = Console.ReadLine();
                        break;
                    case 4:
                        for (int i = 0; i < asientos.GetLength(0); i++)
                        {
                            if (asientos[i, 8] == "true")
                            {
                                if (asientos[i, 1] == "Primera Clase")
                                {
                                    recaudacion = recaudacion + 200;
                                }
                                else if (asientos[i, 1] == "Económica")
                                {
                                    recaudacion = recaudacion + 100;
                                }
                                else
                                {
                                    recaudacion = recaudacion + 80;
                                }
                            }
                        }
                        Console.WriteLine("Recaudación total del vuelo: " + recaudacion);
                        break;
                    case 5:
                        Console.Write("Ingrese la edad que desea buscar: ");
                        edad = Console.ReadLine();
                        Console.WriteLine("N°asiento  Edad");
                        for (int i = 0; i < asientos.GetLength(0); i++)
                        {
                            if (asientos[i, 4] == edad)
                            {
                                Console.Write(asientos[i, 0] + " " + asientos[i, 4]);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("Asientos con DNI par: ");
                        Console.WriteLine("N°asiento");
                        for (int i = 0; i < asientos.GetLength(0); i++)
                        {
                            if (asientos[i, 5] != "vacio")
                            {
                                dni = int.Parse(asientos[i, 5]);
                                if (dni % 2 == 0)
                                {
                                    Console.Write(asientos[i, 0] + " ");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
