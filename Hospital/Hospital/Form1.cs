using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float presupuesto;
            float gineco, trauma, pediatri;
            presupuesto = float.Parse(textBox1.Text);

            gineco = presupuesto * 0.40f;
            trauma = presupuesto * 0.30f;
            pediatri = presupuesto * 0.30f;

            MessageBox.Show("ginecologia le corresponde"+gineco+"traumatologia le corresponde"+trauma+"pediatria le corresponde"+pediatri);
        }
    }
}
