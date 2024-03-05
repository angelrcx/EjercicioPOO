﻿namespace EjercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.MostrarDatos();
            persona.SetNombre("Carlos");
            Apartamento nuevoApartamento = new Apartamento();
            Puerta nuevaPuerta = new Puerta("Verde");
            nuevoApartamento.SetPuerta(nuevaPuerta);
            persona.SetCasa(nuevoApartamento);
            persona.MostrarDatos();
        }
    }
}
