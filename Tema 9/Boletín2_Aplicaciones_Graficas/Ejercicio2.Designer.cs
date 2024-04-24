namespace Boletín2_Aplicaciones_Graficas
{
    partial class Ejercicio2
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
            this.listBoxAsignaturas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtn1ºGMI = new System.Windows.Forms.RadioButton();
            this.radioBtn2ºGMI = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBoxAsignaturas
            // 
            this.listBoxAsignaturas.FormattingEnabled = true;
            this.listBoxAsignaturas.Location = new System.Drawing.Point(196, 92);
            this.listBoxAsignaturas.Name = "listBoxAsignaturas";
            this.listBoxAsignaturas.Size = new System.Drawing.Size(224, 95);
            this.listBoxAsignaturas.TabIndex = 0;
            this.listBoxAsignaturas.SelectedIndexChanged += new System.EventHandler(this.listBoxAsignaturas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione su curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sus asignaturas son:";
            // 
            // radioBtn1ºGMI
            // 
            this.radioBtn1ºGMI.AutoSize = true;
            this.radioBtn1ºGMI.Location = new System.Drawing.Point(30, 92);
            this.radioBtn1ºGMI.Name = "radioBtn1ºGMI";
            this.radioBtn1ºGMI.Size = new System.Drawing.Size(58, 17);
            this.radioBtn1ºGMI.TabIndex = 3;
            this.radioBtn1ºGMI.TabStop = true;
            this.radioBtn1ºGMI.Text = "1º GMI";
            this.radioBtn1ºGMI.UseVisualStyleBackColor = true;
            this.radioBtn1ºGMI.CheckedChanged += new System.EventHandler(this.radioBtn1ºGMI_CheckedChanged);
            // 
            // radioBtn2ºGMI
            // 
            this.radioBtn2ºGMI.AutoSize = true;
            this.radioBtn2ºGMI.Location = new System.Drawing.Point(30, 133);
            this.radioBtn2ºGMI.Name = "radioBtn2ºGMI";
            this.radioBtn2ºGMI.Size = new System.Drawing.Size(58, 17);
            this.radioBtn2ºGMI.TabIndex = 4;
            this.radioBtn2ºGMI.TabStop = true;
            this.radioBtn2ºGMI.Text = "2º GMI";
            this.radioBtn2ºGMI.UseVisualStyleBackColor = true;
            this.radioBtn2ºGMI.CheckedChanged += new System.EventHandler(this.radioBtn2ºGMI_CheckedChanged);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBtn2ºGMI);
            this.Controls.Add(this.radioBtn1ºGMI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAsignaturas);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAsignaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtn1ºGMI;
        private System.Windows.Forms.RadioButton radioBtn2ºGMI;
    }
}