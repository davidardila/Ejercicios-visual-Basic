using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcularedad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float edad, aactual;
            aactual = 2017;

            edad = float.Parse(textBox1.Text);

            float nacimiento =aactual-edad;

            MessageBox.Show("edad"+nacimiento);
        }
    }
}
