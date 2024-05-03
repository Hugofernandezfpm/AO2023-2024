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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void listBoxTurnoDeMañana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int numero;
        private void comboBoxEligeElTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEligeElTurno.Text == "Turno de mañana")
            {
                listBoxTurnoDeMañana.Items.Add(txtBoxNombreDelEmpleado.Text);
                numero = listBoxTurnoDeMañana.Items.Count;
                txtBoxTotalMañana.Text = numero.ToString();
            }
            else if (comboBoxEligeElTurno.Text == "Turno de noche")
            {
                listBoxTurnoDeNoche.Items.Add(txtBoxNombreDelEmpleado.Text);
                numero = listBoxTurnoDeNoche.Items.Count;
                txtBoxTotalNoche.Text = numero.ToString();
            }
        }

        private void btnUnoALaDerecha_Click(object sender, EventArgs e)
        {
            if (listBoxTurnoDeMañana.SelectedItem != null)
            {
                listBoxTurnoDeNoche.Items.Add(listBoxTurnoDeMañana.SelectedItem);
                listBoxTurnoDeMañana.Items.Remove(listBoxTurnoDeMañana.SelectedItem);
                numero = listBoxTurnoDeMañana.Items.Count;
                txtBoxTotalMañana.Text = numero.ToString();
                numero = listBoxTurnoDeNoche.Items.Count;
                txtBoxTotalNoche.Text = numero.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un valor");
            }


        }
        
        private void btnTodoALaDerecha_Click(object sender, EventArgs e)
        {
            if (listBoxTurnoDeMañana.Items.Count > 0)
            {
                foreach (var item in listBoxTurnoDeMañana.Items)
                {
                    listBoxTurnoDeNoche.Items.Add(item);
                }
                listBoxTurnoDeMañana.Items.Clear();
                numero = listBoxTurnoDeMañana.Items.Count;
                txtBoxTotalMañana.Text = numero.ToString();
                numero = listBoxTurnoDeNoche.Items.Count;
                txtBoxTotalNoche.Text = numero.ToString();
            }
            else
            {
                MessageBox.Show("La lista debe tener valores");
            }

        }

        private void btnUnoALaIzquierda_Click(object sender, EventArgs e)
        {
            if (listBoxTurnoDeNoche.SelectedItem != null)
            {
                listBoxTurnoDeMañana.Items.Add(listBoxTurnoDeNoche.SelectedItem);
                listBoxTurnoDeNoche.Items.Remove(listBoxTurnoDeNoche.SelectedItem);
                numero = listBoxTurnoDeMañana.Items.Count;
                txtBoxTotalMañana.Text = numero.ToString();
                numero = listBoxTurnoDeNoche.Items.Count;
                txtBoxTotalNoche.Text = numero.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un valor");
            }
            
        }

        private void btnTodoALaIzquierda_Click(object sender, EventArgs e)
        {
            if (listBoxTurnoDeNoche.Items.Count > 0)
            {
                foreach (var item in listBoxTurnoDeNoche.Items)
                {
                    listBoxTurnoDeMañana.Items.Add(item);
                }
                listBoxTurnoDeNoche.Items.Clear();
                numero = listBoxTurnoDeMañana.Items.Count;
                txtBoxTotalMañana.Text = numero.ToString();
                numero = listBoxTurnoDeNoche.Items.Count;
                txtBoxTotalNoche.Text = numero.ToString();
            }
            else
            {
                MessageBox.Show("La lista debe tener valores");
            }
            
        }
    }
}
