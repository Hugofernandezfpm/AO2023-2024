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
        int contador = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader registroProductos = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductos.txt", true);
            string item = registroProductos.ReadLine();
            registroProductos.Close();
            string[] listaProductos = item.Split(',');

           

            if (contador == 0)
            {
                txtBoxCodigoOrdenador.Text = listaProductos[7];
                txtBoxMarcaOrdenador.Text = listaProductos[8];
                txtBoxModeloOrdenador.Text = listaProductos[9];
                txtBoxRAMOrdenador.Text = listaProductos[10];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[11];
                txtBoxProcesadorOrdenador.Text = listaProductos[12];
                txtBoxPrecioOrdenador.Text = listaProductos[13];

                contador = 1;
            }
            else if (contador == 1)
            {
                txtBoxCodigoOrdenador.Text = listaProductos[14];
                txtBoxMarcaOrdenador.Text = listaProductos[15];
                txtBoxModeloOrdenador.Text = listaProductos[16];
                txtBoxRAMOrdenador.Text = listaProductos[17];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[18];
                txtBoxProcesadorOrdenador.Text = listaProductos[19];
                txtBoxPrecioOrdenador.Text = listaProductos[20];
                contador = 2;
            }
            else if (contador == 2)
            {
                txtBoxCodigoOrdenador.Text = listaProductos[21];
                txtBoxMarcaOrdenador.Text = listaProductos[22];
                txtBoxModeloOrdenador.Text = listaProductos[23];
                txtBoxRAMOrdenador.Text = listaProductos[24];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[25];
                txtBoxProcesadorOrdenador.Text = listaProductos[26];
                txtBoxPrecioOrdenador.Text = listaProductos[27];
                contador = 3;
            }
            else
            {
                txtBoxCodigoOrdenador.Text = listaProductos[0];
                txtBoxMarcaOrdenador.Text = listaProductos[1];
                txtBoxModeloOrdenador.Text = listaProductos[2];
                txtBoxRAMOrdenador.Text = listaProductos[3];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[4];
                txtBoxProcesadorOrdenador.Text = listaProductos[5];
                txtBoxPrecioOrdenador.Text = listaProductos[6];
                contador = 0;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamReader registroProductos = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductos.txt", true);
            string item = registroProductos.ReadLine();
            registroProductos.Close();
            string[] listaProductos = item.Split(',');


            if (contador == 1)
            {
                txtBoxCodigoOrdenador.Text = listaProductos[0];
                txtBoxMarcaOrdenador.Text = listaProductos[1];
                txtBoxModeloOrdenador.Text = listaProductos[2];
                txtBoxRAMOrdenador.Text = listaProductos[3];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[4];
                txtBoxProcesadorOrdenador.Text = listaProductos[5];
                txtBoxPrecioOrdenador.Text = listaProductos[6];
                 

                contador = 2;
            }
            else if (contador == 2)
            {
                txtBoxCodigoOrdenador.Text = listaProductos[7];
                txtBoxMarcaOrdenador.Text = listaProductos[8];
                txtBoxModeloOrdenador.Text = listaProductos[9];
                txtBoxRAMOrdenador.Text = listaProductos[10];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[11];
                txtBoxProcesadorOrdenador.Text = listaProductos[12];
                txtBoxPrecioOrdenador.Text = listaProductos[13];

                contador = 3;
            }
            else if (contador == 3)
            {
                txtBoxCodigoOrdenador.Text = listaProductos[14];
                txtBoxMarcaOrdenador.Text = listaProductos[15];
                txtBoxModeloOrdenador.Text = listaProductos[16];
                txtBoxRAMOrdenador.Text = listaProductos[17];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[18];
                txtBoxProcesadorOrdenador.Text = listaProductos[19];
                txtBoxPrecioOrdenador.Text = listaProductos[20];
                contador = 4;
            }
            else
            {
                txtBoxCodigoOrdenador.Text = listaProductos[21];
                txtBoxMarcaOrdenador.Text = listaProductos[22];
                txtBoxModeloOrdenador.Text = listaProductos[23];
                txtBoxRAMOrdenador.Text = listaProductos[24];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[25];
                txtBoxProcesadorOrdenador.Text = listaProductos[26];
                txtBoxPrecioOrdenador.Text = listaProductos[27];
                contador = 3;
            }
        }
    }
}
