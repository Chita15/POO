using System;

namespace Pilas
{
    public class Stack<T>
{

   readonly int m_Size; 

   int m_StackPointer = 0;

   public T[] m_Items;

   public Stack():this(10)
   { }

   public Stack(int size)
   {
      m_Size = size;
      m_Items = new T[m_Size];
   }

   public void Push(T item)
   {
      if(m_StackPointer >= m_Size) 
      {
         Console.WriteLine("¡Error! StackOverflow");
      }
      else 
      {                       
        m_Items[m_StackPointer] = item;
        m_StackPointer++;
      }
   }

   public T Pop()
   {
      m_StackPointer--;

      if(m_StackPointer >= 0)
      {
         return m_Items[m_StackPointer];
      }

      else
      {
         m_StackPointer = 0;
         throw new InvalidOperationException("¡Error! Pop inválido, Stack vacío");
      }
   }
}
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("-----------------------Push----------------------------");

            //Stack<string> pila1 = new Stack<string>(); ---> Para aplicar valores de tipo string 
            Stack<int> pila = new Stack<int>();
            pila.Push(25);
            pila.Push(12);
            pila.Push(10);
            pila.Push(2);
            pila.Push(1);
            pila.Push(3);
            pila.Push(15);
            pila.Push(13);
            pila.Push(4);
            pila.Push(11);
            pila.Push(19);
            pila.Push(21);
            pila.Push(56);
            pila.Push(5);  //Al dejar más de 10 push, nos lanzaría un error por excedernos de stacks

            //foreach(string item in pila.m_Items) ----> Para cuando son valores de tipo string 
            //Console.WriteLine(item);

            foreach(int item in pila.m_Items)
            Console.WriteLine(item);

            Console.WriteLine("-----------------------Pop----------------------------");
            Console.WriteLine(pila.Pop());     
            Console.WriteLine(pila.Pop()); 
            Console.WriteLine(pila.Pop());    
            Console.WriteLine(pila.Pop());     
            Console.WriteLine(pila.Pop()); 
            Console.WriteLine(pila.Pop());   
            Console.WriteLine(pila.Pop());     
            Console.WriteLine(pila.Pop()); 
            Console.WriteLine(pila.Pop());    
            Console.WriteLine(pila.Pop());   
            //La impresión que se hace a continuación es por que el pop muestra los valores iniciales
            Console.WriteLine("****Pop de los valores por orden de ingreso sin arreglo****");  
            foreach(int item in pila.m_Items)
            Console.WriteLine("->{0}", item);

            //Se pueden emplear datos de tipo string, pero en este caso se dejo con puros datos de tipo int

            //Para aplicar el FIFO o cola, se convierte al stack en un arreglo   
            Console.WriteLine("--------------------Volviendo el stack un arreglo--------------------------");

            int [] StackArreglo = {25, 12, 10, 2, 1, 3, 15, 13, 4, 11};

            Console.WriteLine("Impresión sacando el primer valor ingresado usando el arreglo");
            for(int count=0; count<StackArreglo.Length; count ++)
            Console.WriteLine(StackArreglo[count]);

            /*Console.WriteLine("Impresión al hacer push");
            for(int count=0; count<StackArreglo.Length; count ++)
            Console.WriteLine(StackArreglo[count]);
            
            Console.WriteLine("Impresión al momento de hacer pop");
            Array.Reverse(StackArreglo);
            for(int count=0; count<StackArreglo.Length; count ++)
            Console.WriteLine(StackArreglo[count]);*/
        }
    }
}
