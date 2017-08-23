using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresainvertirsocios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float s1, s2, s3;

            s1 = float.Parse(textBox1.Text);
            s2 = float.Parse(textBox2.Text);
            s3 = float.Parse(textBox3.Text);


            float suma = s1 + s2 + s3;

            float porcentaje1 = s1 * 100 / suma;
            float porcentaje2 = s2 * 100 / suma;
            float porcentaje3 = s3 * 100/ suma;

            MessageBox.Show("el porcentaje del primer socio es: "+porcentaje1+"%"+"el porcentaje del segundo socio es:"+porcentaje2+ "%" + "el porcentaje del tercer socio" +porcentaje3+"%");
        }
    }
}
