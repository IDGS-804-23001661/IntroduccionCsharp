using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;

namespace IntroduccionCsharp.Services
{
    public class PeliculasServices
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 120,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 6)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 111,
                Pais = "USA",
                Publicacion = new DateTime(2015, 5, 6)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}