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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            string dia = textBoxDia.Text;
            string mes = textBoxMes.Text;
            string año = textBoxAño.Text;
            string resultado = dia + " de " + mes + " del " + año;

            textBoxResultado.Text = resultado;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
