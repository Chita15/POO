using System;

namespace Parametros
{
    class Hora
    {
        	public void tiempo(int t) 
            { 
			    t = t*60;
            }

            public void tiempo_ref(ref int t)
            {
                t = t*30;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Hora reloj = new Hora();

             reloj.tiempo(1);

             int num = 2;

             reloj.tiempo(num);

             Console.WriteLine("Segundos transcurridos: {0}", num);
        }
    }
}
