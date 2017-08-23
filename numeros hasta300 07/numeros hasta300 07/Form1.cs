using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros_hasta300_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int suma=0;
            for (int i = 0; i <30; i++)
            {
                if(i%2==0){
               
                     
            } else
                {
                    suma = suma + i;
            MessageBox.Show("numeros impares   :"+i);
                }

            }
            MessageBox.Show("la sumatoria de los numeros impares son   :"+suma);
        }
    }
}
