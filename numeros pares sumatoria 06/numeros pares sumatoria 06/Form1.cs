using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros_pares_sumatoria_06
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

            for (int i =1; i < 100; i++)
            {
                if (i%2==0)
                {
                    suma = suma + i;

                    MessageBox.Show("los numeros impares son   :" + i);
                    
                }
               
            }
            MessageBox.Show(" la suma de los numeros impares son  :" + suma);
        }
    }
}
