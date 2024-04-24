namespace Boletín2_Aplicaciones_Graficas
{
    partial class Ejercicio6
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
            this.radioBtnTigre = new System.Windows.Forms.RadioButton();
            this.radioBtnTiburon = new System.Windows.Forms.RadioButton();
            this.radioBtnJirafa = new System.Windows.Forms.RadioButton();
            this.pictureBoxJirafa = new System.Windows.Forms.PictureBox();
            this.pictureBoxTiburon = new System.Windows.Forms.PictureBox();
            this.pictureBoxTigre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJirafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTiburon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTigre)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnTigre
            // 
            this.radioBtnTigre.AutoSize = true;
            this.radioBtnTigre.Location = new System.Drawing.Point(12, 51);
            this.radioBtnTigre.Name = "radioBtnTigre";
            this.radioBtnTigre.Size = new System.Drawing.Size(49, 17);
            this.radioBtnTigre.TabIndex = 0;
            this.radioBtnTigre.TabStop = true;
            this.radioBtnTigre.Text = "Tigre";
            this.radioBtnTigre.UseVisualStyleBackColor = true;
            this.radioBtnTigre.CheckedChanged += new System.EventHandler(this.radioBtnTigre_CheckedChanged);
            // 
            // radioBtnTiburon
            // 
            this.radioBtnTiburon.AutoSize = true;
            this.radioBtnTiburon.Location = new System.Drawing.Point(12, 92);
            this.radioBtnTiburon.Name = "radioBtnTiburon";
            this.radioBtnTiburon.Size = new System.Drawing.Size(61, 17);
            this.radioBtnTiburon.TabIndex = 1;
            this.radioBtnTiburon.TabStop = true;
            this.radioBtnTiburon.Text = "Tiburon";
            this.radioBtnTiburon.UseVisualStyleBackColor = true;
            this.radioBtnTiburon.CheckedChanged += new System.EventHandler(this.radioBtnTiburon_CheckedChanged);
            // 
            // radioBtnJirafa
            // 
            this.radioBtnJirafa.AutoSize = true;
            this.radioBtnJirafa.Location = new System.Drawing.Point(12, 141);
            this.radioBtnJirafa.Name = "radioBtnJirafa";
            this.radioBtnJirafa.Size = new System.Drawing.Size(50, 17);
            this.radioBtnJirafa.TabIndex = 2;
            this.radioBtnJirafa.TabStop = true;
            this.radioBtnJirafa.Text = "Jirafa";
            this.radioBtnJirafa.UseVisualStyleBackColor = true;
            this.radioBtnJirafa.CheckedChanged += new System.EventHandler(this.radioBtnJirafa_CheckedChanged);
            // 
            // pictureBoxJirafa
            // 
            this.pictureBoxJirafa.Image = global::Boletín2_Aplicaciones_Graficas.Properties.Resources.Jirafa;
            this.pictureBoxJirafa.Location = new System.Drawing.Point(113, 50);
            this.pictureBoxJirafa.Name = "pictureBoxJirafa";
            this.pictureBoxJirafa.Size = new System.Drawing.Size(220, 108);
            this.pictureBoxJirafa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJirafa.TabIndex = 5;
            this.pictureBoxJirafa.TabStop = false;
            this.pictureBoxJirafa.Visible = false;
            // 
            // pictureBoxTiburon
            // 
            this.pictureBoxTiburon.Image = global::Boletín2_Aplicaciones_Graficas.Properties.Resources.tiburon;
            this.pictureBoxTiburon.Location = new System.Drawing.Point(113, 51);
            this.pictureBoxTiburon.Name = "pictureBoxTiburon";
            this.pictureBoxTiburon.Size = new System.Drawing.Size(220, 108);
            this.pictureBoxTiburon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTiburon.TabIndex = 4;
            this.pictureBoxTiburon.TabStop = false;
            this.pictureBoxTiburon.Visible = false;
            // 
            // pictureBoxTigre
            // 
            this.pictureBoxTigre.Image = global::Boletín2_Aplicaciones_Graficas.Properties.Resources.tigre;
            this.pictureBoxTigre.Location = new System.Drawing.Point(113, 50);
            this.pictureBoxTigre.Name = "pictureBoxTigre";
            this.pictureBoxTigre.Size = new System.Drawing.Size(220, 108);
            this.pictureBoxTigre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTigre.TabIndex = 3;
            this.pictureBoxTigre.TabStop = false;
            this.pictureBoxTigre.Visible = false;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxJirafa);
            this.Controls.Add(this.pictureBoxTiburon);
            this.Controls.Add(this.pictureBoxTigre);
            this.Controls.Add(this.radioBtnJirafa);
            this.Controls.Add(this.radioBtnTiburon);
            this.Controls.Add(this.radioBtnTigre);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJirafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTiburon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTigre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnTigre;
        private System.Windows.Forms.RadioButton radioBtnTiburon;
        private System.Windows.Forms.RadioButton radioBtnJirafa;
        private System.Windows.Forms.PictureBox pictureBoxTigre;
        private System.Windows.Forms.PictureBox pictureBoxTiburon;
        private System.Windows.Forms.PictureBox pictureBoxJirafa;
    }
}