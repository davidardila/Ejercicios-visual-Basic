using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sueldo = 750000;
            float venta1,venta2,venta3;

            venta1 = float.Parse(textBox1.Text);
            venta2 = float.Parse(textBox2.Text);
            venta3 = float.Parse(textBox3.Text);

            float suel = venta1 + venta2 + venta3;
            float comision = suel * 1.02f;
            float resultado = comision + sueldo;

            MessageBox.Show("el resultado de su sueldo es"+sueldo+"la suma de sus ventas es"+suel+"y el sueldo mas el 10 porciento de las ventas es:"+resultado); 
        }
    }
}
