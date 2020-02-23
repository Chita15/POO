using System;
using System.Collections.Generic; 

namespace ListaPeliculas
{
    class Pelicula
    {
        public string titulo;

        public void imprime()//Este es el metódo imprime
        {
            Console.WriteLine(titulo);
        }
        public Pelicula(string n)//Este es el constructor Pelicula()
        {
            titulo=n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> estrenos= new List<Pelicula>();

            //Lista de peliculas
            estrenos.Add(new Pelicula("El señor de los anillos"));
            estrenos.Add(new Pelicula("Titanic"));
            estrenos.Add(new Pelicula("Kung Fu Panda"));
            estrenos.Add(new Pelicula("Coco"));
            estrenos.Add(new Pelicula("Jurassic Park"));

            //Ciclo foreach
            foreach(Pelicula a in estrenos)
            a.imprime();
        }
    }
}
