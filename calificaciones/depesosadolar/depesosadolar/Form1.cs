using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depesosadolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pesos,dolar,valor;
            dolar = 2955;

            pesos = float.Parse(textBox1.Text);


            valor = pesos / dolar;


            MessageBox.Show("la cantidad es dolares es:"+valor);




        }
    }
}
