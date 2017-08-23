using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hombresymujeres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float hombres, mujeres,estudiante;


            hombres = float.Parse(textBox1.Text);
            mujeres = float.Parse(textBox2.Text);

            estudiante = hombres + mujeres;

            float personas = hombres * 100 / estudiante;
            float personas2 = mujeres * 100 / estudiante;


            MessageBox.Show("porcentaje hombres es:" +personas);
            MessageBox.Show("porcentaje" +personas2);
        }
    }
}
