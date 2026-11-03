using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase
{
    class Program
    {
        public static void Main()
        {
            Refugio r101 = new Refugio(101, 20, 12);
            r101.mostrarInformacion(r101.calcularDisponibles());
            Refugio r102 = new Refugio(102, 15, 10);
            r102.mostrarInformacion(r102.calcularDisponibles());
            Refugio r103 = new Refugio(103, 30, 25);
            r103.mostrarInformacion(r103.calcularDisponibles());

            //resumen
            Console.Write("Personas alojadas: ");
            Console.WriteLine(r101.getAlojados() + r102.getAlojados() + r103.getAlojados());
            Console.Write("Lugares Disponibles: ");
            Console.WriteLine(r101.calcularDisponibles() + r102.calcularDisponibles() + r103.calcularDisponibles());
            Console.Write("Refugio de mayor capacidad: ");
            if (r101.getCapacidad() > r102.getCapacidad() && r101.getCapacidad() > r103.getCapacidad())
            {
                Console.WriteLine(r101.getCodigo());
            }
            else if (r102.getCapacidad() > r101.getCapacidad() && r102.getCapacidad() > r103.getCapacidad())
            {
                Console.WriteLine(r102.getCodigo());
            }
            else
            {
                Console.WriteLine(r103.getCodigo());
            }
            Console.ReadKey();
            
        }
    }
    class Refugio
    {
        //atributos
        private int codigo;
        private int capacidadMaxima;
        private int personasAlojadas;
        //CONSTRUCTOR
        public Refugio(int codigo, int capacidadMaxima, int personasAlojadas)
        {
            this.codigo = codigo;
            this.capacidadMaxima = capacidadMaxima;
            this.personasAlojadas = personasAlojadas;
        }
        //métodos
        public int calcularDisponibles()
        {
            int disponibles = capacidadMaxima - personasAlojadas;
            return disponibles;
        }
        public void mostrarInformacion(int disponibles)
        {
            Console.WriteLine("Refugio: " + codigo + "\nCapacidad: " + capacidadMaxima + "\nAlojados: " + personasAlojadas + "\nDisponibles: " + disponibles + "\n");
        }
        public int getAlojados()
        {
            return personasAlojadas;
        }
        public int getCapacidad()
        {
            return capacidadMaxima;
        }
        public int getCodigo()
        {
            return codigo;
        }
    }
}