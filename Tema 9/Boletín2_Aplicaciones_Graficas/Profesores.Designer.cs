namespace Boletín2_Aplicaciones_Graficas
{
    partial class Profesores
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
            this.txtBoxProfesores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxProfesores
            // 
            this.txtBoxProfesores.Location = new System.Drawing.Point(250, 107);
            this.txtBoxProfesores.Name = "txtBoxProfesores";
            this.txtBoxProfesores.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProfesores.TabIndex = 0;
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxProfesores);
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxProfesores;
    }
}