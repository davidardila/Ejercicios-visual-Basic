using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ejercicioinputbox
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        long reprobado =0;
        long porcentaje = 0;
        string nota;
        long i = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (i <= 20) {
                nota = Interaction.InputBox("ingrese valor", "mensaje", "", 50, 50);
                if (Convert.ToDouble(nota) >= 0 && Convert.ToDouble(nota) < -3.4) {
                    reprobado = reprobado + 1;
                }
                i=i+1;
            
            }
            porcentaje = (reprobado * 100) / 20;
            MessageBox.Show("el porcentaje es:"+ porcentaje);
        }
    }
}
