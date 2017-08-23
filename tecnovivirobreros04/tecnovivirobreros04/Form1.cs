using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tecnovivirobreros04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nomina=0, horas = 10000;
            double  hobreros = 50;
          

            horas = double.Parse(textBox1.Text);
            for (int i = 0; i < hobreros; i++)
            {
             
                nomina = horas * hobreros;
               
            }
            MessageBox.Show(" la  nomina es  " + nomina);

        }
    }
}
