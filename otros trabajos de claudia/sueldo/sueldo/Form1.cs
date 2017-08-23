using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sueldo,sueldo2;
            int horas,hora,hor;
            int horatra = 5000;
            int horaex = 7000;
            horas = int.Parse(textBox1.Text);
            if (horas <= 40)
            {

                sueldo = horas * horatra;
                MessageBox.Show("el sueldo es" + sueldo);
            }
            else {

                hora = horas-40 ;
                sueldo2 = horaex * hora;
                sueldo = 40*horatra+sueldo2 ;
                MessageBox.Show("el sueldo es" + sueldo);


            }
        }
    }
}
