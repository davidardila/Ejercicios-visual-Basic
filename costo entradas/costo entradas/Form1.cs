using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace costo_entradas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float entrada,valor,descuento,total=0;

            entrada = float.Parse(textBox1.Text);

            valor = 1000;
            for (int i = 0; i < entrada-1; i++)
            {

                if (entrada == 2)
                {

                     descuento = valor * 0.10f;
                    total = valor - descuento;

                }
                else {

                    if (entrada==3) {

                         descuento = valor * 0.15f;
                        total = valor - descuento;


                    }

                    if (entrada == 4) {

                       descuento = valor * 0.20f;
                        total = valor - descuento;
                    }

                    if (entrada > 4) {

                        MessageBox.Show("el numero de boletas no es permitido");
                    }



                }


                MessageBox.Show("el valor es" + total);


            }
          

        }
    }
}
