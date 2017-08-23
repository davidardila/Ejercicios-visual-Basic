using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplos_de_5_ejer05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int i;
          
            for (i = 0; i <= 100; i=i+5)
            {

                suma =suma+ i;


                MessageBox.Show(" los multiplos de 5 son: " + i);
        

            }

            MessageBox.Show("la suma de los multiplos de 5 son: " + suma);
       
        }
    }
}
