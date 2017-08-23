using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2.	Realice un algoritmo que calcule el monto a pagar por el servicio de estacionamiento, 
//teniendo en cuenta que por la primera hora de estadía se tiene una tarifa de 1000 pesos y las restantes tienen un costo de 600 
namespace estacionamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float he=0, hs=0,horat=0,valor=1000;

            he = float.Parse(textBox1.Text);
            hs = float.Parse(textBox2.Text);

           
            horat = hs - he;
            for (int i = 0; i <horat-1; i++)
            {

                valor +=  600;
              
            

            }
            MessageBox.Show("el valor es" + valor);



        }
    }
}
