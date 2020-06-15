using System;
using System.Collections.Generic;

namespace AMusicos
{
    abstract class Musico
    {
        protected string nombre;
        public Musico(string nombre)
        {
            this.nombre = nombre;
        }
        public abstract void Afina();
        public abstract void Presentar();
        public abstract void Toca();
    }

    class Baterista : Musico
    {
        protected string MaBateria;
        public Baterista (string nombre, string MaBateria): base (nombre)
        {
            this.MaBateria = MaBateria;
        }
        public override void Afina()
        {
            Console.WriteLine("Mi bateria ya está afinada");
        }

        public override void Presentar()
        {
            Console.WriteLine("Saludos! Me llamo {0} y soy baterista. La marca de mi batería es {1}.", nombre, MaBateria);
        }
        
        public override void Toca()
        {
            Console.WriteLine("Estoy listo(a) para tocar!");
        }
    }
    class Bajista : Musico
    {
        protected string MaBajo;
        public Bajista(string nombre, string MaBajo): base(nombre)
        {
            this.MaBajo = MaBajo;
        }
        public override void Afina()
        {
            Console.WriteLine("Mi bajo está casi afinado, solo le falta un poco más.");
        }
        public override void Presentar()
        {
            Console.WriteLine("Mi nombre es {0} y soy bajista, la marca de mi bajo es {1}.", nombre, MaBajo);
        }
        public override void Toca()
        {
            Console.WriteLine("Cuando deje de sonar la batería es mi turno de tocar.");
        }

    }
    class Guitarrista : Musico
    {
        protected string MaGuitarra;
        public Guitarrista(string nombre, string MaGuitarra): base(nombre)
        {
            this.MaGuitarra = MaGuitarra;
        }
        public override void Afina()
        {
            Console.WriteLine("Ya he afinado mi guitarra para poder tocar al máximo!");
        }
        public override void Presentar()
        {
            Console.WriteLine("Hola! me llamo {0}, y soy guitarrista. La marca de mi guitarra es {1}.", nombre, MaGuitarra);
        }
        public override void Toca()
        {
            Console.WriteLine("Ha llegado la hora de rockanrolleearr!!!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Musico> musicos = new List<Musico>();

            musicos.Add(new Baterista("Holy", "Gretsch"));
            musicos.Add(new Baterista("Jamie", "Pearl"));
            musicos.Add(new Baterista("Norman", "Yamaha"));

            musicos.Add(new Bajista("Ricardo", "Fender"));
            musicos.Add(new Bajista("Rodrigo", "Yamaha"));
            musicos.Add(new Bajista("Elizabeth", "Caliber"));

            musicos.Add(new Guitarrista("Emma", "Yamaha"));
            musicos.Add(new Guitarrista("Elios", "Gibson"));
            musicos.Add(new Guitarrista("Johan", "Fender"));

            foreach(var i in musicos)
            {
                i.Presentar();
                i.Afina();
                i.Toca();
            }
        }
    }
}
