using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerospares_hasta_el_160_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float suma=0;


            for (int i = 0; i < 160; i=i+2)
            {
                suma = suma + i;

                MessageBox.Show("los numeros pares son"+i);
            }

            MessageBox.Show("lasuma es"+suma);

        }
    }
}
