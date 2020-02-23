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
            estrenos.Add(new Pelicula("1.El señor de los anillos"));
            estrenos.Add(new Pelicula("2.Titanic"));
            estrenos.Add(new Pelicula("3.Kung Fu Panda"));
            estrenos.Add(new Pelicula("4.Coco"));
            estrenos.Add(new Pelicula("5.Jurassic Park"));

            //Impresión anteriormente usada
            //estrenos[0].imprime();
            //estrenos[1].imprime();
            //estrenos[2].imprime();
            //estrenos[3].imprime();
            //estrenos[4].imprime();

            //Ciclo foreach
            foreach(Pelicula a in estrenos)
            a.imprime();
        }
    }
}
