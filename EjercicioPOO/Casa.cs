using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Casa
    {
        public int area;
        public Puerta puerta;

        public Casa(int area)
        {
            this.area = area;
            puerta = new Puerta();
        }

        public void SetArea(int area)
        {
            this.area = area;
        }
        public void SetPuerta(Puerta puerta)
        {
            this.puerta = puerta;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Soy  una Casa, mi area es " + area + "m2");
        }
    }
}
