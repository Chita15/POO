using System;

namespace PELICULA
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
            //Creación del objeto peli1. Datos de la primer pelicula ganadora a oscar a asignar
            Pelicula peli1= new Pelicula();
            peli1.titulo="Parasites";
            peli1.año=2019;
            //peli1.pais="Corea del Sur";---> Se comentan ya que el ejercicio solicita solo el Titulo y año
            //peli1.director="Boong Joon-ho";--->Misma razón, ya mencionada antes

            Console.WriteLine("Título:{0} Año:{1} País:{2} Director:{3}", peli1.titulo, peli1.año, peli1.pais, peli1.director);

             //Creación del objeto peli2. Datos de la segunda pelicula ganadora a oscar a asignar
            Pelicula peli2= new Pelicula();
            peli2.titulo="Green Book";
            peli2.año=2018;
            //peli2.pais="Canadá"; ---> Se comentan ya que el ejercicio solicita solo el Titulo y año
            //peli2.director="Peter Farrelly"; --->Misma razón, ya mencionada antes

            Console.WriteLine("Título:{0} Año:{1} País:{2} Director:{3}", peli2.titulo, peli2.año, peli2.pais, peli2.director);
        }
    }
}
