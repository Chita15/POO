using System;

namespace PELICULA
{
     class Pelicula
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

                public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string t)
        {
            titulo = t;
        }

        public int GetAño()
        {
            return año;
        }

        public void SetAño(int a)
        {
            año = a;
        }

        public string GetPais()
        {
            return pais;
        }

        public void SetPais(string p)
        {
            pais = p;
        }

        public string GetDirector()
        {
            return director;
        }

        public void SetDirector(string d)
        {
            director = d;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Creación del objeto peli1 y uso de Set y Get para asignar valores. Primer pelicula ganadora del oscar
            Pelicula peli1 = new Pelicula();
            peli1.SetTitulo("Parasites");
            peli1.SetAño(2019);
            peli1.SetPais("Corea del Sur");
            peli1.SetDirector("Boong Joon-ho");

            //Impresión de los datos
            Console.WriteLine("Título:{0} Año:{1} País:{2} Director:{3}", peli1.GetTitulo(), peli1.GetAño(), peli1.GetPais(), peli1.GetDirector());

            //Creación del peli2 con uso de Set y Get. Segunda pelicula ganadora del oscar
            Pelicula peli2 = new Pelicula();
            peli2.SetTitulo("Green Book");
            peli2.SetAño(2018);
            peli2.SetPais("Canadá");
            peli2.SetDirector("Peter Farrelly");

            //Impresión de los datos de la segunda pelicula seleccionada
            Console.WriteLine("Título:{0} Año:{1} País:{2} Director:{3}", peli2.GetTitulo(), peli2.GetAño(), peli2.GetPais(), peli2.GetDirector());
        }
    }
}
