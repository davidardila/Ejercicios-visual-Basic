using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float lunes, miercoles, viernes;

            lunes = float.Parse(textBox1.Text);
            miercoles = float.Parse(textBox2.Text);
            viernes = float.Parse(textBox3.Text);


            float promedio = (lunes + miercoles + viernes) * 3 / 7;

            MessageBox.Show("el promedio de la semana es"+promedio);
        }
    }
}
