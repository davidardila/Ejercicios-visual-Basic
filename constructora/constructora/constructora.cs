using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//realice un algoritmo para que la empresa constructora tecno vivir que le permita calcular e imprimir la nomina para su cancelacion a un total de 50 obreros a quienes debe cancelar por horas trabajadas. la hora trabajada se pauto a 10 mil pesos
namespace constructora
{
    class constructora
    {

        int[] obreros;
        int horastra;
        float totalnomina;
        float salario;
        public void cargar() {

            obreros = new int[50];

            Console.WriteLine("sueldo de empleados ");
        
            
                Console.WriteLine("ingrese horas trabajadas");
                horastra = int.Parse(Console.ReadLine());
            
        
        }


        public void calcular()
        {
               for (int f = 0; f < 50; f++)
            {
                 salario = horastra * 10000;
                 totalnomina = obreros[f] + salario;

            }

            Console.WriteLine("total nomina es:" + totalnomina);
         

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            constructora construct = new constructora();
            construct.cargar();
            construct.calcular();

        }
    }
}
