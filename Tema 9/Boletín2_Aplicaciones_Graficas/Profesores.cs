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

                txtBoxProfesores.Text = "Dani";
            }
            else if (asignaturaSeleccionada == "Programacion en C#")
            {
                txtBoxProfesores.Text = "Ramon";
            }
            else if (asignaturaSeleccionada == "Montaje")
            {
                txtBoxProfesores.Text = "Alberto";
            }
            else if (asignaturaSeleccionada == "Ofimatica")
            {
                txtBoxProfesores.Text = "Martin";
            }
            else if (asignaturaSeleccionada == "Sistemas Operativos")
            {
                txtBoxProfesores.Text = "Enrique";
            }
            else if (asignaturaSeleccionada == "Redes")
            {
                txtBoxProfesores.Text = "Fran";
            }
            else if (asignaturaSeleccionada == "Programacion en Java")
            {
                txtBoxProfesores.Text = "Ramon";
            }
            else if (asignaturaSeleccionada == "Cyber Seguridad")
            {
                txtBoxProfesores.Text = "Fran";
            }
        }
    }
}
