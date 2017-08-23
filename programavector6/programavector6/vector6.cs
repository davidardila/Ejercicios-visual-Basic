using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//se tiene las notas del primer parcial de los alumnos de dos cursos, el curso a y el curso b cada curso cuenta con 5 alumnos realizar un programa qie muestre el curso que obtuvo el mayor promedio general
namespace programavector6
{
    class vector6
    {
        int[] cursoa;
        int[] cursob;
        int[] sumar;
        int promedioa;
        int promediob;
        public void carga()
        {
            cursoa = new int[5];
            cursob = new int[5];

            Console.WriteLine("ingrese notas");
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("notas");
                cursoa[f] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("ingrese notas");
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("notas");
                cursob[f] = int.Parse(Console.ReadLine());
            }
        }


        public void operacion() {



            int sumar = 0;
            for (int f = 0; f < 5; f++)
            {
               sumar= sumar+cursoa[f];
               promedioa = sumar/5;
            }
            Console.WriteLine("el promedio curso1 es:" + promedioa);
        }


        public void operacion2()
        {

            int sumar = 0;

            for (int f = 0; f < 5; f++)
            {
                sumar = sumar+ cursob[f];
                promediob = sumar/5;
            }
            Console.WriteLine("el promedio curso 2:" + promediob);
        }


        public void promedio() {

            if (promedioa > promediob)
            {
                Console.WriteLine("curso promdeio" + promedioa);

            }
            else {
                Console.WriteLine("curso "+promediob);
            
            }
        }

        static void Main(string[] args)
        {
            vector6 vect =new vector6();
            vect.carga();
            vect.operacion();
            vect.operacion2();
            vect.promedio();
            Console.ReadKey();

        }
    }
}
