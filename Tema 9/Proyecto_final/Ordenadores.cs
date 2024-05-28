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

        private void Ordenadores_Load(object sender, EventArgs e)
        {
            pictureBox_PC_1.Visible = true;
            pictureBox_PC_2.Visible = true;
            pictureBox_PC_3.Visible = true;
            pictureBox_PC_4.Visible = true;
        }

        private void radioBtn_SDD_ordenador_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_SDD_ordenador.Checked)
            {
                pictureBox_PC_1.Visible = true;
                pictureBox_PC_2.Visible = true;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;
            }
            else
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = true;
                pictureBox_PC_4.Visible = true;
            }

            if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
            {
                pictureBox_PC_1.Visible = true;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = true;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
            {
                pictureBox_PC_1.Visible = true;
                pictureBox_PC_2.Visible = true;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

        }
        private void radioBtn_HDD_ordenador_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_HDD_ordenador.Checked)
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = true;
                pictureBox_PC_4.Visible = true;
            }
            else
            {
                pictureBox_PC_1.Visible = true;
                pictureBox_PC_2.Visible = true;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;
            }

            if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = true;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = true;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = true;
                pictureBox_PC_4.Visible = true;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;
                }
            }


        }

       

        private void radioButton_SDDyHDD_Ordenador_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_PC_1.Visible = true;
            pictureBox_PC_2.Visible = true;
            pictureBox_PC_3.Visible = true;
            pictureBox_PC_4.Visible = true;

            if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = true;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = true;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;
                }
            }
            else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
            {
                pictureBox_PC_1.Visible = true;
                pictureBox_PC_2.Visible = false;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
            {
                pictureBox_PC_1.Visible = false;
                pictureBox_PC_2.Visible = true;
                pictureBox_PC_3.Visible = false;
                pictureBox_PC_4.Visible = false;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }

            }
            else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
            {
                pictureBox_PC_1.Visible = true;
                pictureBox_PC_2.Visible = true;
                pictureBox_PC_3.Visible = true;
                pictureBox_PC_4.Visible = true;

                if (comboBox_Procesadores_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;
                }
            }



        }

        private void comboBoxRango_De_Precios_Ordenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton_SDDyHDD_Ordenador.Checked)
            {
                if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;
                }
            }

            else if (radioBtn_SDD_ordenador.Checked)
            {
                if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
            }

            else if (radioBtn_HDD_ordenador.Checked)
            {
                if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;
                }
            }
        }

        private void comboBox_Procesadores_Ordenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton_SDDyHDD_Ordenador.Checked)
            {
                if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;
                    
                    if(comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = true;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = true;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = true;
                    }
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = true;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = true;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;
                }
                else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;
                }
            }
            else if (radioBtn_SDD_ordenador.Checked)
            {
                if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if(comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = true;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = true;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = true;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = true;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = true;
                    pictureBox_PC_2.Visible = true;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = true;
                        pictureBox_PC_2.Visible = true;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = true;
                        pictureBox_PC_2.Visible = true;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }
            }
            else if (radioBtn_HDD_ordenador.Checked)
            {
                if (comboBoxRango_De_Precios_Ordenador.Text == "0-200")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = false;

                      if(comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = true;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = true;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "200-500")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = true;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = true;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "500-1000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "1000-2000")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = false;
                    pictureBox_PC_4.Visible = false;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                }

                else if (comboBoxRango_De_Precios_Ordenador.Text == "Todos")
                {
                    pictureBox_PC_1.Visible = false;
                    pictureBox_PC_2.Visible = false;
                    pictureBox_PC_3.Visible = true;
                    pictureBox_PC_4.Visible = true;

                    if (comboBox_Procesadores_Ordenador.Text == "Todos")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = true;
                        pictureBox_PC_4.Visible = true;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "ADM")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = false;
                        pictureBox_PC_4.Visible = false;
                    }
                    else if (comboBox_Procesadores_Ordenador.Text == "Intel")
                    {
                        pictureBox_PC_1.Visible = false;
                        pictureBox_PC_2.Visible = false;
                        pictureBox_PC_3.Visible = true;
                        pictureBox_PC_4.Visible = true;
                    }
                }
            }
        }

        private void btn_Buscar_Codigo_Ordenador_Click(object sender, EventArgs e)
        {
           if (txtBox_Buscar_Por_Codigo_Ordenador.Text == "987654321")
            {
                Info_Producto producto = new Info_Producto();
                producto.Show();
            }
           else if (txtBox_Buscar_Por_Codigo_Ordenador.Text == "123456789")
            {
                Info_Producto2 producto2 = new Info_Producto2();
                producto2.Show();
            }
            else if (txtBox_Buscar_Por_Codigo_Ordenador.Text == "213456789")
            {
                Info_Producto3 producto3 = new Info_Producto3();
                producto3.Show();
            }
            else if (txtBox_Buscar_Por_Codigo_Ordenador.Text == "312456789")
            {
                Info_Producto4 producto4 = new Info_Producto4();
                producto4.Show();
            }
            else
            {
                if (txtBox_Buscar_Por_Codigo_Ordenador.Text == "")
                {
                    MessageBox.Show("Debes escribir un cidigo");
                }
                else
                {
                    MessageBox.Show("El codigo no existe o no es valido");
                }
            }

            txtBox_Buscar_Por_Codigo_Ordenador.Clear();
        }
    }
}
