using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Puerta
    {
        public string color;

        public Puerta()
        {
            color = "Cafe";
        }
        public Puerta(string color)
        {
            this.color = color;
        }
        public void SetColor (string color)
        {
            this.color = color;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Soy  una puerta, mi color es " + color);
        }
    }
}
