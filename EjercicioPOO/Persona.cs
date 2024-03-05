using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Persona
    {
        public string nombre;
        public Casa casa;
        public Apartamento apartamento;

        public Persona()
        {
            nombre = "Juan";
            casa = new Casa(150);
            apartamento = new Apartamento();
        }
        public Persona(string nombre, Casa casa)
        {
            this.nombre = nombre;
            this.casa = casa;
        }

        public void SetNombre (string nombre)
        {
            this.nombre = nombre;
        }

        public void SetCasa (Casa casa)
        {
            this.casa = casa;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Mi nombre es " + nombre);
            casa.MostrarDatos();
        }
    }
}
