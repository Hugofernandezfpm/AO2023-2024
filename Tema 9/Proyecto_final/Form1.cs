using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenadores_Click(object sender, EventArgs e)
        {
            Ordenadores ordenadores = new Ordenadores();
            ordenadores.Show();
        }

        private void btnMoviles_Click(object sender, EventArgs e)
        {
            Moviles movies = new Moviles();
            movies.Show();
        }
    }
}
