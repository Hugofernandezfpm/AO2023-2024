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

            string producto1 = listaProductos2[6];
            string producto2 = listaProductos2[13];
            //string producto3 = listaProductos2[20];
            //string producto4 = listaProductos2[27];
            //string producto5 = listaProductos[6];
            //string producto6 = listaProductos[13];
            //string producto7 = listaProductos[20];
            //string producto8 = listaProductos[27];

            //int producto9 = Convert.ToInt32(producto1);
            //int producto10 = Convert.ToInt32(producto2);
            //int producto11 = Convert.ToInt32(producto3);
            //int producto12 = Convert.ToInt32(producto4);
            //int producto13 = Convert.ToInt32(producto5);
            //int producto14 = Convert.ToInt32(producto6);
            //int producto15 = Convert.ToInt32(producto7);
            //int producto16 = Convert.ToInt32(producto8);



            if (producto1 != "")
            {
                producto1 = listaProductos2[6];
            }
            else
            {
                producto1 += 0;
            }

            if (producto2 != "")
            {
                producto2 = listaProductos2[13];
            }
            else
            {
                producto2 += 0;
            }

            txtBox_Total_Ordenadores.Text = producto1 + producto2;

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
