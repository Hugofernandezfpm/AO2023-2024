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
    public partial class Ejercicio8 : Form
    {
        char operador1;
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //int numeros = buttonNumero0.Text || buttonNumero1.Text || buttonNumero2.Text || buttonNumero3.Text || buttonNumero4.Text || buttonNumero5.Text || buttonNumero6.Text || buttonNumero7.Text || buttonNumero8.Text || buttonNumero9.Text;


        

            if (!string.IsNullOrEmpty(textBoxResultado.Text)) //esto hace que si la caja de texto esta vacia no de error                                                                                          
            {
                if (operador1 == '+')
                {
                    double numero1 = double.Parse(textBoxResultado.Text);
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double sumar = numero1 + numero2;
                    textBoxResultado.Text = sumar.ToString();
                }
                else if (operador1 == '-')
                {
                    double numero1 = double.Parse(textBoxResultado.Text);
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double restar = numero1 - numero2;
                    textBoxResultado.Text = restar.ToString();
                }
                else if (operador1 == '*')
                {
                    double numero1 = double.Parse(textBoxResultado.Text);
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double multiplicar = numero1 * numero2;
                    textBoxResultado.Text = multiplicar.ToString();
                }
                else if (operador1 == '/')
                {
                    double numero1 = double.Parse(textBoxResultado.Text);
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double dividir = numero1 / numero2;
                    textBoxResultado.Text = dividir.ToString();
                }
            }
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero0.Text;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnPunto.Text;
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero1.Text;
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero2.Text;
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero3.Text;
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero4.Text;
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero5.Text;
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero6.Text;
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero7.Text;
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero8.Text;
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += btnNumero9.Text;
        }
    }
}
