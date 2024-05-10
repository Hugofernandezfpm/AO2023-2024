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
    public partial class Profesores : Form
    {
        string asignaturaSeleccionada = Ejercicio2.asignatura;
        
        public Profesores()
        {
            InitializeComponent();
            if (asignaturaSeleccionada == "Fol")
            {

                txtBoxProfesores.Text = "Dani, Derechos del trabajador";
            }
            else if (asignaturaSeleccionada == "Programacion en C#")
            {
                txtBoxProfesores.Text = "Ramon, Formularios";
            }
            else if (asignaturaSeleccionada == "Montaje")
            {
                txtBoxProfesores.Text = "Alberto, Impresora 3D";
            }
            else if (asignaturaSeleccionada == "Ofimatica")
            {
                txtBoxProfesores.Text = "Martin, Tablas";
            }
            else if (asignaturaSeleccionada == "Sistemas Operativos")
            {
                txtBoxProfesores.Text = "Enrique, Gestion de Paquetes";
            }
            else if (asignaturaSeleccionada == "Redes")
            {
                txtBoxProfesores.Text = "Fran, Subredes";
            }
            else if (asignaturaSeleccionada == "Programacion en Java")
            {
                txtBoxProfesores.Text = "Ramon, Colecciones";
            }
            else if (asignaturaSeleccionada == "Cyber Seguridad")
            {
                txtBoxProfesores.Text = "Fran, Protocolos de Seguridad";
            }
        }
    }
}
