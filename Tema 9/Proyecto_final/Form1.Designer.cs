namespace Proyecto_final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrdenadores = new System.Windows.Forms.Button();
            this.btnMoviles = new System.Windows.Forms.Button();
            this.btnCesta = new System.Windows.Forms.Button();
            this.btnEleminar_Todos_Los_Productos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdenadores
            // 
            this.btnOrdenadores.Location = new System.Drawing.Point(27, 84);
            this.btnOrdenadores.Name = "btnOrdenadores";
            this.btnOrdenadores.Size = new System.Drawing.Size(238, 94);
            this.btnOrdenadores.TabIndex = 0;
            this.btnOrdenadores.Text = "Añadir Ordenadores";
            this.btnOrdenadores.UseVisualStyleBackColor = true;
            this.btnOrdenadores.Click += new System.EventHandler(this.btnOrdenadores_Click);
            // 
            // btnMoviles
            // 
            this.btnMoviles.Location = new System.Drawing.Point(303, 84);
            this.btnMoviles.Name = "btnMoviles";
            this.btnMoviles.Size = new System.Drawing.Size(238, 94);
            this.btnMoviles.TabIndex = 1;
            this.btnMoviles.Text = "Añadir Moviles";
            this.btnMoviles.UseVisualStyleBackColor = true;
            this.btnMoviles.Click += new System.EventHandler(this.btnMoviles_Click);
            // 
            // btnCesta
            // 
            this.btnCesta.Location = new System.Drawing.Point(570, 84);
            this.btnCesta.Name = "btnCesta";
            this.btnCesta.Size = new System.Drawing.Size(238, 94);
            this.btnCesta.TabIndex = 2;
            this.btnCesta.Text = "Cesta";
            this.btnCesta.UseVisualStyleBackColor = true;
            this.btnCesta.Click += new System.EventHandler(this.btnCesta_Click);
            // 
            // btnEleminar_Todos_Los_Productos
            // 
            this.btnEleminar_Todos_Los_Productos.Location = new System.Drawing.Point(830, 84);
            this.btnEleminar_Todos_Los_Productos.Name = "btnEleminar_Todos_Los_Productos";
            this.btnEleminar_Todos_Los_Productos.Size = new System.Drawing.Size(238, 94);
            this.btnEleminar_Todos_Los_Productos.TabIndex = 3;
            this.btnEleminar_Todos_Los_Productos.Text = "Eliminar todos los productos";
            this.btnEleminar_Todos_Los_Productos.UseVisualStyleBackColor = true;
            this.btnEleminar_Todos_Los_Productos.Click += new System.EventHandler(this.btnEleminar_Todos_Los_Productos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 563);
            this.Controls.Add(this.btnEleminar_Todos_Los_Productos);
            this.Controls.Add(this.btnCesta);
            this.Controls.Add(this.btnMoviles);
            this.Controls.Add(this.btnOrdenadores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenadores;
        private System.Windows.Forms.Button btnMoviles;
        private System.Windows.Forms.Button btnCesta;
        private System.Windows.Forms.Button btnEleminar_Todos_Los_Productos;
    }
}

