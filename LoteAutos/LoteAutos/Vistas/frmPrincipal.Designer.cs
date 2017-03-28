namespace LoteAutos
{
    partial class frmPrincipal
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
            this.btnCompradores = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompradores
            // 
            this.btnCompradores.Location = new System.Drawing.Point(12, 12);
            this.btnCompradores.Name = "btnCompradores";
            this.btnCompradores.Size = new System.Drawing.Size(97, 23);
            this.btnCompradores.TabIndex = 0;
            this.btnCompradores.Text = "Compradores";
            this.btnCompradores.UseVisualStyleBackColor = true;
            this.btnCompradores.Click += new System.EventHandler(this.btnCompradores_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(115, 12);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(97, 23);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Propietarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnCompradores);
            this.Name = "frmPrincipal";
            this.Text = "Lote de Autos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompradores;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button button1;
    }
}

