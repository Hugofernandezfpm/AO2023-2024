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
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(textBoxNumero1.Text);
            double numero2 = double.Parse(textBoxNumero2.Text);
            double sumar = numero1 + numero2;
            textBoxResultado.Text = sumar.ToString();

            labelSumar.Visible = true;
            labelRestar.Visible = false;
            labelMultiplicar.Visible = false;
            labelDividir.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double numero1 = double.Parse(textBoxNumero1.Text);
            double numero2 = double.Parse(textBoxNumero2.Text);
            double restar = numero1 - numero2;
            textBoxResultado.Text = restar.ToString();


            labelSumar.Visible = false;
            labelRestar.Visible = true;
            labelMultiplicar.Visible = false;
            labelDividir.Visible = false;
        }
    }
}
