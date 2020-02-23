using System;
using System.Collections.Generic; 

namespace ListaPeliculas
{
    class Pelicula
    {
        public string titulo;

        public void imprime()//Este es un metódo
        {
            Console.WriteLine(titulo);
        }
        public Pelicula(string n)//Este es el constructor
        {
            titulo=n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> alumnos= new List<Pelicula>();

            alumnos.Add(new Pelicula("El señor de los anillos"));
            alumnos.Add(new Pelicula("Titanic"));
            alumnos.Add(new Pelicula("Kung Fu Panda"));
            alumnos.Add(new Pelicula("Coco"));
            alumnos.Add(new Pelicula("Jurassic Park"));

            alumnos[0].imprime();
            alumnos[1].imprime();
            alumnos[2].imprime();
            alumnos[3].imprime();
            alumnos[4].imprime();
        }
    }
}
