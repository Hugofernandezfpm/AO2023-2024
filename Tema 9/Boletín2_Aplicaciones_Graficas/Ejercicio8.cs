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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            Random numeroDados = new Random();
            int numeroAleatorio = numeroDados.Next(1, 6);

            if (numeroAleatorio == 1) 
            {
                pictureBoxDadoNumero1.Visible = true;
                pictureBoxDadoNumero2.Visible = false;
                pictureBoxDadoNumero3.Visible = false;
                pictureBoxDadoNumero4.Visible = false;
                pictureBoxDadoNumero5.Visible = false;
                pictureBoxDadoNumero6.Visible = false;
                pictureBoxDadoNumero1Segundo.Visible = false;
                pictureBoxDadoNumero2Segundo.Visible = false;
                pictureBoxDadoNumero3Segundo.Visible = true;
                pictureBoxDadoNumero4Segundo.Visible = false;
                pictureBoxDadoNumero5Segundo.Visible = false;
                pictureBoxDadoNumero6Segundo.Visible = false;
                pictureBoxDadoNumero5Tercero.Visible = false;
                pictureBoxNumero2Cuarto.Visible = true;
            }
            else if (numeroAleatorio == 2)
            {
                pictureBoxDadoNumero3.Visible = true;
                pictureBoxDadoNumero4Segundo.Visible = true;
                pictureBoxDadoNumero1Tercero.Visible = true;
                pictureBoxNumero6Cuarto.Visible = true;
            }

        }
    }
}
