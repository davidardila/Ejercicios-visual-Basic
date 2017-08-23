using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numero16alumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float examenmate, nm1, nm2, nm3;

            examenmate = float.Parse(textBox1.Text);
            nm1 = float.Parse(textBox2.Text);
            nm2= float.Parse(textBox3.Text);
            nm3 = float.Parse(textBox4.Text);


            float porcenexamate = examenmate * 0.90f;

            float promedionotas = (nm1 + nm2 + nm3)/3;
            float porcentajenotas = promedionotas * 0.10f;

            float totalmate = porcenexamate + porcentajenotas;

            //notas de fisica

            float examenfisi, nf1, nf2;

            examenfisi = float.Parse(textBox5.Text);
            nf1 = float.Parse(textBox6.Text);
            nf2 = float.Parse(textBox7.Text);

            float porcenexafisi = examenfisi * 0.80f;
            float promedionotasfisi = (nm1 + nm2 ) / 2;
            float porcentajenotasfisi = promedionotasfisi * 0.20f;

            float totalfisi = porcenexafisi + porcentajenotasfisi;


            //notas quimica

            float examenquimi, nq1, nq2,nq3;

            examenquimi = float.Parse(textBox8.Text);
            nq1 = float.Parse(textBox9.Text);
            nq2 = float.Parse(textBox10.Text);
            nq3 = float.Parse(textBox11.Text);

            float porcenexaquimi = examenquimi * 0.85f;
            float promedionotasquimi = (nq1 + nq2+nq3) / 3;
            float porcentajenotasquimi = promedionotasquimi * 0.15f;

            float totalquimi = porcenexafisi + porcentajenotasfisi;

            float promediototal = (totalmate + totalfisi + totalquimi) / 3;

            MessageBox.Show("el promedio de matematicas fue"+totalmate+"el promedio de fisica fue:"+totalfisi+"el promedio de quimica fue "+totalquimi+"y el promedio general fue: "+promediototal);
            


        }
    }
}
