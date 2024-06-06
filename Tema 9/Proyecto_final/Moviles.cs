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
    public partial class Moviles : Form
    {
        public Moviles()
        {
            InitializeComponent();
        }

        private void pictureBox_Movil_1_Click(object sender, EventArgs e)
        {
            Info_Producto5_Movil info_Producto5_Movil = new Info_Producto5_Movil();
            info_Producto5_Movil.Show();
        }

        private void pictureBox_Movil_2_Click(object sender, EventArgs e)
        {
            Info_Producto6_Movil info_Producto6_Movil = new Info_Producto6_Movil();
            info_Producto6_Movil.Show();
        }

        private void pictureBox_Movil_3_Click(object sender, EventArgs e)
        {
            Info_Producto7_Movil info_Producto7_Movil = new Info_Producto7_Movil();
            info_Producto7_Movil.Show();
        }

        private void pictureBox_Movil_4_Click(object sender, EventArgs e)
        {
            Info_Producto8_Movil info_Producto8_Movil = new Info_Producto8_Movil();
            info_Producto8_Movil.Show();
        }

        private void Moviles_Load(object sender, EventArgs e)
        {
            pictureBox_Movil_1.Visible = true;
            pictureBox_Movil_2.Visible = true;
            pictureBox_Movil_3.Visible = true;
            pictureBox_Movil_4.Visible = true;
        }

        private void radioBtn_Camara_Todos_Moviles_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Camara_Todos_Moviles.Checked)
            {
                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }


                }
            }

            else if (radioBtn_Camara_0a100_Moviles.Checked)
            {

                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }


                }

            }

            else if (radioBtn_Camara_100a200_Moviles.Checked)
            {
                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
            }
        }

        private void radioBtn_Camara_0a100_Moviles_CheckedChanged(object sender, EventArgs e)
        {
          

            if (radioBtn_Camara_0a100_Moviles.Checked)
            {

                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }


                }

            }
        }

        private void radioBtn_Camara_100a200_Moviles_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Camara_100a200_Moviles.Checked)
            {
                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
            }
        }

        private void comboBoxRango_De_Precios_Movil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioBtn_Camara_Todos_Moviles.Checked)
            {
                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }


                }
            }

            else if (radioBtn_Camara_0a100_Moviles.Checked)
            {

                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }


                }

            }

            else if (radioBtn_Camara_100a200_Moviles.Checked)
            {
                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
            }
        }

        private void comboBox_Procesadores_Movil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioBtn_Camara_Todos_Moviles.Checked)
            {
                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }


                }
            }

            else if (radioBtn_Camara_0a100_Moviles.Checked)
            {

                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = true;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = true;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = true;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = true;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = true;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }


                }

            }

            else if (radioBtn_Camara_100a200_Moviles.Checked)
            {
                if (comboBoxRango_De_Precios_Movil.Text == "Todos")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }

                }
                else if (comboBoxRango_De_Precios_Movil.Text == "0-200")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Movil.Text == "200-300")
                {
                    pictureBox_Movil_1.Visible = true;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;

                    if (comboBox_Procesadores_Movil.Text == "Todos")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Snapdragon")
                    {
                        pictureBox_Movil_1.Visible = true;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Movil.Text == "Mediatek")
                    {
                        pictureBox_Movil_1.Visible = false;
                        pictureBox_Movil_2.Visible = false;
                        pictureBox_Movil_3.Visible = false;
                        pictureBox_Movil_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Movil.Text == "300-400")
                {
                    pictureBox_Movil_1.Visible = false;
                    pictureBox_Movil_2.Visible = false;
                    pictureBox_Movil_3.Visible = false;
                    pictureBox_Movil_4.Visible = false;
                }
            }
        }

        private void btn_Buscar_Codigo_Movil_Click(object sender, EventArgs e)
        {
            if (txtBox_Buscar_Por_Codigo_Movil.Text == "897654321")
            {
                Info_Producto5_Movil producto5 = new Info_Producto5_Movil();
                producto5.Show();
            }
            else if (txtBox_Buscar_Por_Codigo_Movil.Text == "798654321")
            {
                Info_Producto6_Movil producto6 = new Info_Producto6_Movil();
                producto6.Show();
            }
            else if (txtBox_Buscar_Por_Codigo_Movil.Text == "698754321")
            {
                Info_Producto7_Movil producto7 = new Info_Producto7_Movil();
                producto7.Show();
            }
            else if (txtBox_Buscar_Por_Codigo_Movil.Text == "598764321")
            {
                Info_Producto8_Movil producto8 = new Info_Producto8_Movil();
                producto8.Show();
            }
            else
            {
                if (txtBox_Buscar_Por_Codigo_Movil.Text == "")
                {
                    MessageBox.Show("Debes escribir un codigo");
                }
                else
                {
                    MessageBox.Show("El codigo no existe o no es valido");
                }
            }

            txtBox_Buscar_Por_Codigo_Movil.Clear();

        }    
    }
        
}
