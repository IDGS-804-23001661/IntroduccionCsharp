using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace IntroduccionCsharp.Models
{
    class practica2
    {
        String nombre;
        private int edad;
        protected String carrera;

        public void IngresaDatos()
        {
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu carrera: ");
            carrera = Console.ReadLine();
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
        }

        static void Main(String[] args)
        {
            practica2 p2 = new practica2();
            p2.IngresaDatos();
            p2.MostrarDatos();
        }

    }
}
