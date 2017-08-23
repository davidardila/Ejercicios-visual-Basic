using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cargar un vector de n elementos de tipo entero, ordenar posteriormente el vector
namespace programavectores10
{
    class vector10
    {


        private int[] vector;


        int n;
        public void carga()
        {



            Console.WriteLine("vector");

            Console.WriteLine("ingrese n elementos hasta n");
            n = int.Parse(Console.ReadLine());



        }
        public void operacion()
        {
            vector = new int[n];
            for (int f = 0; f < n; f++)
            {
                Console.WriteLine("ingrese un numero");
                vector[f] = int.Parse(Console.ReadLine());

            }
            for (int k = 0; k < vector.Length; k++)
            {
                for (int f = 0; f < vector[f]-1 - k; f++)
                {
                    if (vector[f]>(vector[f + 1]))
                    {
                        int aux;
                        aux = vector[f];
                        vector[f] = vector[f + 1];
                        vector[f + 1] = aux;

                    }

                }

            }
        }
    
           
        

        public void imprimir()
        {
            Console.WriteLine("elementos ordenados:");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.WriteLine(vector[f]);

            }
          
        }

        static void Main(string[] args)
        {
            vector10 vect = new vector10();
            vect.carga();
            vect.operacion();
            vect.imprimir();
            Console.ReadKey();

        }
    }
}
