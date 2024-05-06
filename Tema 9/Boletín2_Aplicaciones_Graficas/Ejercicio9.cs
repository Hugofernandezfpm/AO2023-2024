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
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void comboBoxPrimerPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void radioBtnCrema_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            comboBoxPrimerPlato.Items.Add("Champiñones");
            comboBoxPrimerPlato.Items.Add("Puerros");
            comboBoxPrimerPlato.Items.Add("Zanahoria");    
        }
        private void radioBtnEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            comboBoxPrimerPlato.Items.Add("Champiñones");
            comboBoxPrimerPlato.Items.Add("Puerros");
            comboBoxPrimerPlato.Items.Add("Zanahoria");
        }
        private void radioBtnEmpanada_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            comboBoxPrimerPlato.Items.Add("Champiñones");
            comboBoxPrimerPlato.Items.Add("Puerros");
            comboBoxPrimerPlato.Items.Add("Zanahoria");
        }

        private void txtBoxPrecioPrimerPlato_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPrimerPlato.)
            {

            }
        }
    }
}
