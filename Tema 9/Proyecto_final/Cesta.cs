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

            StreamReader registroProductos_Moviles = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", true);
            string item2 = registroProductos_Moviles.ReadLine();
            registroProductos_Moviles.Close();
            string[] listaProductos2 = item2.Split(',');

            txtBoxCodigoMovil.Text = listaProductos2[0];
            txtBoxMarcaMovil.Text = listaProductos2[1];
            txtBoxModeloMovil.Text = listaProductos2[2];
            txtBoxRAMMovil.Text = listaProductos2[3];
            txtBoxCamaraMovil.Text = listaProductos2[4];
            txtBoxProcesadorMovil.Text = listaProductos2[5];
            txtBoxPrecioMovil.Text = listaProductos2[6];

        }

        private void btn_Siguiente_Ordenadores_Click(object sender, EventArgs e)
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

        private void btn_Anterior_Ordenadores_Click(object sender, EventArgs e)
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

        private void btn_Siguiente_Moviles_Click(object sender, EventArgs e)
        {
            StreamReader registroProductos_Moviles = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", true);
            string item2 = registroProductos_Moviles.ReadLine();
            registroProductos_Moviles.Close();
            string[] listaProductos2 = item2.Split(',');

            if (contador == 0)
            {
                txtBoxCodigoMovil.Text = listaProductos2[7];
                txtBoxMarcaMovil.Text = listaProductos2[8];
                txtBoxModeloMovil.Text = listaProductos2[9];
                txtBoxRAMMovil.Text = listaProductos2[10];
                txtBoxCamaraMovil.Text = listaProductos2[11];
                txtBoxProcesadorMovil.Text = listaProductos2[12];
                txtBoxPrecioMovil.Text = listaProductos2[13];

                contador = 1;
            }
            else if (contador == 1)
            {

                txtBoxCodigoMovil.Text = listaProductos2[14];
                txtBoxMarcaMovil.Text = listaProductos2[15];
                txtBoxModeloMovil.Text = listaProductos2[16];
                txtBoxRAMMovil.Text = listaProductos2[17];
                txtBoxCamaraMovil.Text = listaProductos2[18];
                txtBoxProcesadorMovil.Text = listaProductos2[19];
                txtBoxPrecioMovil.Text = listaProductos2[20];

                contador = 2;
            }
            else if (contador == 2)
            {

                txtBoxCodigoMovil.Text = listaProductos2[21];
                txtBoxMarcaMovil.Text = listaProductos2[22];
                txtBoxModeloMovil.Text = listaProductos2[23];
                txtBoxRAMMovil.Text = listaProductos2[24];
                txtBoxCamaraMovil.Text = listaProductos2[25];
                txtBoxProcesadorMovil.Text = listaProductos2[26];
                txtBoxPrecioMovil.Text = listaProductos2[27];

                contador = 3;
            }
            else
            {
                txtBoxCodigoMovil.Text = listaProductos2[0];
                txtBoxMarcaMovil.Text = listaProductos2[1];
                txtBoxModeloMovil.Text = listaProductos2[2];
                txtBoxRAMMovil.Text = listaProductos2[3];
                txtBoxCamaraMovil.Text = listaProductos2[4];
                txtBoxProcesadorMovil.Text = listaProductos2[5];
                txtBoxPrecioMovil.Text = listaProductos2[6];

                contador = 0;
            }

        }

        private void btn_Anterior_Moviles_Click(object sender, EventArgs e)
        {
            StreamReader registroProductos_Moviles = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", true);
            string item2 = registroProductos_Moviles.ReadLine();
            registroProductos_Moviles.Close();
            string[] listaProductos2 = item2.Split(',');
            
            if (contador == 1)
            {
                txtBoxCodigoMovil.Text = listaProductos2[0];
                txtBoxMarcaMovil.Text = listaProductos2[1];
                txtBoxModeloMovil.Text = listaProductos2[2];
                txtBoxRAMMovil.Text = listaProductos2[3];
                txtBoxCamaraMovil.Text = listaProductos2[4];
                txtBoxProcesadorMovil.Text = listaProductos2[5];
                txtBoxPrecioMovil.Text = listaProductos2[6];

                contador = 2;
            }
            else if (contador == 2)
            {

                txtBoxCodigoMovil.Text = listaProductos2[7];
                txtBoxMarcaMovil.Text = listaProductos2[8];
                txtBoxModeloMovil.Text = listaProductos2[9];
                txtBoxRAMMovil.Text = listaProductos2[10];
                txtBoxCamaraMovil.Text = listaProductos2[11];
                txtBoxProcesadorMovil.Text = listaProductos2[12];
                txtBoxPrecioMovil.Text = listaProductos2[13];

                contador = 3;
            }
            else if (contador == 3)
            {

                txtBoxCodigoMovil.Text = listaProductos2[14];
                txtBoxMarcaMovil.Text = listaProductos2[15];
                txtBoxModeloMovil.Text = listaProductos2[16];
                txtBoxRAMMovil.Text = listaProductos2[17];
                txtBoxCamaraMovil.Text = listaProductos2[18];
                txtBoxProcesadorMovil.Text = listaProductos2[19];
                txtBoxPrecioMovil.Text = listaProductos2[20];

                contador = 4;
            }
            else
            {
                txtBoxCodigoMovil.Text = listaProductos2[21];
                txtBoxMarcaMovil.Text = listaProductos2[22];
                txtBoxModeloMovil.Text = listaProductos2[23];
                txtBoxRAMMovil.Text = listaProductos2[24];
                txtBoxCamaraMovil.Text = listaProductos2[25];
                txtBoxProcesadorMovil.Text = listaProductos2[26];
                txtBoxPrecioMovil.Text = listaProductos2[27];

                contador = 3;
            }
        }
    }
}
