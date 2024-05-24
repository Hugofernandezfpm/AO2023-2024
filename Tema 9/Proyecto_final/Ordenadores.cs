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
    public partial class Ordenadores : Form
    {
        public Ordenadores()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Info_Producto producto = new Info_Producto();
            producto.Show();
        }

        private void pictureBox_PC_2_Click(object sender, EventArgs e)
        {
            Info_Producto2 producto2 = new Info_Producto2();
            producto2.Show();
        }

        private void pictureBox_PC_3_Click(object sender, EventArgs e)
        {
            Info_Producto3 producto3 = new Info_Producto3();
            producto3.Show();
        }

        private void pictureBox_PC_4_Click(object sender, EventArgs e)
        {
            Info_Producto4 producto4 = new Info_Producto4();
            producto4.Show();
        }
    }
}
