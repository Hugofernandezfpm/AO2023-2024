﻿namespace AplicacionesGraficas
{
    partial class ejercicio1
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
            this.btnejercicio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnejercicio1
            // 
            this.btnejercicio1.Location = new System.Drawing.Point(106, 118);
            this.btnejercicio1.Name = "btnejercicio1";
            this.btnejercicio1.Size = new System.Drawing.Size(75, 23);
            this.btnejercicio1.TabIndex = 0;
            this.btnejercicio1.Text = "ejercicio1";
            this.btnejercicio1.UseVisualStyleBackColor = true;
            this.btnejercicio1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnejercicio1);
            this.Name = "ejercicio1";
            this.Text = "ejercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnejercicio1;
    }
}