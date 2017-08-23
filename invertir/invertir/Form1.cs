using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1)	Suponga que un individuo desea invertir su capital en un banco
// y desea saber cuánto dinero ganara después de un mes si el banco paga a razón de 2% mensual.
namespace invertir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float capital,cap;
            
            capital = float.Parse(textBox1.Text);

            cap = capital*1.02f;
            MessageBox.Show("lo invertido fue"+capital+"y al mes se aumento un dos porciento"+cap);

        }
    }
}
