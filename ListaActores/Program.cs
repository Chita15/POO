using System;
using System.Collections.Generic;
namespace ListaActores
{
    class Pelicula
    {
        public string titulo;
        public string actor;
        public int año;

        public void imprimeActor()
        {
            Console.WriteLine("Pelicula:{0} Año:{1}", this.titulo, this.año);
            Console.WriteLine("Actores: {0}", this.actor);
        }

        public Pelicula(string t, int o)
        {
            titulo = t;
            año = o;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           

            Pelicula estreno = new Pelicula ("Titanic", 1998);

             //estreno.Add(new Actores("Leonardo DiCaprio"));
             //estreno.Add(new Actores("Rose"));

             estreno.imprimeActor();
        }
    }
}
