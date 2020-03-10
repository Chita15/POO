using System;

namespace Parametros
{
     class Alumno
    {
        public string nombreC;
        public int NumCon;

        public Alumno()
        {
            nombreC = "López Rivera Vanesa Elizabeth";
            NumCon = 19211671;
        }
    }
    class Desconocido
    {
        static public void Inseguro(Alumno p) 
        { 
			p.nombreC = "SiNiNfO";
			p.NumCon = 000000000000;
        }

        static public void cambia(Alumno p) 
        { 
			p = new Alumno();
			p.nombreC = "Elizabeth";
			p.NumCon = 1600044;
     	}

	    static public void cambia_ref( ref Alumno p) 
          { 
			p = new Alumno();
			p.nombreC = "Elizabeth";
			p.NumCon = 1600044;
	      }
    }
    class Program
    {
         static void Dupli2( int n) 
          { 
			 n = n*2;
	      }
        static void SUMAR(int num1, int num2, out int RES)
        {
		   RES = num1 + num2;
	    }

	     static int SUMAR(int a, int b)
            {
		     return a + b;
            }
        static void Main(string[] args)
        {
            int num1 = 15;
		    int num2 = 12;
		    int r = SUMAR(num1, num2); 

		    SUMAR(num1, num2, out r);
		    Console.WriteLine("Resultado: {0}", r);
		    Console.WriteLine(SUMAR( num1,num2)); 
            Console.WriteLine("-------------------------------------------------");
            //Program d = new Program();
		    //int x = 2;  
            //Dupli2(ref n);

            Alumno estu1 = new Alumno();
            Console.WriteLine("Nombre del alumno: {0} Num_Control: {1}", estu1.nombreC, estu1.NumCon);
            Desconocido.Inseguro(estu1);
            //Desconocido.cambia(ref estu1);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Nombre del alumno: {0} Num_Control: {1}", estu1.nombreC, estu1.NumCon);


            //Console.WriteLine(estu1.nombreC);
	      	//Desconocido.Inseguro(estu1);
		    //Console.WriteLine(estu1.nombreC);
		    //Desconocido.cambia(estu1);
		    //Console.WriteLine(estu1.nombreC);
		    Desconocido.cambia_ref(ref estu1); //Profe tengo complicaciones para poder imprimir los ref, me confunde la manera en como estos se imprimen
		    //Console.WriteLine(estu1.nombreC);
        }
    }
}
