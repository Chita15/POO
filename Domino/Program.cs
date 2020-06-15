using System;

namespace EjemDomino
{
    class Program
    {
        //Creación de la clase dominó
        class Domino
        {
            //Asignación de los atributos
            public int espacio1;
            public int espacio2;

            //Creación del constructor Domino para la asignación de valor
            public Domino(int espacio1, int espacio2)
            {
                this.espacio1 = espacio1;
                this.espacio2 = espacio2;
            }
            public override string ToString()
            {
                return String.Format("{0}/{1}", espacio1, espacio2); 
            }

            //Sobrecarga del operador +
            public static int operator +(Domino F1, Domino F2)
            {
                int puntosf1 = F1.espacio1 + F1.espacio2;
                int puntosf2 = F2.espacio1 + F2.espacio2;
                //Suma de los puntos
                int SUMAF = puntosf1 + puntosf2;
                return SUMAF;
            }

        }
        static void Main(string[] args)
        {
            Domino Ficha1 = new Domino(2,5);
            Console.WriteLine("Ficha de dominó #1: {0}", Ficha1);

            Domino Ficha2 = new Domino(5,1);
            Console.WriteLine("Ficha de dominó #2: {0}", Ficha2);
            
            int Resultado = Ficha1 + Ficha2;
            Console.WriteLine("Resultado de la suma de todos los puntos de dos fichas dominó: {0}", Resultado);
        }
    }
}
