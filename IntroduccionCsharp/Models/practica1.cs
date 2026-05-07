using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionCsharp.Models
{
    internal class practica1
    {
        static void Main(String[] args) {

            // int, string, bool, double, char
            int cali1 = 0;
            int cali2, cali3, resultado;
            String dato1, dato2;
            Console.WriteLine("Ingresa primera calificacion: ");
            dato1 = Console.ReadLine();
            cali1 = Convert.ToInt32(dato1);
            Console.WriteLine("Ingresa la segunda calificacion: ");
            dato2 = Console.ReadLine();
            cali2 = Convert.ToInt32(dato2);
            int suma = cali1 + cali2;

            Console.WriteLine("La suma de las calificaciones es: " + suma);
            if (cali1 > cali2)
            {
                Console.WriteLine("La nota mayor es: " + cali1);
            }
            else
            {
                Console.WriteLine("La nota menor es: " + cali2);
            }

            // While
            int x;
            x = 1;
            while (x <= 100)
            {
                Console.Write(x);
                Console.Write(" - ");
                x++;
            }
            // do while
            int y = 1;
            do
            {
                Console.Write(y);
                Console.Write(" - ");
                y++;
            } while (y <= 100);
            // for
            int f;
            for (f = 1; f == 100; f++)
            {
                Console.Write(f);
                Console.Write(" - ");
            }

        }
    }
}
