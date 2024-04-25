namespace Boletín2_Aplicaciones_Graficas
{
    partial class Ejercicio4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDelCampo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.radioBtnCargarenComboBox = new System.Windows.Forms.RadioButton();
            this.radioBtnCargarEnLisBox = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRegistro = new System.Windows.Forms.ComboBox();
            this.listBoxRegistro = new System.Windows.Forms.ListBox();
            this.btnVolcar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del campo:";
            // 
            // txtNombreDelCampo
            // 
            this.txtNombreDelCampo.Location = new System.Drawing.Point(115, 22);
            this.txtNombreDelCampo.Multiline = true;
            this.txtNombreDelCampo.Name = "txtNombreDelCampo";
            this.txtNombreDelCampo.Size = new System.Drawing.Size(147, 20);
            this.txtNombreDelCampo.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(298, 19);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // radioBtnCargarenComboBox
            // 
            this.radioBtnCargarenComboBox.AutoSize = true;
            this.radioBtnCargarenComboBox.Location = new System.Drawing.Point(115, 48);
            this.radioBtnCargarenComboBox.Name = "radioBtnCargarenComboBox";
            this.radioBtnCargarenComboBox.Size = new System.Drawing.Size(125, 17);
            this.radioBtnCargarenComboBox.TabIndex = 3;
            this.radioBtnCargarenComboBox.TabStop = true;
            this.radioBtnCargarenComboBox.Text = "Cargar en ComboBox";
            this.radioBtnCargarenComboBox.UseVisualStyleBackColor = true;
            // 
            // radioBtnCargarEnLisBox
            // 
            this.radioBtnCargarEnLisBox.AutoSize = true;
            this.radioBtnCargarEnLisBox.Location = new System.Drawing.Point(115, 71);
            this.radioBtnCargarEnLisBox.Name = "radioBtnCargarEnLisBox";
            this.radioBtnCargarEnLisBox.Size = new System.Drawing.Size(105, 17);
            this.radioBtnCargarEnLisBox.TabIndex = 4;
            this.radioBtnCargarEnLisBox.TabStop = true;
            this.radioBtnCargarEnLisBox.Text = "Cargar en LisBox";
            this.radioBtnCargarEnLisBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registro";
            // 
            // comboBoxRegistro
            // 
            this.comboBoxRegistro.FormattingEnabled = true;
            this.comboBoxRegistro.Location = new System.Drawing.Point(12, 102);
            this.comboBoxRegistro.Name = "comboBoxRegistro";
            this.comboBoxRegistro.Size = new System.Drawing.Size(466, 21);
            this.comboBoxRegistro.TabIndex = 6;
            // 
            // listBoxRegistro
            // 
            this.listBoxRegistro.FormattingEnabled = true;
            this.listBoxRegistro.Location = new System.Drawing.Point(12, 129);
            this.listBoxRegistro.Name = "listBoxRegistro";
            this.listBoxRegistro.Size = new System.Drawing.Size(466, 108);
            this.listBoxRegistro.TabIndex = 7;
            // 
            // btnVolcar
            // 
            this.btnVolcar.Location = new System.Drawing.Point(298, 57);
            this.btnVolcar.Name = "btnVolcar";
            this.btnVolcar.Size = new System.Drawing.Size(75, 21);
            this.btnVolcar.TabIndex = 8;
            this.btnVolcar.Text = "Volcar";
            this.btnVolcar.UseVisualStyleBackColor = true;
            this.btnVolcar.Click += new System.EventHandler(this.btnVolcar_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolcar);
            this.Controls.Add(this.listBoxRegistro);
            this.Controls.Add(this.comboBoxRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnCargarEnLisBox);
            this.Controls.Add(this.radioBtnCargarenComboBox);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtNombreDelCampo);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDelCampo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton radioBtnCargarenComboBox;
        private System.Windows.Forms.RadioButton radioBtnCargarEnLisBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRegistro;
        private System.Windows.Forms.ListBox listBoxRegistro;
        private System.Windows.Forms.Button btnVolcar;
    }
}