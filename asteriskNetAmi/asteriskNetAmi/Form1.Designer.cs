namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.extension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.llamar = new System.Windows.Forms.Button();
            this.registros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARCADOR AUTOMATICO";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(12, 74);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(142, 20);
            this.telefono.TabIndex = 1;
            // 
            // extension
            // 
            this.extension.Location = new System.Drawing.Point(193, 74);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(141, 20);
            this.extension.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extensión:";
            // 
            // llamar
            // 
            this.llamar.Location = new System.Drawing.Point(350, 58);
            this.llamar.Name = "llamar";
            this.llamar.Size = new System.Drawing.Size(75, 36);
            this.llamar.TabIndex = 5;
            this.llamar.Text = "Llamar";
            this.llamar.UseVisualStyleBackColor = true;
            this.llamar.Click += new System.EventHandler(this.llamar_Click);
            // 
            // registros
            // 
            this.registros.Location = new System.Drawing.Point(12, 133);
            this.registros.Multiline = true;
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(317, 99);
            this.registros.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teléfono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Registros :";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(350, 196);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 36);
            this.salir.TabIndex = 10;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 245);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.llamar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Marcador Asteris.NET  --  AMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox extension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button llamar;
        private System.Windows.Forms.TextBox registros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salir;
    }
}

