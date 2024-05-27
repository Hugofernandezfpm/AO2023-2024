namespace Proyecto_final
{
    partial class Ordenadores
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_SDDyHDD_Ordenador = new System.Windows.Forms.RadioButton();
            this.radioBtn_HDD_ordenador = new System.Windows.Forms.RadioButton();
            this.radioBtn_SDD_ordenador = new System.Windows.Forms.RadioButton();
            this.pictureBox_PC_4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PC_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PC_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PC_1 = new System.Windows.Forms.PictureBox();
            this.comboBoxRango_De_Precios_Ordenador = new System.Windows.Forms.ComboBox();
            this.comboBox_Procesadores_Ordenador = new System.Windows.Forms.ComboBox();
            this.txtBox_Buscar_Por_Codigo_Ordenador = new System.Windows.Forms.TextBox();
            this.btn_Buscar_Codigo_Ordenador = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_Procesadores_Ordenador);
            this.groupBox3.Location = new System.Drawing.Point(16, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 69);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesadores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxRango_De_Precios_Ordenador);
            this.groupBox2.Location = new System.Drawing.Point(16, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 73);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rangos de precios:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_SDDyHDD_Ordenador);
            this.groupBox1.Controls.Add(this.radioBtn_HDD_ordenador);
            this.groupBox1.Controls.Add(this.radioBtn_SDD_ordenador);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 81);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SDD o HDD:";
            // 
            // radioButton_SDDyHDD_Ordenador
            // 
            this.radioButton_SDDyHDD_Ordenador.AutoSize = true;
            this.radioButton_SDDyHDD_Ordenador.Location = new System.Drawing.Point(4, 19);
            this.radioButton_SDDyHDD_Ordenador.Name = "radioButton_SDDyHDD_Ordenador";
            this.radioButton_SDDyHDD_Ordenador.Size = new System.Drawing.Size(82, 17);
            this.radioButton_SDDyHDD_Ordenador.TabIndex = 11;
            this.radioButton_SDDyHDD_Ordenador.TabStop = true;
            this.radioButton_SDDyHDD_Ordenador.Text = "SSD y HDD";
            this.radioButton_SDDyHDD_Ordenador.UseVisualStyleBackColor = true;
            this.radioButton_SDDyHDD_Ordenador.CheckedChanged += new System.EventHandler(this.radioButton_SDDyHDD_Ordenador_CheckedChanged);
            // 
            // radioBtn_HDD_ordenador
            // 
            this.radioBtn_HDD_ordenador.AutoSize = true;
            this.radioBtn_HDD_ordenador.Location = new System.Drawing.Point(4, 58);
            this.radioBtn_HDD_ordenador.Name = "radioBtn_HDD_ordenador";
            this.radioBtn_HDD_ordenador.Size = new System.Drawing.Size(49, 17);
            this.radioBtn_HDD_ordenador.TabIndex = 10;
            this.radioBtn_HDD_ordenador.TabStop = true;
            this.radioBtn_HDD_ordenador.Text = "HDD";
            this.radioBtn_HDD_ordenador.UseVisualStyleBackColor = true;
            this.radioBtn_HDD_ordenador.CheckedChanged += new System.EventHandler(this.radioBtn_HDD_ordenador_CheckedChanged);
            // 
            // radioBtn_SDD_ordenador
            // 
            this.radioBtn_SDD_ordenador.AutoSize = true;
            this.radioBtn_SDD_ordenador.Location = new System.Drawing.Point(4, 42);
            this.radioBtn_SDD_ordenador.Name = "radioBtn_SDD_ordenador";
            this.radioBtn_SDD_ordenador.Size = new System.Drawing.Size(47, 17);
            this.radioBtn_SDD_ordenador.TabIndex = 10;
            this.radioBtn_SDD_ordenador.TabStop = true;
            this.radioBtn_SDD_ordenador.Text = "SSD";
            this.radioBtn_SDD_ordenador.UseVisualStyleBackColor = true;
            this.radioBtn_SDD_ordenador.CheckedChanged += new System.EventHandler(this.radioBtn_SDD_ordenador_CheckedChanged);
            // 
            // pictureBox_PC_4
            // 
            this.pictureBox_PC_4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PC_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_PC_4.Image = global::Proyecto_final.Properties.Resources.DELL_7010_3;
            this.pictureBox_PC_4.Location = new System.Drawing.Point(511, 171);
            this.pictureBox_PC_4.Name = "pictureBox_PC_4";
            this.pictureBox_PC_4.Size = new System.Drawing.Size(112, 95);
            this.pictureBox_PC_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PC_4.TabIndex = 32;
            this.pictureBox_PC_4.TabStop = false;
            this.pictureBox_PC_4.Visible = false;
            this.pictureBox_PC_4.Click += new System.EventHandler(this.pictureBox_PC_4_Click);
            // 
            // pictureBox_PC_2
            // 
            this.pictureBox_PC_2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PC_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_PC_2.Image = global::Proyecto_final.Properties.Resources.PcCom_Custom_Ryzen_9;
            this.pictureBox_PC_2.Location = new System.Drawing.Point(271, 171);
            this.pictureBox_PC_2.Name = "pictureBox_PC_2";
            this.pictureBox_PC_2.Size = new System.Drawing.Size(112, 95);
            this.pictureBox_PC_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PC_2.TabIndex = 31;
            this.pictureBox_PC_2.TabStop = false;
            this.pictureBox_PC_2.Visible = false;
            this.pictureBox_PC_2.Click += new System.EventHandler(this.pictureBox_PC_2_Click);
            // 
            // pictureBox_PC_3
            // 
            this.pictureBox_PC_3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PC_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_PC_3.Image = global::Proyecto_final.Properties.Resources.HP_Desktop_M01_F2052ns;
            this.pictureBox_PC_3.Location = new System.Drawing.Point(482, 14);
            this.pictureBox_PC_3.Name = "pictureBox_PC_3";
            this.pictureBox_PC_3.Size = new System.Drawing.Size(123, 99);
            this.pictureBox_PC_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PC_3.TabIndex = 30;
            this.pictureBox_PC_3.TabStop = false;
            this.pictureBox_PC_3.Visible = false;
            this.pictureBox_PC_3.Click += new System.EventHandler(this.pictureBox_PC_3_Click);
            // 
            // pictureBox_PC_1
            // 
            this.pictureBox_PC_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_PC_1.Image = global::Proyecto_final.Properties.Resources.volttier;
            this.pictureBox_PC_1.Location = new System.Drawing.Point(271, 12);
            this.pictureBox_PC_1.Name = "pictureBox_PC_1";
            this.pictureBox_PC_1.Size = new System.Drawing.Size(112, 95);
            this.pictureBox_PC_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PC_1.TabIndex = 29;
            this.pictureBox_PC_1.TabStop = false;
            this.pictureBox_PC_1.Visible = false;
            this.pictureBox_PC_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxRango_De_Precios_Ordenador
            // 
            this.comboBoxRango_De_Precios_Ordenador.FormattingEnabled = true;
            this.comboBoxRango_De_Precios_Ordenador.Items.AddRange(new object[] {
            "Todos",
            "0-200",
            "200-500",
            "500-1000",
            "1000-2000"});
            this.comboBoxRango_De_Precios_Ordenador.Location = new System.Drawing.Point(6, 19);
            this.comboBoxRango_De_Precios_Ordenador.Name = "comboBoxRango_De_Precios_Ordenador";
            this.comboBoxRango_De_Precios_Ordenador.Size = new System.Drawing.Size(95, 21);
            this.comboBoxRango_De_Precios_Ordenador.TabIndex = 0;
            this.comboBoxRango_De_Precios_Ordenador.SelectedIndexChanged += new System.EventHandler(this.comboBoxRango_De_Precios_Ordenador_SelectedIndexChanged);
            // 
            // comboBox_Procesadores_Ordenador
            // 
            this.comboBox_Procesadores_Ordenador.FormattingEnabled = true;
            this.comboBox_Procesadores_Ordenador.Items.AddRange(new object[] {
            "Todos",
            "ADM",
            "Intel"});
            this.comboBox_Procesadores_Ordenador.Location = new System.Drawing.Point(6, 19);
            this.comboBox_Procesadores_Ordenador.Name = "comboBox_Procesadores_Ordenador";
            this.comboBox_Procesadores_Ordenador.Size = new System.Drawing.Size(95, 21);
            this.comboBox_Procesadores_Ordenador.TabIndex = 0;
            this.comboBox_Procesadores_Ordenador.SelectedIndexChanged += new System.EventHandler(this.comboBox_Procesadores_Ordenador_SelectedIndexChanged);
            // 
            // txtBox_Buscar_Por_Codigo_Ordenador
            // 
            this.txtBox_Buscar_Por_Codigo_Ordenador.Location = new System.Drawing.Point(12, 267);
            this.txtBox_Buscar_Por_Codigo_Ordenador.Name = "txtBox_Buscar_Por_Codigo_Ordenador";
            this.txtBox_Buscar_Por_Codigo_Ordenador.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Buscar_Por_Codigo_Ordenador.TabIndex = 33;
            // 
            // btn_Buscar_Codigo_Ordenador
            // 
            this.btn_Buscar_Codigo_Ordenador.Location = new System.Drawing.Point(118, 255);
            this.btn_Buscar_Codigo_Ordenador.Name = "btn_Buscar_Codigo_Ordenador";
            this.btn_Buscar_Codigo_Ordenador.Size = new System.Drawing.Size(98, 42);
            this.btn_Buscar_Codigo_Ordenador.TabIndex = 34;
            this.btn_Buscar_Codigo_Ordenador.Text = "Buscar por codigo";
            this.btn_Buscar_Codigo_Ordenador.UseVisualStyleBackColor = true;
            this.btn_Buscar_Codigo_Ordenador.Click += new System.EventHandler(this.btn_Buscar_Codigo_Ordenador_Click);
            // 
            // Ordenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 498);
            this.Controls.Add(this.btn_Buscar_Codigo_Ordenador);
            this.Controls.Add(this.txtBox_Buscar_Por_Codigo_Ordenador);
            this.Controls.Add(this.pictureBox_PC_4);
            this.Controls.Add(this.pictureBox_PC_2);
            this.Controls.Add(this.pictureBox_PC_3);
            this.Controls.Add(this.pictureBox_PC_1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ordenadores";
            this.Text = "Ordenadores";
            this.Load += new System.EventHandler(this.Ordenadores_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PC_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_HDD_ordenador;
        private System.Windows.Forms.RadioButton radioBtn_SDD_ordenador;
        private System.Windows.Forms.PictureBox pictureBox_PC_1;
        private System.Windows.Forms.PictureBox pictureBox_PC_3;
        private System.Windows.Forms.PictureBox pictureBox_PC_2;
        private System.Windows.Forms.PictureBox pictureBox_PC_4;
        private System.Windows.Forms.RadioButton radioButton_SDDyHDD_Ordenador;
        private System.Windows.Forms.ComboBox comboBoxRango_De_Precios_Ordenador;
        private System.Windows.Forms.ComboBox comboBox_Procesadores_Ordenador;
        private System.Windows.Forms.TextBox txtBox_Buscar_Por_Codigo_Ordenador;
        private System.Windows.Forms.Button btn_Buscar_Codigo_Ordenador;
    }
}