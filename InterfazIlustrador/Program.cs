using System;
using System.Collections.Generic;

namespace InterfazIlustrador
{
     interface IFigura 
    {
        int X{get; set;}
        int Y{get; set;}
        string Color{get; set;}

        void dibuja();     

        void PrintColor();
    }

    class Circulo : IFigura
    {
        int _x, _y;
        string color;
        public Circulo(int x, int y, string c)
        {
            this._x = x;
            this._y = y;
            this.color = c;
        }

        public int X {get => _x; set => _x = value;}
        public int Y {get => _y; set => _y =value;}
        public string Color {get => color; set => color = value;}
        
        public void dibuja()
        {
            Console.WriteLine("Se dibuja un circulo {0}", Color);
        }

        public void PrintColor()
        {
            Console.WriteLine("El color es {0}", Color);
        }
        
    }

    class Rectangulo : IFigura
     {
        int _x, _y;
        string color;
        public Rectangulo(int x, int y, string c)
        {
            this._x = x;
            this._y = y;
            this.color = c;
        }
        public int X {get => _x; set => _x = value;}
        public int Y {get => _y; set => _y =value;}
        public string Color {get => color; set => color = value;}
        public void dibuja()
        {
            Console.WriteLine("Se dibuja un rectángulo {0}", Color);
        }

        public void PrintColor()
        {
            Console.WriteLine("El color es {0}", Color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IFigura> figurasG = new List<IFigura>();
            figurasG.Add(new Circulo(12,13,"verde")) ;
            figurasG.Add(new Rectangulo(12,13,"azul")) ;
            figurasG.Add(new Rectangulo(12,13,"verde")) ;
            figurasG.Add(new Circulo(12,13,"turquesa")) ;

            foreach (var item in figurasG)
            {
                item.dibuja();
            }    

            /*Circulo r = new Circulo(10,10,"rojo");   
            r.dibuja();*/
            }
        }
    }
