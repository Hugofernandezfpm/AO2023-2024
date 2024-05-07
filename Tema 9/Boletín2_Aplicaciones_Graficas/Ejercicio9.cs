using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletín2_Aplicaciones_Graficas
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        double precioPrimerPlato;
        double precioSegundoPlato;
        double precioBebida;
        double precioPostre;
        double precioCafe;
        double totalCuenta;
        double totalCuentaConIva;
        double totalADevolver;

        private void radioBtnCrema_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            txtBoxPrecioPrimerPlato.Clear();
            comboBoxPrimerPlato.Text = "";
            comboBoxPrimerPlato.Items.Add("Champiñones");
            comboBoxPrimerPlato.Items.Add("Puerros");
            comboBoxPrimerPlato.Items.Add("Zanahoria");

   
        }
        private void radioBtnEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            txtBoxPrecioPrimerPlato.Clear();
            comboBoxPrimerPlato.Text = "";
            comboBoxPrimerPlato.Items.Add("Primavera");
            comboBoxPrimerPlato.Items.Add("Romana");
            comboBoxPrimerPlato.Items.Add("Cesar");
        }
        private void radioBtnEmpanada_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPrimerPlato.Items.Clear();
            txtBoxPrecioPrimerPlato.Clear();
            comboBoxPrimerPlato.Text = "";
            comboBoxPrimerPlato.Items.Add("Pulpo");
            comboBoxPrimerPlato.Items.Add("Zamburiñas");
            comboBoxPrimerPlato.Items.Add("Carne");
            comboBoxPrimerPlato.Items.Add("Choco");
        }

        private void comboBoxPrimerPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPrimerPlato.Text == "Champiñones")
            {
                precioPrimerPlato = 4;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Puerros")
            {
                precioPrimerPlato = 5;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Zanahoria")
            {
                precioPrimerPlato = 4.75;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Primavera")
            {
                precioPrimerPlato = 3;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Romana")
            {
                precioPrimerPlato = 4;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Cesar")
            {
                precioPrimerPlato = 4.5;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Pulpo")
            {
                precioPrimerPlato = 6;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Zamburiñas")
            {
                precioPrimerPlato = 7;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Carne")
            {
                precioPrimerPlato = 3;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
            else if (comboBoxPrimerPlato.Text == "Choco")
            {
                precioPrimerPlato = 3.5;
                txtBoxPrecioPrimerPlato.Text = precioPrimerPlato.ToString();
            }
        }

        private void radioBtnPescado_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSegundoPlato.Items.Clear();
            txtBoxPrecioSegundoPlato.Clear();
            comboBoxSegundoPlato.Text = "";
            comboBoxSegundoPlato.Items.Add("Merluza a la plancha");
            comboBoxSegundoPlato.Items.Add("Lenguado");
            comboBoxSegundoPlato.Items.Add("Besugo");
            comboBoxSegundoPlato.Items.Add("Bacalao al horno");
        }

        private void radioBtnCarne_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSegundoPlato.Items.Clear();
            txtBoxPrecioSegundoPlato.Clear();
            comboBoxSegundoPlato.Text = "";
            comboBoxSegundoPlato.Items.Add("Milanesa");
            comboBoxSegundoPlato.Items.Add("Chuleta");
            comboBoxSegundoPlato.Items.Add("San Jacobo");
            comboBoxSegundoPlato.Items.Add("Solomillo");
        }

        private void radioBtnPasta_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSegundoPlato.Items.Clear();
            txtBoxPrecioSegundoPlato.Clear();
            comboBoxSegundoPlato.Text = "";
            comboBoxSegundoPlato.Items.Add("Spaguetti Bolognesa");
            comboBoxSegundoPlato.Items.Add("Macarrones carbonara");
            comboBoxSegundoPlato.Items.Add("Trofie al pesto");
        }

        private void comboBoxSegundoPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSegundoPlato.Text == "Merluza a la plancha")
            {
                precioSegundoPlato = 4.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Lenguado")
            {
                precioSegundoPlato = 4.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Besugo")
            {
                precioSegundoPlato = 6;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Bacalao al horno")
            {
                precioSegundoPlato = 6;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Milanesa")
            {
                precioSegundoPlato = 4.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Chuleta")
            {
                precioSegundoPlato = 7.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "San Jacobo")
            {
                precioSegundoPlato = 4.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Solomillo")
            {
                precioSegundoPlato = 8.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Spaguetti Bolognesa")
            {
                precioSegundoPlato = 9;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Macarrones carbonara")
            {
                precioSegundoPlato = 9.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }
            else if (comboBoxSegundoPlato.Text == "Trofie al pesto")
            {
                precioSegundoPlato = 10.5;
                txtBoxPrecioSegundoPlato.Text = precioSegundoPlato.ToString();
            }



        }

        private void radioBtnAgua_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPrecioBebida.Text = "";
            precioBebida = 1;
            txtBoxPrecioBebida.Text = precioBebida.ToString();
        }

        private void radioBtnRefresco_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPrecioBebida.Text = "";
            precioBebida = 2.5;
            txtBoxPrecioBebida.Text = precioBebida.ToString();
        }

        private void radioBtnVino_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPrecioBebida.Text = "";
            precioBebida = 3.5;
            txtBoxPrecioBebida.Text = precioBebida.ToString();
        }

        private void radioBtnPostre_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPostre.Items.Clear();
            txtBoxPrecioPostreOCafe.Clear();
            comboBoxPostre.Text = "";
            comboBoxPostre.Items.Add("Fruta/Yogurt");
            comboBoxPostre.Items.Add("Brownie Chocolate con helado");
            comboBoxPostre.Items.Add("Tarta de Santiago");
            comboBoxPostre.Items.Add("Tarta semifria de chocolate y queso");

        }

        private void comboBoxPostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPostre.Text == "Fruta/Yogurt")
            {
                precioPostre = 1.5;
                txtBoxPrecioPostreOCafe.Text = precioPostre.ToString();
            }
            else if (comboBoxPostre.Text == "Brownie Chocolate con helado")
            {
                precioPostre = 3.5;
                txtBoxPrecioPostreOCafe.Text = precioPostre.ToString();
            }
            else if (comboBoxPostre.Text == "Tarta de Santiago")
            {
                precioPostre = 3.5;
                txtBoxPrecioPostreOCafe.Text = precioPostre.ToString();
            }
            else if (comboBoxPostre.Text == "Tarta semifria de chocolate y queso")
            {
                precioPostre = 3.5;
                txtBoxPrecioPostreOCafe.Text = precioPostre.ToString();
            }
        }

        private void radioBtnCafe_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCafe.Items.Clear();
            txtBoxPrecioPostreOCafe.Clear();
            comboBoxCafe.Text = "";
            comboBoxCafe.Items.Add("Con leche");
            comboBoxCafe.Items.Add("Cortado");
            comboBoxCafe.Items.Add("Solo");
            comboBoxCafe.Items.Add("Descafeinado");
        }

        private void comboBoxCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCafe.Text == "Con leche")
            {
                precioCafe = 1;
                txtBoxPrecioPostreOCafe.Text = precioCafe.ToString();
            }
            else if (comboBoxCafe.Text == "Cortado")
            {
                precioCafe = 1;
                txtBoxPrecioPostreOCafe.Text = precioCafe.ToString();
            }
            else if (comboBoxCafe.Text == "Solo")
            {
                precioCafe = 1;
                txtBoxPrecioPostreOCafe.Text = precioCafe.ToString();
            }
            else if (comboBoxCafe.Text == "Descafeinado")
            {
                precioCafe = 1;
                txtBoxPrecioPostreOCafe.Text = precioCafe.ToString();
            }

        }

        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            

            
            totalCuenta = double.Parse(txtBoxPrecioPrimerPlato.Text) + double.Parse(txtBoxPrecioSegundoPlato.Text) + double.Parse(txtBoxPrecioBebida.Text) + double.Parse(txtBoxPrecioPostreOCafe.Text);
            totalCuentaConIva = totalCuenta + (totalCuenta * 0.11);
            txtBoxPrecioSinIva.Text = totalCuenta.ToString();
            txtBoxPrecioConIva.Text = totalCuentaConIva.ToString();
            
        }

        private void txtBoxCantidadDada_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(txtBoxCantidadDada.Text) > 0)
            {
                totalADevolver = double.Parse(txtBoxCantidadDada.Text) - double.Parse(txtBoxPrecioConIva.Text);
                txtBoxTotalADevolver.Text = totalADevolver.ToString();
            }
            else
            {
                MessageBox.Show("La cantidad no puede ser 0 o menor");
            }
           
        }
    }
}
