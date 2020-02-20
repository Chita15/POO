using System;

namespace Peliculas
{
    class Pelicula
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

        public string getTitulo()
        {
            return titulo;
        }

        public void setTitulo(string t)
        {
            titulo = t;
        }

        public int getAño()
        {
            return año;
        }

        public void setAño(int a)
        {
            año = a;
        }

        public string getPais()
        {
            return pais;
        }

        public void setPais(string p)
        {
            pais = p;
        }

        public string getDirector()
        {
            return director;
        }

        public void setDirector(string d)
        {
            director = d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula peli1= new Pelicula();
            peli1.setTitulo("Parasites");
            peli1.setAño(2019);
            peli1.setPais("Corea del Sur");
            peli1.setDirector("Boong Joon-ho");

            Console.WriteLine("Título:{0} Año:{1} País:{2} Director:{3}", peli1.getTitulo(), peli1.getAño(), peli1.getPais(), peli1.getDirector());

            Pelicula peli2= new Pelicula();
            peli2.setTitulo("Green Book");
            peli2.setAño(2018);
            peli2.setPais("Canadá");
            peli2.setDirector("Peter Farrelly");

            Console.WriteLine("Título:{0} Año:{1} País:{2} Director:{3}", peli2.getTitulo(), peli2.getAño(), peli2.getPais(), peli2.getDirector());
        }
    }
}
