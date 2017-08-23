using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//generar un programa que permita ingresar unvvector de 8 elemntos, e informe
//el valor acumulado de todos los elementos del vector
// el valor acumulado de los elementos del vector que sean mayores a 36
//cantidad de valores mayores a 50
namespace programavectores3
{
    class programavectores4
    {
        private float[] elementos;

        public void cargar()
        {
            elementos = new float[8];


            Console.WriteLine("ingrese numero elementos");
            for (int f = 0; f < 8; f++)
            {
                Console.WriteLine("ingrese elemento");
                elementos[f] = float.Parse(Console.ReadLine());
            }
            

        }
        public void calcularelementos()
        {

            float suma = 0;


            for (int f = 0; f < 8; f++)
            {
                suma = suma + elementos[f];


            }
            Console.WriteLine("valor acumulado" + suma);

        }
        public void mayor36(){
            float suma = 0;
            for (int f = 0; f < 8; f++){
                if (elementos[f] > 36)
                {
                    suma = suma + elementos[f];
                }
            }
            Console.WriteLine(+suma);
        }
          
            }




        





        static void Main(string[] args)
        {
            programavectores4 vector = new programavectores4();
            vector.cargar();
            vector.calcularelementos();
            Console.ReadKey();
        }
    }

}