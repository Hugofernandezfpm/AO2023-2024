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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        double laserJetX;
        double bigNotebook;
        double smartDesktop;
        double hdDigicam;
        double hiTechMP4;
        double adslModem;
        double cantidad;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (checkBoxLaserJetX.Checked)
            {
                if(numericUpDownLasertJetX.Value > 0 )
                {
                    laserJetX = 100 * (double)numericUpDownLasertJetX.Value;
                }
                else
                {
                    laserJetX = 0;
                }

            }
            else
            {
                laserJetX = 0;
            }
            if (checkBoxBigNotebook.Checked)
            {
                if (numericUpDownBigNotebook.Value > 0)
                {
                    bigNotebook = 500 * (double)numericUpDownBigNotebook.Value;
                }
                else
                {
                    bigNotebook = 0;
                }
            }
            else
            {
                bigNotebook = 0;
            }
            if (checkBoxSmartDesktop.Checked)
            {
                if(numericUpDownSmartDesktop.Value > 0)
                {
                    smartDesktop = 200 * (double)numericUpDownSmartDesktop.Value;
                }
                else 
                { 
                    smartDesktop = 0; 
                }
            }
            else
            {
                smartDesktop = 0;
            }
            if (checkBoxHDDigicam.Checked)
            {
                if(numericUpDownHDDigicam.Value > 0)
                {
                    hdDigicam = 80 * (double)numericUpDownHDDigicam.Value;
                }
                else
                {
                    hdDigicam = 0;
                }
            }
            else
            { 
                hdDigicam = 0; 
            }
            if (checkBoxHiTechMP4.Checked)
            {
                if (numericUpDownHiTechMP4.Value > 0)
                {
                    hiTechMP4 = 300 * (double)numericUpDownHiTechMP4.Value;
                }
                else
                {
                    hiTechMP4 = 0;
                }
            } 
            else
            { 
                hiTechMP4 = 0;
              
            }
            if (checkBoxADSLModem.Checked)
            {
                if(numericUpDownADSLModem.Value > 0)
                {
                    adslModem = 150 * (double)numericUpDownADSLModem.Value;
                }
                else
                {
                    adslModem = 0;
                }
            }
            else
            {
                adslModem= 0;
            }

            double total = laserJetX + bigNotebook + smartDesktop + hdDigicam + hiTechMP4 + adslModem;
            txtBoxTotal.Text = total.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            checkBoxLaserJetX.Checked = false;
            numericUpDownLasertJetX.Value = 0;
            checkBoxBigNotebook.Checked = false;
            numericUpDownBigNotebook.Value = 0;
            checkBoxSmartDesktop.Checked = false;
            numericUpDownSmartDesktop.Value = 0;
            checkBoxHDDigicam.Checked = false;
            numericUpDownHDDigicam.Value = 0;
            checkBoxHiTechMP4.Checked = false;
            numericUpDownHiTechMP4.Value = 0;
            checkBoxADSLModem.Checked = false;
            numericUpDownADSLModem.Value = 0;

            txtBoxTotal.Clear();
        }
    }
}
