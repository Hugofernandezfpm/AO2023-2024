using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_AplicacionesGraficas
{

    public partial class Ejercicio9 : Form
    {
        List<string> usuario = new List<string>();
        public static string ruta = Directory.GetCurrentDirectory();
        string rutaFichero = ruta + @"\usuarios.txt";

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

            if (nombre.Length > 0 && apellidos.Length > 0 && edad.Length > 0 && email.Length > 0 && dni.Length > 0)
            {
                string usuarioGuardar = nombre + (",") + apellidos + (",") + edad + (",") + email + (",") + dni;
                usuario.Add(usuarioGuardar);

                textBoxNombreGuardar.Clear();
                textBoxApellidoGuardar.Clear();
                textBoxEdadGuardar.Clear();
                textBoxEmailGuardar.Clear();
                textDNIGuardar.Clear();

                StreamWriter usuariosAlmacenar = new StreamWriter(rutaFichero, true);
                usuariosAlmacenar.WriteLine(usuario);
            }
            else
            {
                MessageBox.Show("debes rellenar todos los campos");
            }

            
        }

        private void btnBuscarUsuario1_Click(object sender, EventArgs e)
        {
            Boolean usuarioEncontrado = false;

            foreach (string usuarios in usuario)
            {
                string[] camposUsuarios = usuarios.Split(',');

                if (camposUsuarios[4] == textBoxDNIBuscador1.Text)
                {
                    textBoxNombreMostrar.Text = camposUsuarios[0];
                    textBoxApellidosMostrar.Text = camposUsuarios[1];
                    textBoxEdadMostrar.Text = camposUsuarios[2];
                    textBoxEmailMostrar.Text = camposUsuarios[3];
                    textBoxDNIMostrar.Text = camposUsuarios[4];
                    usuarioEncontrado = true;
                }
            }

                if (!usuarioEncontrado)
                {
                    MessageBox.Show("No hay ningun usuario registrado con ese DNI");
                }
            
        }

        private void btnBuscarUsuario2_Click(object sender, EventArgs e)
        {

            Boolean usuarioEncontrado = false;
            foreach (string usuarios in usuario)
            {
                string[] camposUsuarios = usuarios.Split(',');

                if (camposUsuarios[4] == textBoxDNIBuscador1.Text)
                {
                    usuario.Remove(usuarios);
                    MessageBox.Show("Usuario eliminado");
                    usuarioEncontrado = true;
                }
            }
            if (!usuarioEncontrado)
            {
                MessageBox.Show("No hay ningun usuario registrado con ese DNI");
            }
        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {
          
        }
    }
}
