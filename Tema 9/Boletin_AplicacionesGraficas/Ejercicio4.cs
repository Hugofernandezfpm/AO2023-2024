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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            double horas = double.Parse(textBoxHoras.Text);
            double minutos = horas * 60;
            double segundos = horas * 120;
            textBoxMinutos.Text = minutos.ToString();
            textBoxSegundos.Text = segundos.ToString();
        }
    }
}
