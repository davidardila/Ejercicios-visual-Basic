 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//desarrollar un programa que permita ingresar un vector n elementos ingresar n por teclado luego imprimir la suma de todos sus elementos
namespace programavector5
{
    class vector5
    {


        private int[] vector;
        int suma=0;
        int n;

        public void carga()
        {
           
        

            Console.WriteLine("vector");
       
                Console.WriteLine("ingrese n elementos hasta 10");
            n= int.Parse(Console.ReadLine());
            

        
        }
        public void Suma() {
            vector = new int[n];
            for (int f = 0; f < n; f++)
            {
                Console.WriteLine("ingrese un numero");
                vector[f] = int.Parse(Console.ReadLine());
             suma=suma +vector[f];
            }

            Console.WriteLine("la suma es:"+suma);
        }

        static void Main(string[] args)
        {
            vector5 vect = new vector5();
            vect.carga();
            vect.Suma();
            Console.ReadKey();
        }
    }
}
