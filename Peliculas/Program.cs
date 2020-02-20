using System;

namespace Peliculas
{
    class Pelicula
    {
        public string titulo;
        public int año;
        public string pais;
        public string director;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula peli1= new Pelicula();
            peli1.titulo="Parasites";
            peli1.año=2019;
            peli1.pais="Corea del Sur";
            peli1.director="Boong Joon-ho";

            Console.WriteLine("Título:{0} Año:{1}", peli1.titulo, peli1.año, peli1.pais, peli1.director);

            Pelicula peli2= new Pelicula();
            peli2.titulo="Green Book";
            peli2.año=2018;
            peli2.pais="Canadá";
            peli2.director="Peter Farrelly";

            Console.WriteLine("Título:{0} Año:{1}", peli2.titulo, peli2.año, peli2.pais, peli2.director);
        }
    }
}
