namespace Boletín2_Aplicaciones_Graficas
{
    partial class Ejercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCantidaddeMetros = new System.Windows.Forms.Label();
            this.txtBoxCantidadDeMetros = new System.Windows.Forms.TextBox();
            this.radioBtnMilimetros = new System.Windows.Forms.RadioButton();
            this.radioBtnCentimetros = new System.Windows.Forms.RadioButton();
            this.radioBtnDecimetros = new System.Windows.Forms.RadioButton();
            this.radioBtnKilometros = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoCalculo = new System.Windows.Forms.Button();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCantidaddeMetros
            // 
            this.labelCantidaddeMetros.AutoSize = true;
            this.labelCantidaddeMetros.Location = new System.Drawing.Point(12, 9);
            this.labelCantidaddeMetros.Name = "labelCantidaddeMetros";
            this.labelCantidaddeMetros.Size = new System.Drawing.Size(99, 13);
            this.labelCantidaddeMetros.TabIndex = 0;
            this.labelCantidaddeMetros.Text = "Cantidad de Metros";
            // 
            // txtBoxCantidadDeMetros
            // 
            this.txtBoxCantidadDeMetros.Location = new System.Drawing.Point(117, 6);
            this.txtBoxCantidadDeMetros.Name = "txtBoxCantidadDeMetros";
            this.txtBoxCantidadDeMetros.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantidadDeMetros.TabIndex = 1;
            // 
            // radioBtnMilimetros
            // 
            this.radioBtnMilimetros.AutoSize = true;
            this.radioBtnMilimetros.Location = new System.Drawing.Point(6, 21);
            this.radioBtnMilimetros.Name = "radioBtnMilimetros";
            this.radioBtnMilimetros.Size = new System.Drawing.Size(71, 17);
            this.radioBtnMilimetros.TabIndex = 2;
            this.radioBtnMilimetros.TabStop = true;
            this.radioBtnMilimetros.Text = "Milimetros";
            this.radioBtnMilimetros.UseVisualStyleBackColor = true;
            // 
            // radioBtnCentimetros
            // 
            this.radioBtnCentimetros.AutoSize = true;
            this.radioBtnCentimetros.Location = new System.Drawing.Point(5, 44);
            this.radioBtnCentimetros.Name = "radioBtnCentimetros";
            this.radioBtnCentimetros.Size = new System.Drawing.Size(80, 17);
            this.radioBtnCentimetros.TabIndex = 3;
            this.radioBtnCentimetros.TabStop = true;
            this.radioBtnCentimetros.Text = "Centimetros";
            this.radioBtnCentimetros.UseVisualStyleBackColor = true;
            // 
            // radioBtnDecimetros
            // 
            this.radioBtnDecimetros.AutoSize = true;
            this.radioBtnDecimetros.Location = new System.Drawing.Point(5, 67);
            this.radioBtnDecimetros.Name = "radioBtnDecimetros";
            this.radioBtnDecimetros.Size = new System.Drawing.Size(78, 17);
            this.radioBtnDecimetros.TabIndex = 4;
            this.radioBtnDecimetros.TabStop = true;
            this.radioBtnDecimetros.Text = "Decimetros";
            this.radioBtnDecimetros.UseVisualStyleBackColor = true;
            // 
            // radioBtnKilometros
            // 
            this.radioBtnKilometros.AutoSize = true;
            this.radioBtnKilometros.Location = new System.Drawing.Point(5, 90);
            this.radioBtnKilometros.Name = "radioBtnKilometros";
            this.radioBtnKilometros.Size = new System.Drawing.Size(73, 17);
            this.radioBtnKilometros.TabIndex = 5;
            this.radioBtnKilometros.TabStop = true;
            this.radioBtnKilometros.Text = "Kilometros";
            this.radioBtnKilometros.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioBtnKilometros);
            this.groupBox.Controls.Add(this.radioBtnDecimetros);
            this.groupBox.Controls.Add(this.radioBtnCentimetros);
            this.groupBox.Controls.Add(this.radioBtnMilimetros);
            this.groupBox.Location = new System.Drawing.Point(10, 51);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(117, 123);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tipo de Coversión";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(10, 180);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(80, 38);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(227, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 38);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoCalculo
            // 
            this.btnNuevoCalculo.Location = new System.Drawing.Point(117, 180);
            this.btnNuevoCalculo.Name = "btnNuevoCalculo";
            this.btnNuevoCalculo.Size = new System.Drawing.Size(84, 38);
            this.btnNuevoCalculo.TabIndex = 9;
            this.btnNuevoCalculo.Text = "Nuevo Cáculo";
            this.btnNuevoCalculo.UseVisualStyleBackColor = true;
            this.btnNuevoCalculo.Click += new System.EventHandler(this.btnNuevoCalculo_Click);
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(177, 83);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.txtBoxResultado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Resultado";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.btnNuevoCalculo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.txtBoxCantidadDeMetros);
            this.Controls.Add(this.labelCantidaddeMetros);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCantidaddeMetros;
        private System.Windows.Forms.TextBox txtBoxCantidadDeMetros;
        private System.Windows.Forms.RadioButton radioBtnMilimetros;
        private System.Windows.Forms.RadioButton radioBtnCentimetros;
        private System.Windows.Forms.RadioButton radioBtnDecimetros;
        private System.Windows.Forms.RadioButton radioBtnKilometros;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoCalculo;
        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.Label label1;
    }
}