using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_de_heterogeneos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, resultado1, result, result2, resultado3;
            double resultado2;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor");

            }
            else {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox1.Text);
                c= double.Parse(textBox1.Text);
                d = double.Parse(textBox1.Text);


                if (b >= 1) {

                    if (d >= 1)
                    {

                        resultado1 = (a * b) + (b * c);
                        resultado3 = Math.Pow(resultado1, 2);
                        result = resultado1 * 2;

                        resultado2 = (b * d);
                        result2 = Math.Pow(resultado2, 2);

                        textBox5.Text = result.ToString();
                        textBox6.Text = result2.ToString();
                    }
                    else
                        MessageBox.Show("debe ingresar el valor del denominador mayor a cero");

                    
                }
            }
        }
    }
}
