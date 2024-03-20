using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boletinAplicacionesGraficas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
           
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;

            MessageBox.Show("Nombre: " + nombre + "\nCorreo: " + correo, "Datos del Formulario");
        }
    }
    
}
