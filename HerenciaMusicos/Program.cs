using System;
using System.Collections.Generic;

namespace HerenciaMusicos
{
    class Musico
    {
        protected string nombre;
        protected string afina;
        protected string toca;
        public Musico(string nombre, string afina, string toca)
        {
            this.nombre = nombre;
            this.afina = afina;
            this.toca = toca;
        }
        public virtual void Afina()
        {
            Console.WriteLine("Mi instrumento {0}", afina);
        }

        public virtual void saludar()
        {
            Console.WriteLine("Hola! mi nombre es {0} y soy músico(a).", nombre);
        }
        public virtual void Toca()
        {
            Console.WriteLine("Me gusta tocar {0}", toca);
        }
    }
            class Baterista:Musico
        {
            protected string marcabateria;
            public Baterista(string nombre, string marcabateria, string afina, string toca): base (nombre, afina, toca)
            {
                this.marcabateria = marcabateria;
            }
            public override void Afina()
            {
                Console.WriteLine("Mi bateria {0}", afina);
            }
            public override void saludar()
            {
                Console.WriteLine("Saludos! Me llamo {0} y soy baterista. La marca de mi batería es {1}.", nombre, marcabateria);
            }
            public override void Toca()
            {
                Console.WriteLine("Voy a tocar la canción {0}", toca);
            }
        }

        class Bajista:Musico
        {
            protected string marcabajo;
            public Bajista(string nombre, string marcabajo, string afina, string toca): base (nombre, afina, toca)
            {
                this.marcabajo = marcabajo;
            }
            public override void Afina()
            {
                Console.WriteLine("Mi bajo está {0}", afina);
            }
            public override void saludar()
            {
                Console.WriteLine("Mi nombre es {0} y soy bajista, la marca de mi bajo es {1}.", nombre, marcabajo);
            }
            public override void Toca()
            {
                Console.WriteLine("Ahora tengo ganas de tocar la canción {0}", toca);
            }
        }
        class Guitarrista:Musico
        {
            protected string marcaguitarra;
            public Guitarrista(string nombre, string marcaguitarra, string afina, string toca): base (nombre, afina, toca)
            {
                this.marcaguitarra = marcaguitarra;
            }
            public override void Afina()
            {
                Console.WriteLine("Mi guitarra está {0}", afina);
            }
            public override void saludar()
            {
                Console.WriteLine("Hola! me llamo {0}, y soy guitarrista. La marca de mi guitarra es {1}.", nombre, marcaguitarra);
            }
            public override void Toca()
            {
                Console.WriteLine("Voy a practicar con la canción {0}", toca);
            }

        }
    class Program
    {
        static void Main(string[] args)
        {
            Musico Frank = new Musico("Frank", "está afinado y listo para poder tocar.", "diferentes genéros de música.");
            Musico Noemi = new Musico("Noemi", "está afinado y listo para poder tocar.", "diferentes genéros de música.");
            Musico Vanessa = new Musico("Vanessa", "está afinado y listo para poder tocar.", "diferentes genéros de música.");

            //Objetos de tipo baterista
            Baterista Holy = new Baterista("Holy", "Gretsch", "aún no la he afinado.", "We Will Rock You de Queen!");
            Baterista Jamie = new Baterista("Jamie", "Pearl", "la estoy afinando.", "The Way You Make Me Feel de Michael Jackson!");
            Baterista Norman = new Baterista("Norman", "Yamaha", "ya la he terminado de afinar.", "Carol Of The Bells!");

            //Objetos de tipo bajista
            Bajista Ricardo = new Bajista("Ricardo", "Fender", "sin afinar.", "Seven Nation Army de The White Stripes!");
            Bajista Rodrigo = new Bajista("Rodrigo", "Yamaha", "completamente afinado.", "Can’t Stop de Red Hot Chili Peppers!");
            Bajista Elizabeth = new Bajista("Elizabeth", "Caliber", "en proceso de afinación.", "Feel Good Inc. de Gorillaz!");

            //Objetos de tipo guitarrista
            Guitarrista Emma = new Guitarrista("Emma", "Yamaha", "sin ser afinada aún.", "Killer Queen de Queen!");
            Guitarrista Elios = new Guitarrista("Elios", "Gibson", "totalmente afinada.", "Beat It de Michael Jackson!");
            Guitarrista Johan = new Guitarrista("Johan", "Fender", "lista y afinada para tocar.", "Sweet Child O' Mine de Guns N' Roses!");

            List<Musico> musicos = new List<Musico>();

            //Musicos nombres
            musicos.Add(Frank);
            musicos.Add(Noemi);
            musicos.Add(Vanessa);
            //Bateristas nombres
            musicos.Add(Holy);
            musicos.Add(Jamie);
            musicos.Add(Norman);
            //Bajistas nombres
            musicos.Add(Ricardo);
            musicos.Add(Rodrigo);
            musicos.Add(Elizabeth);
            //Guitarristas nombres
            musicos.Add(Emma);
            musicos.Add(Elios);
            musicos.Add(Johan);

            foreach(Musico m in musicos)
            {
                m.saludar();
                m.Afina();
                m.Toca();
            }
        }
    }
}