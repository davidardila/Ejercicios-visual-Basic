using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botonformulariodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = button3.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)//si el visto bueno esta activado

                pictureBox1.Show();//vizualize la imagen show "mostrar imagen" 

            else {
                if (checkBox1.Checked == false)//desaparece la imagen
                {
                    pictureBox1.Visible = false;

                }

            }

        }


        
        
        



    }
}
