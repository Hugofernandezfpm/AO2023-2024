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
    public partial class Info_Producto3 : Form
    {
        public Info_Producto3()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            StreamWriter registroProductos = new StreamWriter(Directory.GetCurrentDirectory() + "\\registroProductos.txt", true);
            List<string> productos = new List<string>();

            productos.Add(codigo_ordenador.Text.ToString() + ",");
            productos.Add(marca_ordenador.Text.ToString() + ",");
            productos.Add(modelo_ordenador.Text.ToString() + ",");
            productos.Add(ram_ordenador.Text.ToString() + ",");
            productos.Add(hdd_o_sdd_ordenador.Text.ToString() + ",");
            productos.Add(procesador_ordenador.Text.ToString() + ",");
            productos.Add(precio_ordenador.Text.ToString() + ", ");

            for (int i = 0; i < productos.Count; i++)
            {
                registroProductos.Write(productos[i]);
            }


            MessageBox.Show("Producto añadido con exito");

            registroProductos.Close();

        }
    }
}
