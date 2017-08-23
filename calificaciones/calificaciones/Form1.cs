using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float parcial1, parcial2, parcial3;
            float exafinal, trafinal;
            float promedio;
            float califinal;


            parcial1 = float.Parse(textBox1.Text);
            parcial2 = float.Parse(textBox2.Text);
            parcial3 = float.Parse(textBox3.Text);

            exafinal = float.Parse(textBox4.Text);
            trafinal = float.Parse(textBox5.Text);

             promedio = (parcial1 + parcial2 + parcial3) / 3;
             float porcentaje1 = promedio * 0.55f;

            float porcentaje2 = exafinal * 0.30f;
            float porcentaje3 = trafinal * 0.15f;

            califinal = porcentaje1 + porcentaje2 + porcentaje3;

            MessageBox.Show("po0rcentaje de parcial" + porcentaje1+"la calificacion final es:"+califinal);

        }
    }
}
