using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Cesta : Form
    {
        public Cesta()
        {
            InitializeComponent();
        }

        private void Cesta_Load(object sender, EventArgs e)
        {
            StreamReader registroProductos = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductos.txt", true);
            string item = registroProductos.ReadLine();
            registroProductos.Close();
            string[] listaProductos = item.Split(',');


            txtBoxCodigoOrdenador.Text = listaProductos[0];
            txtBoxMarcaOrdenador.Text = listaProductos[1];
            txtBoxModeloOrdenador.Text = listaProductos[2];
            txtBoxRAMOrdenador.Text = listaProductos[3];
            txtBoxSSDoHDDOrdenador.Text = listaProductos[4];
            txtBoxProcesadorOrdenador.Text = listaProductos[5];
            txtBoxPrecioOrdenador.Text = listaProductos[6];
        }
    }
}
