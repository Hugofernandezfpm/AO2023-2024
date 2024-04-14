using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_AplicacionesGraficas
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreGuardar.Text;
            string apellidos = textBoxApellidoGuardar.Text;
            string edad = textBoxEdadGuardar.Text;
            string email = textBoxEmailGuardar.Text;
            string dni = textDNIGuardar.Text;
            List<string> usuario = new List<string>();

            string usuarioGuardar = nombre + apellidos + edad + email + dni;
            usuario.Add(usuarioGuardar);

            textBoxNombreGuardar.Clear();
            textBoxApellidoGuardar.Clear();
            textBoxEdadGuardar.Clear();
            textBoxEmailGuardar.Clear();
            textDNIGuardar.Clear();
        }
    }
}
