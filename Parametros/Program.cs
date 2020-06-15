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
			p.nombreC = "Elizabeth Rivera";
			p.NumCon = 1600044;
     	}

	    static public void cambia_ref( ref Alumno p) 
          { 
			p = new Alumno();
			p.nombreC = "Elizabeth Rivera";
			p.NumCon = 1600044;
	      }
    }
    class Program
    {
         static void Dupli2(in int no) 
          { 
			 Console.WriteLine(no);
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
            int no = 25;
            Console.WriteLine("Número: {0}", no);

            Console.WriteLine("-------------------------------------------------");

            int num1 = 15;
		    int num2 = 12;
		    int r = SUMAR(num1, num2); 

		    SUMAR(num1, num2, out r);
		    Console.WriteLine("Resultado Suma: {0}", r);
		    Console.WriteLine(SUMAR( num1,num2)); 

            Console.WriteLine("-------------------------------------------------");

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
<<<<<<< HEAD
		    cambia_ref(estu1); //Profe tengo complicaciones para poder imprimir los ref, me confunde la manera en como estos se imprimen
		    //Console.WriteLine(estu1.nombreC);
=======

            Console.WriteLine("-------------------Uso del ref------------------------------");

		    Desconocido.cambia_ref(ref estu1); 
		    Console.WriteLine("Cambio Nombre a : {0}", estu1.nombreC);
            Desconocido.cambia_ref(ref estu1);
            Console.WriteLine("Cambio No.Control: {0}", estu1.NumCon);
>>>>>>> d2bdf37842e77d2e9850da78740c369c31154b51
        }
    }
}
