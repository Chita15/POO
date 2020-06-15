using System;
using System.Collections.Generic;

namespace IlustradorFiguras
{
    //Uso de "abstract" para crear una clase abstracta
    abstract class Figura 
    {
        protected int x;
        protected int y;
        protected string color;

        public Figura(int x, int y, string c)
        {
            this.x = x; this.y = y; color = c;
        }
        //Como se creo una clase abstracta se implementa un metódo abstracto el cual no lleva cuerpo y se define una vez se llama
        //en otras clases
        public abstract void dibuja();

        public void printColor() 
        {
            Console.WriteLine(color);
        }
    }

    class Circulo : Figura 
    {
        public Circulo(int x, int y, string c):base(x , y, c)
        {
        }
        //Al hacer herencia de la clase Figura, se hereda el metódo dibuja el cual es abstracto pero, 
        //se define una vez se usa dentro de la clase Circulo 
        public override void dibuja()
        {
            Console.WriteLine("Se dibuja un circulo {0}", color);
        }
    }

    class Rect : Figura 
    {
        public Rect(int x, int y, string c):base(x , y, c)
        {
        }
        //Igual que en la clase Circulo se hereda en la clase Rect lo de la clase Figura, por lo que también se implementa el metódo 
        //dibuja() y se define dentro de la misma.
            public override void dibuja()
            {
                Console.WriteLine("Se dibuja un rectángulo {0}", color);
            }
    }
    class Program{
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(12,13,"verde")) ;
            figuras.Add(new Rect(12,13,"azul")) ;
            figuras.Add(new Rect(12,13,"rojo")) ;
            figuras.Add(new Circulo(12,13,"rojo")) ;

            foreach (var item in figuras)
            {
                item.dibuja();
            }    
            
            Circulo r = new Circulo(10,10,"rojo");   
            r.dibuja();
            }
        }
}
