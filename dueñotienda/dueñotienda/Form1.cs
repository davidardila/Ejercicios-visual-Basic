using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dueñotienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor;

            valor = float.Parse(textBox1.Text);

            float porcentaje = valor * 0.30f;
            float total = valor + porcentaje;

            MessageBox.Show("el valor para vender es"+total);

        }
    }
}
