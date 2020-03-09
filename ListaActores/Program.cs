using System;
using System.Collections.Generic;
namespace ListaActores
{
  //Creación de la clase Actor con sus atributos
    class Actor
    {
        public string nombre;
        public int año;
        //Creación del constructor Actor con parámetros
        public Actor(string n, int a)
        {
            nombre = n;
            año = a;
        }
    }
    //Creación de la clase Pelicula con sus atributos
    class Pelicula
    {
        public string titulo;
        public int año;
        //Creación del atributo actores de tipo List
        public List<Actor> actores = new List<Actor>();
         public void AgregarActor(Actor actor)
        {
            actores.Add(actor);
        }
        //Creación del metódo ImprimeActores() con ciclo foreach para los actores. En el metódo se incluye la impresión del
        //titulo de la película, ya que sin el no se imprime
        public void ImprimeActores()
        {
            foreach (Actor Actor in actores)
            {
                Console.WriteLine("Nombre del actor: {0} ({1})", Actor.nombre, Actor.año, titulo);
            }
        }
        //Creación del constructor Pelicula con parámetros, uso del this y empleo de la impresión para el titulo
        public Pelicula(string titulo, int año)
        {
            this.titulo = titulo;
            this.año = año;
            Console.WriteLine(titulo);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de los objetos p1 y p2 con sus valores asignados
            Pelicula p1 = new Pelicula("La La Land", 2016);
            p1.AgregarActor(new Actor("Ryan Gosling", 1980));
            p1.AgregarActor(new Actor("Emma Stone", 1988));

            p1.ImprimeActores();

            //Anexo de otra pelicula
            Pelicula p2 = new Pelicula("Titanic", 1998);
            p2.AgregarActor(new Actor("Leonardo DiCaprio", 1974));
            p2.AgregarActor(new Actor("Kate Winslet", 1975));

            p2.ImprimeActores();
        }
    }
}
