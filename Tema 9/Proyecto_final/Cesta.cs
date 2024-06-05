using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        int i = 0;
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
            

            if (item != null)
            {
                string[] listaProductos = item.Split(',');
                txtBoxCodigoOrdenador.Text = listaProductos[0];
                txtBoxMarcaOrdenador.Text = listaProductos[1];
                txtBoxModeloOrdenador.Text = listaProductos[2];
                txtBoxRAMOrdenador.Text = listaProductos[3];
                txtBoxSSDoHDDOrdenador.Text = listaProductos[4];
                txtBoxProcesadorOrdenador.Text = listaProductos[5];
                txtBoxPrecioOrdenador.Text = listaProductos[6];
            }
            else
            {
                MessageBox.Show("La lista de ordenadores esta vacia");
            }

            StreamReader registroProductos_Moviles = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", true);
            string item2 = registroProductos_Moviles.ReadLine();
            registroProductos_Moviles.Close();
            
            
            if (item2 != null)
            {
                string[] listaProductos2 = item2.Split(',');
                txtBoxCodigoMovil.Text = listaProductos2[0];
                txtBoxMarcaMovil.Text = listaProductos2[1];
                txtBoxModeloMovil.Text = listaProductos2[2];
                txtBoxRAMMovil.Text = listaProductos2[3];
                txtBoxCamaraMovil.Text = listaProductos2[4];
                txtBoxProcesadorMovil.Text = listaProductos2[5];
                txtBoxPrecioMovil.Text = listaProductos2[6];
            }
            else
            {
                MessageBox.Show("La lista de moviles esta vacia");
            }

            if (txtBoxModeloOrdenador.Text == "i5-12400F/GTX1650")
            {
                pictureBoxVoltier.Visible = true;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "e7-31460G/GTX1650")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = true;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "e4-12330F/GTX1340")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = true;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "i5-55400F/GTX14330")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = true;
            }
            else
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }

            if (txtBoxModeloMovil.Text == "Realme C67")
            {
                pictureBoxRealmeC67.Visible = true;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }
            else if (txtBoxModeloMovil.Text == "POCO X6 pro")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = true;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }
            else if (txtBoxModeloMovil.Text == "Realme 6i")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = true;
            }
            else if (txtBoxModeloMovil.Text == "POCO X6")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = true;
                pictureBoxRealme6i.Visible = false;
            }
            else
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }
          
            

        }

        private void btn_Siguiente_Ordenadores_Click(object sender, EventArgs e)
        {
            StreamReader registroProductos = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductos.txt", true);
            string item = registroProductos.ReadLine();
            registroProductos.Close();
            string[] listaProductos = item.Split(',');

            if (txtBoxModeloOrdenador.Text == "i5-12400F/GTX1650")
            {
                pictureBoxVoltier.Visible = true;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "e7-31460G/GTX1650")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = true;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "e4-12330F/GTX1340")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = true;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "i5-55400F/GTX14330")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = true;
            }
            else
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }

            



            if (contador == 0)
            {
                if (listaProductos.Count() < 8 || listaProductos[7] == " ")
                {
                    MessageBox.Show("no hay mas productos en la lista");
                }
                else
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

            if (txtBoxModeloOrdenador.Text == "i5-12400F/GTX1650")
            {
                pictureBoxVoltier.Visible = true;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "e7-31460G/GTX1650")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = true;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "e4-12330F/GTX1340")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = true;
                pictureBoxDELL7010.Visible = false;
            }
            else if (txtBoxModeloOrdenador.Text == "i5-55400F/GTX14330")
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = true;
            }
            else
            {
                pictureBoxVoltier.Visible = false;
                pictureBoxPCCOM.Visible = false;
                pictureBoxHPDESKTOP.Visible = false;
                pictureBoxDELL7010.Visible = false;
            }


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

                if (listaProductos.Count() < 8 || listaProductos[7] == " ")
                {
                    MessageBox.Show("no hay mas productos en la lista");
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

        private void btn_Siguiente_Moviles_Click(object sender, EventArgs e)
        {
            StreamReader registroProductos_Moviles = new StreamReader(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", true);
            string item2 = registroProductos_Moviles.ReadLine();
            registroProductos_Moviles.Close();
            string[] listaProductos2 = item2.Split(',');

            if (txtBoxModeloMovil.Text == "Realme C67")
            {
                pictureBoxRealmeC67.Visible = true;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }
            else if (txtBoxModeloMovil.Text == "POCO X6 pro")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = true;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }
            else if (txtBoxModeloMovil.Text == "Realme 6i")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = true;
            }
            else if (txtBoxModeloMovil.Text == "POCO X6")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = true;
                pictureBoxRealme6i.Visible = false;
            }
            else
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }

            if (contador == 0)
            {
                if (listaProductos2.Count() < 8 || listaProductos2[7] == " ") 
                {
                    MessageBox.Show("no hay mas productos en la lista");
                }
                else
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

            if (txtBoxModeloMovil.Text == "Realme C67")
            {
                pictureBoxRealmeC67.Visible = true;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }
            else if (txtBoxModeloMovil.Text == "POCO X6 pro")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = true;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }
            else if (txtBoxModeloMovil.Text == "Realme 6i")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = true;
            }
            else if (txtBoxModeloMovil.Text == "POCO X6")
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = true;
                pictureBoxRealme6i.Visible = false;
            }
            else
            {
                pictureBoxRealmeC67.Visible = false;
                pictureBoxPocox6pro.Visible = false;
                pictureBoxPocoX6.Visible = false;
                pictureBoxRealme6i.Visible = false;
            }

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
                if (listaProductos2.Count() < 22 || listaProductos2[21] == " ")
                {
                    MessageBox.Show("no hay mas productos en la lista");
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

        private void btn_Añadir_Nuevo_Ordenador_Click(object sender, EventArgs e)
        {
            if (txtBox_Codigo_Ordenador_Nuevo.Text != "" && txtBox_Marca_Ordenador_Nuevo.Text != "" && txtBox_Modelo_Ordenador_Nuevo.Text != "" && txtBox_Ram_Ordenador_Nuevo.Text != "" && txtBox_SDDoHDD_Ordenador_Nuevo.Text != "" && txtBox_Procesador_Ordenador_Nuevo.Text != "" && txtBox_Precio_Ordenador_Nuevo.Text != "" ) 
            {
                listViewProducto_Ordenador_Nuevo.Items.Add(txtBox_Codigo_Ordenador_Nuevo.Text);
                listViewProducto_Ordenador_Nuevo.Items[i].SubItems.Add(txtBox_Marca_Ordenador_Nuevo.Text);
                listViewProducto_Ordenador_Nuevo.Items[i].SubItems.Add(txtBox_Modelo_Ordenador_Nuevo.Text);
                listViewProducto_Ordenador_Nuevo.Items[i].SubItems.Add(txtBox_Ram_Ordenador_Nuevo.Text);
                listViewProducto_Ordenador_Nuevo.Items[i].SubItems.Add(txtBox_SDDoHDD_Ordenador_Nuevo.Text);
                listViewProducto_Ordenador_Nuevo.Items[i].SubItems.Add(txtBox_Procesador_Ordenador_Nuevo.Text);
                listViewProducto_Ordenador_Nuevo.Items[i].SubItems.Add(txtBox_Precio_Ordenador_Nuevo.Text);

                txtBox_Codigo_Ordenador_Nuevo.Clear();
                txtBox_Marca_Ordenador_Nuevo.Clear();
                txtBox_Modelo_Ordenador_Nuevo.Clear();
                txtBox_Ram_Ordenador_Nuevo.Clear();
                txtBox_SDDoHDD_Ordenador_Nuevo.Clear();
                txtBox_Procesador_Ordenador_Nuevo.Clear();
                txtBox_Precio_Ordenador_Nuevo.Clear();

            }

            else
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
        }

        private void btn_Añadir_Nuevo_Movil_Click(object sender, EventArgs e)
        {
            if (txtBox_Codigo_Movil_Nuevo.Text != "" && txtBox_Marca_Movil_Nuevo.Text != "" && txtBox_Modelo_Movil_Nuevo.Text != "" && txtBox_Ram_Movil_Nuevo.Text != "" && txtBox_Camara_Movil_Nuevo.Text != "" && txtBox_Procesador_Movil_Nuevo.Text != "" && txtBox_Precio_Movil_Nuevo.Text != "")
            {

                listViewProducto_Movil_Nuevo.Items.Add(txtBox_Codigo_Movil_Nuevo.Text);
                listViewProducto_Movil_Nuevo.Items[i].SubItems.Add(txtBox_Marca_Movil_Nuevo.Text);
                listViewProducto_Movil_Nuevo.Items[i].SubItems.Add(txtBox_Modelo_Movil_Nuevo.Text);
                listViewProducto_Movil_Nuevo.Items[i].SubItems.Add(txtBox_Ram_Movil_Nuevo.Text);
                listViewProducto_Movil_Nuevo.Items[i].SubItems.Add(txtBox_Camara_Movil_Nuevo.Text);
                listViewProducto_Movil_Nuevo.Items[i].SubItems.Add(txtBox_Procesador_Movil_Nuevo.Text);
                listViewProducto_Movil_Nuevo.Items[i].SubItems.Add(txtBox_Precio_Movil_Nuevo.Text);

                txtBox_Codigo_Movil_Nuevo.Clear();
                txtBox_Marca_Movil_Nuevo.Clear();
                txtBox_Modelo_Movil_Nuevo.Clear();
                txtBox_Ram_Movil_Nuevo.Clear();
                txtBox_Camara_Movil_Nuevo.Clear();
                txtBox_Procesador_Movil_Nuevo.Clear();
                txtBox_Precio_Movil_Nuevo.Clear();

                i += +1;

            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listViewProducto_Ordenador_Nuevo.SelectedItems.Clear();
        }
        //String codigoEliminar;
        private void listViewProducto_Ordenador_Nuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (listViewProducto_Ordenador_Nuevo.SelectedItems.Count != 0)
        //    {
        //        codigoEliminar = listViewProducto_Ordenador_Nuevo.SelectedItems[0].SubItems[0].Text;
        //        //int indice = listViewProducto_Ordenador_Nuevo.CheckedItems[0].Index;
        //        DialogResult respuesta = MessageBox.Show("Desea eliminar","Cuidado",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if(respuesta == DialogResult.OK)
        //        {
                    

        //        }
        //    }
        }
    }
}
