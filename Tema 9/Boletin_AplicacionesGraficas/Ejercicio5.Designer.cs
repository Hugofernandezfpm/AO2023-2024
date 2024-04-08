namespace Boletin_AplicacionesGraficas
{
    partial class Ejercicio5
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
            this.btnPulsar = new System.Windows.Forms.Button();
            this.labelSumar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.labelRestar = new System.Windows.Forms.Label();
            this.labelMultiplicar = new System.Windows.Forms.Label();
            this.labelDividir = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPulsar
            // 
            this.btnPulsar.Location = new System.Drawing.Point(108, 219);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(75, 23);
            this.btnPulsar.TabIndex = 4;
            this.btnPulsar.Text = "+";
            this.btnPulsar.UseVisualStyleBackColor = true;
            this.btnPulsar.Click += new System.EventHandler(this.operador);
            // 
            // labelSumar
            // 
            this.labelSumar.AutoSize = true;
            this.labelSumar.Location = new System.Drawing.Point(258, 142);
            this.labelSumar.Name = "labelSumar";
            this.labelSumar.Size = new System.Drawing.Size(13, 13);
            this.labelSumar.TabIndex = 6;
            this.labelSumar.Text = "+";
            this.labelSumar.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operador);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operador);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operador);
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(108, 136);
            this.textBoxNumero1.Multiline = true;
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(120, 26);
            this.textBoxNumero1.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(455, 136);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(120, 26);
            this.textBoxResultado.TabIndex = 3;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(301, 136);
            this.textBoxNumero2.Multiline = true;
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(120, 26);
            this.textBoxNumero2.TabIndex = 2;
            // 
            // labelRestar
            // 
            this.labelRestar.AutoSize = true;
            this.labelRestar.Location = new System.Drawing.Point(259, 142);
            this.labelRestar.Name = "labelRestar";
            this.labelRestar.Size = new System.Drawing.Size(10, 13);
            this.labelRestar.TabIndex = 30;
            this.labelRestar.Text = "-";
            this.labelRestar.Visible = false;
            // 
            // labelMultiplicar
            // 
            this.labelMultiplicar.AutoSize = true;
            this.labelMultiplicar.Location = new System.Drawing.Point(260, 142);
            this.labelMultiplicar.Name = "labelMultiplicar";
            this.labelMultiplicar.Size = new System.Drawing.Size(11, 13);
            this.labelMultiplicar.TabIndex = 31;
            this.labelMultiplicar.Text = "*";
            this.labelMultiplicar.Visible = false;
            // 
            // labelDividir
            // 
            this.labelDividir.AutoSize = true;
            this.labelDividir.Location = new System.Drawing.Point(260, 142);
            this.labelDividir.Name = "labelDividir";
            this.labelDividir.Size = new System.Drawing.Size(12, 13);
            this.labelDividir.TabIndex = 32;
            this.labelDividir.Text = "/";
            this.labelDividir.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(422, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelDividir);
            this.Controls.Add(this.labelMultiplicar);
            this.Controls.Add(this.labelRestar);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPulsar);
            this.Controls.Add(this.labelSumar);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPulsar;
        private System.Windows.Forms.Label labelSumar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Label labelRestar;
        private System.Windows.Forms.Label labelMultiplicar;
        private System.Windows.Forms.Label labelDividir;
        private System.Windows.Forms.Button button4;
    }
}