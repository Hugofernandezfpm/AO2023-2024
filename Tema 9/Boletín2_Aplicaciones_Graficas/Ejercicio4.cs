using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletín2_Aplicaciones_Graficas
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (radioBtnCargarenComboBox.Checked)
            {
                comboBoxRegistro.Items.Add(txtNombreDelCampo.Text);
            }
            else if (radioBtnCargarEnLisBox.Checked)
            {
                listBoxRegistro.Items.Add(txtNombreDelCampo.Text);
            }
        }
        
        private void btnVolcar_Click(object sender, EventArgs e)
        {
            StreamWriter registroDeNombres = new StreamWriter(Directory.GetCurrentDirectory() + "registroDeNombres.txt");
        }
    }
}
