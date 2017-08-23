using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{//definir un vector de 5 componentes de tipo float que represente las alturas de 5 personas obtwner el promedio de las mismas y contar cuantas pewrsonas son mas altas que el rpomedio y cuantas mas bajas utilizar metodos para el ejercicio y clases
    class Pruebavector
    {

        private float[] alturas;
        private float promedio;


        public void cargar() {
            alturas = new float[5];
            for (int f = 0; f < 5; f++) {
                Console.WriteLine("ingrese la altura de la persona");
                alturas[f] = float.Parse(Console.ReadLine());
            }
        }

        public void calcularpromedio() {
            float suma;
            suma=0;
            for (int f = 0; f < 5; f++) {
                suma = suma + alturas[f];
            }
            promedio = suma / 5;
            Console.WriteLine("promedio de alturas"+promedio);
        }

        public void mayoresmenores()
        {
            int mayor, menor;
            mayor = 0;
            menor = 0;


            for (int f = 0; f < 5; f++)  {
                if (alturas[f] > promedio)
                {
                    mayor = mayor + 1;
                }
                else {
                    if (alturas[f] < promedio) {
                        menor = menor + 1;
                    }
                }
            }
            Console.WriteLine("cantidad de personas mayores al promedio"+mayor);
            Console.WriteLine("cantidad de personas menores al promedio"+menor);
            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            Pruebavector vector = new Pruebavector();
            vector.cargar();
            vector.calcularpromedio();
            vector.mayoresmenores();
        }
    }
}
