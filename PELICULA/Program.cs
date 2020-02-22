using System;

namespace PELICULA
{
     class Pelicula
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

    //Constructor Pelicula() con parámetros
    public Pelicula(string titulo, int año, string pais, string director)
    {
        this.titulo = titulo;
        this.año = año; 
        this.pais = pais;
        this.director = director;
    }

    public void imprime()//Este es un metódo
    {
			Console.WriteLine("Titulo:{0} Año:{1} Director:{2} País:{3}", this.titulo, this.año, this.pais, this.director);
    }

       //Constructor Pelicula(). Se generó este constructor que también manda valores a imprimir, sin embargo se comentó
       //y únicamente se empleo el constructor Pelicula(string...)
    
          //public Pelicula()
         //{
            //pais= "Corea del Sur";
           //director = "Boong Go";
         //}

    }

    class Program
    {
        static void Main(string[] args)
        {
             //Objeto 1 = Primer pelicula ganadora del oscar
            Pelicula Pelicula1 = new Pelicula("Parasites", 2019, "Boong Joo-Ho", "Corea del Sur");          

            //Llamada del método imprime()
            Pelicula1.imprime();

            //Objeto2 = Segunda palicula ganadora dle oscar
            Pelicula Pelicula2 = new Pelicula("Green Book", 2018, "Peter Farrelly", "Canadá");

            //Llamada del método imprime()
            Pelicula2.imprime();
        }
    }
}
