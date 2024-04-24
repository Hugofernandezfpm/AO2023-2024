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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void radioBtnTigre_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxTigre.Visible = true;
            pictureBoxTiburon.Visible = false;
            pictureBoxJirafa.Visible = false;
        }

        private void radioBtnTiburon_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxTiburon.Visible = true;
            pictureBoxTigre.Visible = false;
            pictureBoxJirafa.Visible = false;
        }

        private void radioBtnJirafa_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxJirafa.Visible = true;
            pictureBoxTigre.Visible = false;
            pictureBoxTiburon.Visible = false;
        }
    }
}
