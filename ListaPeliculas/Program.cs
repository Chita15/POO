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
            List<Pelicula> estrenos= new List<Pelicula>();

            estrenos.Add(new Pelicula("El señor de los anillos"));
            estrenos.Add(new Pelicula("Titanic"));
            estrenos.Add(new Pelicula("Kung Fu Panda"));
            estrenos.Add(new Pelicula("Coco"));
            estrenos.Add(new Pelicula("Jurassic Park"));

            estrenos[0].imprime();
            estrenos[1].imprime();
            estrenos[2].imprime();
            estrenos[3].imprime();
            estrenos[4].imprime();
        }
    }
}
