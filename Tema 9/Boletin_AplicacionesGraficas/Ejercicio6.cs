using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_AplicacionesGraficas
{
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((Keys.Enter)))
            {
                double gradosCentigrados = Convert.ToDouble(textBox1.Text);
                double gradosFarenheit = (gradosCentigrados * 9 / 5) + 32;
                textBox2.Text = gradosFarenheit.ToString();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((Keys.Enter)))
            {
                double gradosFarenheit = Convert.ToDouble(textBox2.Text);
                double gradosCentigrados = (gradosFarenheit  - 32) * 5/ 9;
                textBox1.Text = gradosCentigrados.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gradosCentigrados = Convert.ToDouble(textBox1.Text);
            double gradosFarenheit = (gradosCentigrados * 9 / 5) + 32;
            textBox2.Text = gradosFarenheit.ToString();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            double gradosFarenheit = Convert.ToDouble(textBox2.Text);
            double gradosCentigrados = (gradosFarenheit - 32) * 5 / 9;
            textBox1.Text = gradosCentigrados.ToString();
        }
    }
}
