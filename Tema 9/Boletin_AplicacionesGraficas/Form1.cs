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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ejerciciosSeleccionadosClick(object sender, EventArgs e)
        {
            //vamos a asignar un evento de click a cada ejercicio con la
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int ejerciciosNumeros = Convert.ToInt32(item.Tag);
            switch(ejerciciosNumeros)
            {
                case 1:

                    Ejercicio1 ejercicio1 = new Ejercicio1();
                    ejercicio1.Show();

                    break;

                case 2:

                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    ejercicio2.Show();

                    break;

                case 3:

                    Ejercicio3 ejercicio3 = new Ejercicio3();
                    ejercicio3.Show();

                    break;

                case 4:

                    Ejercicio4 ejercicio4 = new Ejercicio4();
                    ejercicio4.Show();
                        
                    break;

                case 5:

                    Ejercicio5 ejercicio5 = new Ejercicio5();  
                    ejercicio5.Show();

                    break;

                    case 6:

                    Ejercicio6 ejercicio6 = new Ejercicio6();
                    ejercicio6.Show();

                    break;

                case 7:

                    Ejercicio7 ejercicio7 = new Ejercicio7();
                    ejercicio7.Show();
                        
                   break;

                case 8:

                    Ejercicio8 ejercicio8 = new Ejercicio8();
                    ejercicio8.Show();

                    break;
                    
                    
            }
        }
    }
}
