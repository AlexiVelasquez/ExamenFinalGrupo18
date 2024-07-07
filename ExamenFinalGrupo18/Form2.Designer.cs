namespace ExamenFinalGrupo18
{
    partial class Form2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbtnGano = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbxRegistro = new System.Windows.Forms.ListBox();
            this.lblPuntosTotales = new System.Windows.Forms.Label();
            this.rbtnPerdió = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(214, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Registro de Actividad Diaria de Videojuegos";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "txtNombreJuego";
            // 
            // rbtnGano
            // 
            this.rbtnGano.AutoSize = true;
            this.rbtnGano.Location = new System.Drawing.Point(93, 85);
            this.rbtnGano.Name = "rbtnGano";
            this.rbtnGano.Size = new System.Drawing.Size(51, 17);
            this.rbtnGano.TabIndex = 2;
            this.rbtnGano.TabStop = true;
            this.rbtnGano.Text = "Gané";
            this.rbtnGano.UseVisualStyleBackColor = true;
            this.rbtnGano.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(87, 128);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbxRegistro
            // 
            this.lbxRegistro.FormattingEnabled = true;
            this.lbxRegistro.Location = new System.Drawing.Point(67, 157);
            this.lbxRegistro.Name = "lbxRegistro";
            this.lbxRegistro.Size = new System.Drawing.Size(120, 95);
            this.lbxRegistro.TabIndex = 4;
            // 
            // lblPuntosTotales
            // 
            this.lblPuntosTotales.AutoSize = true;
            this.lblPuntosTotales.Location = new System.Drawing.Point(109, 273);
            this.lblPuntosTotales.Name = "lblPuntosTotales";
            this.lblPuntosTotales.Size = new System.Drawing.Size(87, 13);
            this.lblPuntosTotales.TabIndex = 5;
            this.lblPuntosTotales.Text = "Puntos Totales : ";
            // 
            // rbtnPerdió
            // 
            this.rbtnPerdió.AutoSize = true;
            this.rbtnPerdió.Location = new System.Drawing.Point(93, 108);
            this.rbtnPerdió.Name = "rbtnPerdió";
            this.rbtnPerdió.Size = new System.Drawing.Size(51, 17);
            this.rbtnPerdió.TabIndex = 6;
            this.rbtnPerdió.TabStop = true;
            this.rbtnPerdió.Text = "Perdí";
            this.rbtnPerdió.UseVisualStyleBackColor = true;
            this.rbtnPerdió.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnPerdió);
            this.Controls.Add(this.lblPuntosTotales);
            this.Controls.Add(this.lbxRegistro);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.rbtnGano);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbtnGano;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lbxRegistro;
        private System.Windows.Forms.Label lblPuntosTotales;
        private System.Windows.Forms.RadioButton rbtnPerdió;
    }
}