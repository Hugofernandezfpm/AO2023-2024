using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_AplicacionesGraficas
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            double cuadrado = double.Parse(textBoxLado.Text);
            double resultado = cuadrado * cuadrado;
            textBoxResultado.Text = "El valor del cuadrado es " + resultado.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoMayor = double.Parse(textBoxLadoMayor.Text);
            double ladoMenor = double.Parse(textBoxLadoMenor.Text);
            double resultado = ladoMayor * ladoMenor;
            textBoxResultado.Text = " El valor del triangulo es " + resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double base1 = double.Parse(textBoxBase.Text);
            double altura = double.Parse(textBoxAltura.Text);
            double resultado = base1 * altura;
            textBoxResultado.Text = " El valor del triangulo es " + resultado.ToString();
        }
    }
}
