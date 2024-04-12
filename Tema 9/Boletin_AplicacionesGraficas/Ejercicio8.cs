using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Boletin_AplicacionesGraficas
{
    public partial class Ejercicio8 : Form
    {
        char operador1;
        double numero1;
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxResultado.Text)) //esto hace que si la caja de texto esta vacia no de error                                                                                          
            {
              

              
               
                if (operador1 == '+')
                {
                   
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double sumar = numero1 + numero2;
                    textBoxResultado.Text = sumar.ToString();
                }
                else if (operador1 == '-')
                {
                   
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double restar = numero1 - numero2;
                    textBoxResultado.Text = restar.ToString();
                }
                else if (operador1 == '*')
                {
                   
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double multiplicar = numero1 * numero2;
                    textBoxResultado.Text = multiplicar.ToString();
                }
                else if (operador1 == '/')
                {
                    
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double dividir = numero1 / numero2;
                    textBoxResultado.Text = dividir.ToString();
                }
                else if (operador1 == '%')
                {
                    double numero2 = double.Parse(textBoxResultado.Text);
                    double porcentaje = numero1 * numero2/100;
                    textBoxResultado.Text = porcentaje.ToString();
                }
            }
        }


        private void operador(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Button boton = (System.Windows.Forms.Button)sender;//esto hace q los botones de mas menos multiplicar y dividir se programen todo aqui
            if (boton.Text == "+")
            {
                operador1 = '+';
                //textBoxResultado.Text += operador1.ToString();
                numero1 = double.Parse(textBoxResultado.Text);
                textBoxResultado.Clear();

            }

            else if (boton.Text == "-")
            {
                operador1 = '-';
                // textBoxResultado.Text = textBoxResultado.Text + " " + operador1.ToString();
                numero1 = double.Parse(textBoxResultado.Text);
                textBoxResultado.Clear();
            }

            else if (boton.Text == "*")
            {
                operador1 = '*';
                //textBoxResultado.Text += operador1.ToString();
                numero1 = double.Parse(textBoxResultado.Text);
                textBoxResultado.Clear();
            }

            else if (boton.Text == "/")
            {
                operador1 = '/';
                //textBoxResultado.Text += operador1.ToString();
                numero1 = double.Parse(textBoxResultado.Text);
                textBoxResultado.Clear();
            }
            else if (boton.Text == "%")
            {
                operador1 = '%';
                numero1 = double.Parse(textBoxResultado.Text);
                textBoxResultado.Clear();
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

        private void btnBinario_Click(object sender, EventArgs e)
        {
            // Obtener el número decimal apartir de lo que ponga en la caja de texto de resultado
            int numeroDecimal = int.Parse(textBoxResultado.Text);

            
            string binario = "";

            // Si el número es 0, el binario también es 0
            if (numeroDecimal == 0)
            {
                binario = "0";
            }
            else
            {
                // Realizar la conversión a binario con un bucle for
                for (int i = numeroDecimal; i > 0; i /= 2)
                {
                    
                    binario = (i % 2) + binario;
                }
            }

            // Mostrar el resultado en la caja de texto correspondiente
            textBoxResultado.Text = binario;
        }

     

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text.Length > 0)
            {
                // Eliminar el último carácter del TextBox
                textBoxResultado.Text = textBoxResultado.Text.Remove(textBoxResultado.Text.Length - 1);
            }

        }
    }
}
