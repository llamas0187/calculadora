namespace calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.textcontra = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(183, 83);
            this.textuser.Multiline = true;
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(171, 26);
            this.textuser.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(19, 163);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(124, 25);
            this.txt.TabIndex = 2;
            this.txt.Text = "Contraseña";
            // 
            // textcontra
            // 
            this.textcontra.Location = new System.Drawing.Point(183, 167);
            this.textcontra.Multiline = true;
            this.textcontra.Name = "textcontra";
            this.textcontra.Size = new System.Drawing.Size(171, 26);
            this.textcontra.TabIndex = 3;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.Lime;
            this.Aceptar.ForeColor = System.Drawing.Color.Black;
            this.Aceptar.Location = new System.Drawing.Point(268, 229);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(86, 33);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Red;
            this.Salir.Location = new System.Drawing.Point(97, 229);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(90, 33);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 274);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.textcontra);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox textcontra;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Salir;
    }
}

