using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//una empreresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados(4 por la mañana y 4 por la tarde)
//confeccionar un programa que permita almacenar los sueldos de los enpleados agrupados por turno.
//imprimir los gastos en sueldos de cada turno 
namespace vector2
{
    class programavectores2
    {
        private float[] turnom;
        private float[] turnot;
     

        public void cargar()
        {
            turnom = new float[4];
            turnot = new float[4];

            Console.WriteLine("sueldo de empleados mañana");
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("ingrese sueldo mañana");
                turnom[f] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("sueldos de empleados del turno de la tarde");
            for (int f = 0; f < 4; f++) {
                Console.WriteLine("ingrese sueldo turno tarde");
              turnot[f]=float.Parse(Console.ReadLine());
            }

        }

        public void calculargastos() {

            float m = 0;
            float t = 0;

            for(int f=0; f<4; f++){
                m = m + turnom[f];
                t=t + turnot[f];
            
            }

            Console.WriteLine("toral sueldo turno mañana"+m);
            Console.WriteLine("total sueldo turno tarde"+t);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            programavectores2 vector = new programavectores2();
            vector.cargar();
            vector.calculargastos();
            Console.ReadKey();
        }
    }
}
