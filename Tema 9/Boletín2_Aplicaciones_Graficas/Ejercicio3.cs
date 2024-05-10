using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletín2_Aplicaciones_Graficas
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        double metros;
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtBoxCantidadDeMetros.Text != "")
            {
                if (radioBtnMilimetros.Checked)
                {
                    metros = double.Parse(txtBoxCantidadDeMetros.Text) * 1000;
                    txtBoxResultado.Text = metros.ToString();
                }
                else if (radioBtnCentimetros.Checked)
                {
                    metros = double.Parse(txtBoxCantidadDeMetros.Text) * 100;
                    txtBoxResultado.Text = metros.ToString();
                }
                else if (radioBtnDecimetros.Checked)
                {
                    metros = double.Parse(txtBoxCantidadDeMetros.Text) * 10;
                    txtBoxResultado.Text = metros.ToString();
                }
                else if (radioBtnKilometros.Checked)
                {
                    metros = double.Parse(txtBoxCantidadDeMetros.Text) / 1000;
                    txtBoxResultado.Text = metros.ToString();
                }
            }
            else
            {
                MessageBox.Show("Debes dar una cantidad de metros");
            }
        }

        private void btnNuevoCalculo_Click(object sender, EventArgs e)
        {
            txtBoxCantidadDeMetros.Clear();
            txtBoxResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
