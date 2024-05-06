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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }
        int contador = 20;



        private void Ejercicio7_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador--;
            
            if (contador >= 10)
            {
                pictureBox1.Left += 5;
            }
            else if (contador <= 10 || contador <= 1) 
            {
                pictureBox1.Left -= 5;
            }
            
         

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            contador = 20;
            contador--;
            pictureBox1.Left = 0;

            if (contador >= 10)
            {
                pictureBox1.Left += 5;
            }
            else if (contador <= 10 || contador <= 1)
            {
                pictureBox1.Left -= 5;
            }
        }
    }
}
