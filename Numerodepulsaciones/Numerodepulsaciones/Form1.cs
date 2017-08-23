using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerodepulsaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float edad;

            edad = float.Parse(textBox1.Text);


            float numpulsaciones = (220 - edad) / 10;

            MessageBox.Show("las pulsaciones son"+numpulsaciones);

        }
    }
}
