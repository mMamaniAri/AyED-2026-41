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
            Mate mateFran = new Mate(200, 4, 10, "Madera", true, true);

            Mate mateMetal = new Mate(100, 3, 12, "Metal", false, false);

            Mate mateRojo = new Mate(180, 4, 12, "Vidrio", false, false);

            Mate mateBlanco = new Mate(170, 3, 10, "Porcelana", false, false);

        }
    }
    class Mate
    {
        //atributos
        private int capacidad;
        private int radio;
        private int alto;
        private string material;
        private bool estaLaqueado;
        private bool tieneBombilla;
        private int cantAgua = 0;
        //CONSTRUCTOR
        public Mate(int capacidad, int radio, int alto, string material, bool estaLaqueado, bool tieneBombilla)
        {
            this.capacidad = capacidad;
            this.radio = radio;
            this.alto = alto;
            this.material = material;
            this.estaLaqueado = estaLaqueado;
            this.tieneBombilla = tieneBombilla;
        }
        //métodos
        public void cebar()
        {
            cantAgua = capacidad;
        }
        public void tomar(int cantidad)
        {
            cantAgua -= cantidad;
            if (cantAgua < 0)
            {
                cantAgua = 0;
            }
        }
    }
}
