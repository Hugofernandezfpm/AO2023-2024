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
    public partial class Ejercicio2 : Form
    {
        public static String asignatura;
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void radioBtn1ºGMI_CheckedChanged(object sender, EventArgs e)
        {
           if(radioBtn1ºGMI.Checked)
            {
                listBoxAsignaturas.Items.Add("Progrmacion en C#");
                listBoxAsignaturas.Items.Add("Fol");
                listBoxAsignaturas.Items.Add("Montaje");
                listBoxAsignaturas.Items.Add("Ofimatica");
                listBoxAsignaturas.Items.Add("Sistemas Operativos");
                listBoxAsignaturas.Items.Add("Redes");
            }
            else
            {
                listBoxAsignaturas.Items.Clear();
            }
            
            
            
        }

        private void radioBtn2ºGMI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn2ºGMI.Checked)
            {
                listBoxAsignaturas.Items.Add("Progrmacion en Java");
                listBoxAsignaturas.Items.Add("Montaje");
                listBoxAsignaturas.Items.Add("Ofimatica");
                listBoxAsignaturas.Items.Add("Sistemas Operativos");
                listBoxAsignaturas.Items.Add("Redes");
                listBoxAsignaturas.Items.Add("Cyber Seguridad");
            }
            else
            {
                listBoxAsignaturas.Items.Clear();
            }
        }

        private void listBoxAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignatura = listBoxAsignaturas.SelectedItem.ToString();
            Profesores profesores = new Profesores();
            profesores.ShowDialog();
        }
    }
}
