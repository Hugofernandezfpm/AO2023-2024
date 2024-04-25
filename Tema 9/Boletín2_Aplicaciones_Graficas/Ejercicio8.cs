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
            int numeroAleatorio = numeroDados.Next(1, 7);

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
                pictureBoxDadoNumero3Segundo.Visible = false;
                pictureBoxDadoNumero4Segundo.Visible = true;
                pictureBoxDadoNumero5Segundo.Visible = false;
                pictureBoxDadoNumero6Segundo.Visible = false;

                pictureBoxDadoNumero1Tercero.Visible = false;
                pictureBoxDadoNumero2Tercero.Visible = true;
                pictureBoxDadoNumero3Tercero.Visible = false;
                pictureBoxDadoNumero4Tercero.Visible = false;
                pictureBoxDadoNumero5Tercero.Visible = false;
                pictureBoxDadoNumero6Tercero.Visible = false;

                pictureBoxDadoNumero1Cuarto.Visible = false;
                pictureBoxDadoNumero2Cuarto.Visible = false;
                pictureBoxDadoNumero3Cuarto.Visible = true;
                pictureBoxDadoNumero4Cuarto.Visible = false;
                pictureBoxDadoNumero5Cuarto.Visible = false;
                pictureBoxDadoNumero6Cuarto.Visible = false;
            }
            else if (numeroAleatorio == 2)
            {
                pictureBoxDadoNumero1.Visible = false;
                pictureBoxDadoNumero2.Visible = true;
                pictureBoxDadoNumero3.Visible = false;
                pictureBoxDadoNumero4.Visible = false;
                pictureBoxDadoNumero5.Visible = false;
                pictureBoxDadoNumero6.Visible = false;

                pictureBoxDadoNumero1Segundo.Visible = false;
                pictureBoxDadoNumero2Segundo.Visible = true;
                pictureBoxDadoNumero3Segundo.Visible = false;
                pictureBoxDadoNumero4Segundo.Visible = false;
                pictureBoxDadoNumero5Segundo.Visible = true;
                pictureBoxDadoNumero6Segundo.Visible = false;

                pictureBoxDadoNumero1Tercero.Visible = false;
                pictureBoxDadoNumero2Tercero.Visible = false;
                pictureBoxDadoNumero3Tercero.Visible = false;
                pictureBoxDadoNumero4Tercero.Visible = true;
                pictureBoxDadoNumero6Tercero.Visible = false;

                pictureBoxDadoNumero1Cuarto.Visible = false;
                pictureBoxDadoNumero2Cuarto.Visible = false;
                pictureBoxDadoNumero3Cuarto.Visible = false;
                pictureBoxDadoNumero4Cuarto.Visible = false;
                pictureBoxDadoNumero5Cuarto.Visible = false;
                pictureBoxDadoNumero6Cuarto.Visible = true;
            }
            else if (numeroAleatorio == 3)
            {
                pictureBoxDadoNumero1.Visible = false;
                pictureBoxDadoNumero2.Visible = false;
                pictureBoxDadoNumero3.Visible = true;
                pictureBoxDadoNumero4.Visible = false;
                pictureBoxDadoNumero5.Visible = false;
                pictureBoxDadoNumero6.Visible = false;

                pictureBoxDadoNumero1Segundo.Visible = false;
                pictureBoxDadoNumero2Segundo.Visible = true;
                pictureBoxDadoNumero3Segundo.Visible = false;
                pictureBoxDadoNumero4Segundo.Visible = false;
                pictureBoxDadoNumero5Segundo.Visible = false;
                pictureBoxDadoNumero6Segundo.Visible = false;

                pictureBoxDadoNumero1Tercero.Visible = false;
                pictureBoxDadoNumero2Tercero.Visible = false;
                pictureBoxDadoNumero3Tercero.Visible = false;
                pictureBoxDadoNumero4Tercero.Visible = false;
                pictureBoxDadoNumero6Tercero.Visible = true;

                pictureBoxDadoNumero1Cuarto.Visible = true;
                pictureBoxDadoNumero2Cuarto.Visible = false;
                pictureBoxDadoNumero3Cuarto.Visible = false;
                pictureBoxDadoNumero4Cuarto.Visible = false;
                pictureBoxDadoNumero5Cuarto.Visible = false;
                pictureBoxDadoNumero6Cuarto.Visible = false;
            }
            else if (numeroAleatorio == 4)
            {
                pictureBoxDadoNumero1.Visible = false;
                pictureBoxDadoNumero2.Visible = false;
                pictureBoxDadoNumero3.Visible = false;
                pictureBoxDadoNumero4.Visible = true;
                pictureBoxDadoNumero5.Visible = false;
                pictureBoxDadoNumero6.Visible = false;

                pictureBoxDadoNumero1Segundo.Visible = true;
                pictureBoxDadoNumero2Segundo.Visible = false;
                pictureBoxDadoNumero3Segundo.Visible = false;
                pictureBoxDadoNumero4Segundo.Visible = false;
                pictureBoxDadoNumero5Segundo.Visible = false;
                pictureBoxDadoNumero6Segundo.Visible = false;

                pictureBoxDadoNumero1Tercero.Visible = false;
                pictureBoxDadoNumero2Tercero.Visible = false;
                pictureBoxDadoNumero3Tercero.Visible = true;
                pictureBoxDadoNumero4Tercero.Visible = false;
                pictureBoxDadoNumero6Tercero.Visible = false;

                pictureBoxDadoNumero1Cuarto.Visible = false;
                pictureBoxDadoNumero2Cuarto.Visible = false;
                pictureBoxDadoNumero3Cuarto.Visible = false;
                pictureBoxDadoNumero4Cuarto.Visible = false;
                pictureBoxDadoNumero5Cuarto.Visible = true;
                pictureBoxDadoNumero6Cuarto.Visible = false;
            }
            else if (numeroAleatorio == 5)
            {
                pictureBoxDadoNumero1.Visible = false;
                pictureBoxDadoNumero2.Visible = false;
                pictureBoxDadoNumero3.Visible = false;
                pictureBoxDadoNumero4.Visible = false;
                pictureBoxDadoNumero5.Visible = true;
                pictureBoxDadoNumero6.Visible = false;

                pictureBoxDadoNumero1Segundo.Visible = false;
                pictureBoxDadoNumero2Segundo.Visible = false;
                pictureBoxDadoNumero3Segundo.Visible = false;
                pictureBoxDadoNumero4Segundo.Visible = false;
                pictureBoxDadoNumero5Segundo.Visible = false;
                pictureBoxDadoNumero6Segundo.Visible = true;

                pictureBoxDadoNumero1Tercero.Visible = true;
                pictureBoxDadoNumero2Tercero.Visible = false;
                pictureBoxDadoNumero3Tercero.Visible = false;
                pictureBoxDadoNumero4Tercero.Visible = false;
                pictureBoxDadoNumero6Tercero.Visible = false;

                pictureBoxDadoNumero1Cuarto.Visible = false;
                pictureBoxDadoNumero2Cuarto.Visible = false;
                pictureBoxDadoNumero3Cuarto.Visible = false;
                pictureBoxDadoNumero4Cuarto.Visible = true;
                pictureBoxDadoNumero5Cuarto.Visible = false;
                pictureBoxDadoNumero6Cuarto.Visible = false;
            }
            else if (numeroAleatorio == 6)
            {
                pictureBoxDadoNumero1.Visible = false;
                pictureBoxDadoNumero2.Visible = false;
                pictureBoxDadoNumero3.Visible = false;
                pictureBoxDadoNumero4.Visible = false;
                pictureBoxDadoNumero5.Visible = false;
                pictureBoxDadoNumero6.Visible = true;

                pictureBoxDadoNumero1Segundo.Visible = false;
                pictureBoxDadoNumero2Segundo.Visible = false;
                pictureBoxDadoNumero3Segundo.Visible = true;
                pictureBoxDadoNumero4Segundo.Visible = false;
                pictureBoxDadoNumero5Segundo.Visible = false;
                pictureBoxDadoNumero6Segundo.Visible = false;

                pictureBoxDadoNumero1Tercero.Visible = false;
                pictureBoxDadoNumero2Tercero.Visible = false;
                pictureBoxDadoNumero3Tercero.Visible = false;
                pictureBoxDadoNumero4Tercero.Visible = true;
                pictureBoxDadoNumero6Tercero.Visible = false;

                pictureBoxDadoNumero1Cuarto.Visible = false;
                pictureBoxDadoNumero2Cuarto.Visible = false;
                pictureBoxDadoNumero3Cuarto.Visible = false;
                pictureBoxDadoNumero4Cuarto.Visible = true;
                pictureBoxDadoNumero5Cuarto.Visible = false;
                pictureBoxDadoNumero6Cuarto.Visible = false;
            }


        }
    }
}
