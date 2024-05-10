using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            if(txtNombreDelCampo.Text != "")
            {
                if (radioBtnCargarenComboBox.Checked)
                {
                    comboBoxRegistro.Items.Add(txtNombreDelCampo.Text);
                }
                else if (radioBtnCargarEnLisBox.Checked)
                {
                    listBoxRegistro.Items.Add(txtNombreDelCampo.Text);
                }
                if (radioBtnCargarenComboBox.Checked || radioBtnCargarEnLisBox.Checked)
                {
                    txtNombreDelCampo.Clear();
                }
                else
                {
                    MessageBox.Show("Desbes selccionar una opción");
                }
            }
            else
            {
                MessageBox.Show("Debes escribir un nombre");
            }
           
          
            
        }
        
        private void btnVolcar_Click(object sender, EventArgs e)
        {
            StreamWriter registroDeNombres = new StreamWriter(Directory.GetCurrentDirectory() + "\\registroDeNombres.txt",true);
            List<string> nombres = new List<string>();

            if (txtNombreDelCampo.Text != "")
            {
                foreach (var item in comboBoxRegistro.Items)
                {
                    nombres.Add(item.ToString());
                }

                foreach (var item in listBoxRegistro.Items)
                {
                    nombres.Add(item.ToString());
                }

                for (int i = 0; i < nombres.Count; i++)
                {
                    registroDeNombres.WriteLine(nombres[i]);
                }
                registroDeNombres.Close();
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacio");
            }
        }
    }
}
