namespace ExamenFinalGrupo18
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
            this.txt_dato = new System.Windows.Forms.TextBox();
            this.list_Desordenado = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.listOrdenado = new System.Windows.Forms.ListBox();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.btn_crearDocumento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_dato
            // 
            this.txt_dato.Location = new System.Drawing.Point(102, 17);
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.ShortcutsEnabled = false;
            this.txt_dato.Size = new System.Drawing.Size(100, 22);
            this.txt_dato.TabIndex = 0;
            this.txt_dato.TabStop = false;
            this.txt_dato.TextChanged += new System.EventHandler(this.txt_dato_TextChanged);
            // 
            // list_Desordenado
            // 
            this.list_Desordenado.FormattingEnabled = true;
            this.list_Desordenado.ItemHeight = 16;
            this.list_Desordenado.Location = new System.Drawing.Point(178, 66);
            this.list_Desordenado.Name = "list_Desordenado";
            this.list_Desordenado.Size = new System.Drawing.Size(132, 196);
            this.list_Desordenado.TabIndex = 1;
            this.list_Desordenado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese letra:";
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_ingreso.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingreso.Location = new System.Drawing.Point(46, 66);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(85, 29);
            this.btn_ingreso.TabIndex = 3;
            this.btn_ingreso.Text = "Ingresar";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // listOrdenado
            // 
            this.listOrdenado.FormattingEnabled = true;
            this.listOrdenado.ItemHeight = 16;
            this.listOrdenado.Location = new System.Drawing.Point(325, 66);
            this.listOrdenado.Name = "listOrdenado";
            this.listOrdenado.Size = new System.Drawing.Size(148, 196);
            this.listOrdenado.TabIndex = 4;
            this.listOrdenado.SelectedIndexChanged += new System.EventHandler(this.listOrdenado_SelectedIndexChanged);
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(22, 122);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(135, 69);
            this.btn_ordenar.TabIndex = 7;
            this.btn_ordenar.Text = "Ordenar";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // btn_crearDocumento
            // 
            this.btn_crearDocumento.Location = new System.Drawing.Point(25, 228);
            this.btn_crearDocumento.Name = "btn_crearDocumento";
            this.btn_crearDocumento.Size = new System.Drawing.Size(131, 60);
            this.btn_crearDocumento.TabIndex = 8;
            this.btn_crearDocumento.Text = "Crear Documento";
            this.btn_crearDocumento.UseVisualStyleBackColor = true;
            this.btn_crearDocumento.Click += new System.EventHandler(this.btn_crearDocumento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 334);
            this.Controls.Add(this.btn_crearDocumento);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.listOrdenado);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Desordenado);
            this.Controls.Add(this.txt_dato);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dato;
        private System.Windows.Forms.ListBox list_Desordenado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.ListBox listOrdenado;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Button btn_crearDocumento;
    }
}

