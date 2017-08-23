 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//realizar un programa que pida la carga de 2 vectores numericos enteros de cuatro elementos optener la suma de los vectores y dicho resultado guardarlo en un tercer vector del mismo tamaño sumar componente a componente
namespace programavector4
{
    class vector4
    {

        private int[] vector1;
        private int[] vector2;
        int suma=0;


        public void carga() {
            vector1 = new int[4];
            vector2 = new int[4];
             
            Console.WriteLine("vectores 1");
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("ingrese elemento");
                vector1[f] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("vectores 2");
            for (int f = 0; f < 4; f++) 
            {
                Console.WriteLine("ingrese elemento");
              vector2[f]=int.Parse(Console.ReadLine());
            }
        }

        public void operacion() {
           int[] vector3;

            vector3 = new int[4];

            for (int f = 0; f < 4; f++)
            {
              vector3[f] = vector1[f]+vector2[f];
               suma = suma+vector3[f];
            }
         Console.WriteLine("la suma de los vectores es:"+suma);
        }
        static void Main(string[] args)
        {
        vector4 vect4= new vector4();
        vect4.carga();
        vect4.operacion();
        Console.ReadKey();
        }
    }
}
