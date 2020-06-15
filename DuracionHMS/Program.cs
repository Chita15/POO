using System;

namespace DuracionHMS
{
    class Program
    {
        class Duracion
        {
            private int horas;
            private int minutos;
            private int segundos;

            public Duracion(int horas, int minutos, int segundos)
            {
                this.horas = horas;
                this.minutos = minutos;
                this.segundos = segundos;
            }
            public override string ToString()
            {
                return String.Format("{0:D2} : {1:D2} : {2:D2} ", horas, minutos, segundos);
            }
            
            public Duracion(int segundos)
            {
                
            }

            public static Duracion operator +(Duracion Tiempo1, Duracion Tiempo2)
            {
                int horas1 = Tiempo1.horas + Tiempo2.horas;
                if (horas1 == 24) {horas1 = 0;}
                else if (horas1>24){ horas1= horas1-24;}

                int minutos2 = Tiempo1.minutos + Tiempo2.minutos;
                if (minutos2 == 60)
                {
                    minutos2=0;
                    horas1++;
                }
                else if (minutos2>60)
                {
                    minutos2= minutos2-60;
                    horas1++;
                }
                int segundos3 = Tiempo1.segundos + Tiempo2.segundos;
                if (segundos3 == 60)
                {
                    segundos3 = 0;
                    minutos2++; 
                }
                else if (segundos3>60)
                {
                    segundos3=segundos3-60;
                    minutos2++;
                }

                return new Duracion(horas1, minutos2, segundos3);
            }
        }

        static void Main(string[] args)
        {
            Duracion Tiempo1 = new Duracion(5,65,75);
            Console.WriteLine("Hora #1: {0}", Tiempo1);

            Console.WriteLine("---------------------------------------------------");

            Duracion Tiempo2 = new Duracion(15,25,15);
            Console.WriteLine("Hora #2: {0}", Tiempo2);

            Console.WriteLine("---------------------------------------------------");

            Duracion Tiempo3 = new Duracion(09, 34, 18);
            Console.WriteLine("Hora #3: {0}", Tiempo3);

            Console.WriteLine("---------------------------------------------------");

            Duracion SUMAH = Tiempo1 + Tiempo2;
            Console.WriteLine("Suma de las horas #1 y #2: {0}", SUMAH);

            Console.WriteLine("---------------------------------------------------");

            Duracion Suma = Tiempo1 + Tiempo3;
            Console.WriteLine("Suma de las horas #1 y #3: {0}", Suma);

            Console.WriteLine("---------------------------------------------------");

            Duracion sumas = Tiempo2 + Tiempo3;
            Console.WriteLine("Suma de las horas #2 y #3: {0}", sumas);

        }
    }
}
