using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendedores_de_autos_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre= Convert.ToString(textBox1.Text);
            int numeroautos=int.Parse(textBox2.Text) ;
            float valoraut= float.Parse(textBox3.Text);

            float sueldo = 750000,valora,valorb,valorc,valort=0;

            if (numeroautos<=0)
            {
                MessageBox.Show(" su nombre es   :"+ nombre);

            }
            else
            {
                if (numeroautos > 0)
                {
                    valora = numeroautos * 100000;
                    valorb = valoraut * 0.02f;
                    valorc = valora + valorb;
                    valort = sueldo + valorc;
                }
                MessageBox.Show(" el total de su sueldo  es" + valort+"\n"+nombre);
                    
            }
           

           

        }
    }
}
