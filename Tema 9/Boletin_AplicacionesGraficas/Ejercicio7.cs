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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double euros = Convert.ToDouble(textBox1.Text);
                double dolares = euros * 1.08;
                textBox2.Text = dolares.ToString();
            }
                
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                double dolares = Convert.ToDouble(textBox2.Text);
                double euros = dolares / 1.08;
                textBox1.Text = euros.ToString();
            }
               
        }
    }
}
