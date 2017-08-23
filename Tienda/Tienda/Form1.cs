using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
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
            double descuento; 
            valor = float.Parse(textBox1.Text);

            
            double desc = valor * 0.15;
            descuento = valor - desc;
            MessageBox.Show("el descuento es"+descuento);
            
       }
    }
}
