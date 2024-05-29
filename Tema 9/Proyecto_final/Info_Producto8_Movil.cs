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
    public partial class Info_Producto8_Movil : Form
    {
        public Info_Producto8_Movil()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            StreamWriter registroProductos_Moviles = new StreamWriter(Directory.GetCurrentDirectory() + "\\registroProductosMoviles.txt", true);
            List<string> productos2 = new List<string>();

            productos2.Add(label_Codigo_Movil.Text.ToString() + ",");
            productos2.Add(label_Marca_Movil.Text.ToString() + ",");
            productos2.Add(label_Modelo_Movil.Text.ToString() + ",");
            productos2.Add(label_Ram_Movil.Text.ToString() + ",");
            productos2.Add(label_Camara_Movil.Text.ToString() + ",");
            productos2.Add(label_Procesador_Movil.Text.ToString() + ",");
            productos2.Add(label_Precio_Movil.Text.ToString() + ", ");

            for (int i = 0; i < productos2.Count; i++)
            {
                registroProductos_Moviles.Write(productos2[i]);
            }


            MessageBox.Show("Producto añadido con exito");

            registroProductos_Moviles.Close();
        }
    }
}
