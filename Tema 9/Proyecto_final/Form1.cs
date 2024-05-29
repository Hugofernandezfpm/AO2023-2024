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

        private void btnCesta_Click(object sender, EventArgs e)
        {

            StreamReader registroProductos = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductos.txt", true);
            string item = registroProductos.ReadLine();
            registroProductos.Close();

            StreamReader registroProductos_Moviles = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", true);
            string item2 = registroProductos_Moviles.ReadLine();
            registroProductos_Moviles.Close();

            if(item != null && item2 != null)
            {
                Cesta cesta = new Cesta();
                cesta.Show();
            }
            else
            {
                MessageBox.Show("Una o varias listas estan vacias");
            }
           
        }

        private void btnEleminar_Todos_Los_Productos_Click(object sender, EventArgs e)
        {
            StreamWriter registroProductos = new StreamWriter(Directory.GetCurrentDirectory() + "\\registroProductos.txt", false);
            registroProductos.Close();

            StreamWriter registroProductos_Moviles = new StreamWriter(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", false);
            registroProductos_Moviles.Close();

            MessageBox.Show("Productos eliminados con exito");
            
        }
    }
}
