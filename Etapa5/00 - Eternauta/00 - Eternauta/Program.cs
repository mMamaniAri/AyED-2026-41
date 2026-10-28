using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void Main()
        {
            Refugio r101 = new Refugio(200, 4, 10);

            Refugio r102 = new Refugio(100, 3, 12);

            Refugio r103 = new Refugio(180, 4, 12);

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
        public void calcularDisponibles()
        {
            capacidadMaxima -= personasAlojadas;
        }
        public void mostrarInformacion(int cantidad)
        {
            Console.WriteLine("Refugio " + codigo + ": capacidad maxima de " + capacidadMaxima + " personas, " + personasAlojadas + " alojadas.");
        }
    }
}