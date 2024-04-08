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
    public partial class Ejercicio5 : Form
    {
        char operador1; //operador para asignar a casa boton lo q hace cada uno
        public Ejercicio5()
        {
            InitializeComponent();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNumero1.Text) && !string.IsNullOrEmpty(textBoxNumero2.Text)) //esto hace que si la caja de texto esta                                                                                            //vacia no de error
            {
              if (operador1 == '+')
                {
                    double numero1 = double.Parse(textBoxNumero1.Text);
                    double numero2 = double.Parse(textBoxNumero2.Text);
                    double sumar = numero1 + numero2;
                    textBoxResultado.Text = sumar.ToString();
                }
              else if (operador1 == '-')
                {
                    double numero1 = double.Parse(textBoxNumero1.Text);
                    double numero2 = double.Parse(textBoxNumero2.Text);
                    double restar = numero1 - numero2;
                    textBoxResultado.Text = restar.ToString();
                }
              else if (operador1 == '*')
                {
                    double numero1 = double.Parse(textBoxNumero1.Text);
                    double numero2 = double.Parse(textBoxNumero2.Text);
                    double multiplicar = numero1 * numero2;
                    textBoxResultado.Text = multiplicar.ToString();
                }
                else
                {
                    double numero1 = double.Parse(textBoxNumero1.Text);
                    double numero2 = double.Parse(textBoxNumero2.Text);
                    double dividir = numero1 / numero2;
                    textBoxResultado.Text = dividir.ToString();
                }


            }
        }

        private void operador(object sender, EventArgs e)  
        {
            Button boton = (Button)sender; //esto hace q los botones de mas menos multiplicar y dividir se programen todo aqui
            if (boton.Text == "+")
            {
                operador1 = '+';
                labelSumar.Visible = true;
                labelRestar.Visible = false;
                labelMultiplicar.Visible = false;
                labelDividir.Visible = false;
            }

            else if (boton.Text == "-")
            {
                operador1 = '-';
                labelSumar.Visible = false;
                labelRestar.Visible = true;
                labelMultiplicar.Visible = false;
                labelDividir.Visible = false;
            }

            else if (boton.Text == "*")
            {
                operador1 = '*';
                labelSumar.Visible = false;
                labelRestar.Visible = false;
                labelMultiplicar.Visible = true;
                labelDividir.Visible = false;
            }

            else if (boton.Text == "/")
            {
                operador1 = '/';
                labelSumar.Visible = false;
                labelRestar.Visible = false;
                labelMultiplicar.Visible = false;
                labelDividir.Visible = true;
            }
        }

           
    }
}
