namespace Comunicacion_entre_formas
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
            this.btnAbrirforma = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirforma
            // 
            this.btnAbrirforma.Location = new System.Drawing.Point(213, 30);
            this.btnAbrirforma.Name = "btnAbrirforma";
            this.btnAbrirforma.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirforma.TabIndex = 0;
            this.btnAbrirforma.Text = "Abrir forma 2";
            this.btnAbrirforma.UseVisualStyleBackColor = true;
            this.btnAbrirforma.Click += new System.EventHandler(this.btnAbrirforma_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(31, 30);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "label1";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(31, 81);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(35, 13);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 131);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAbrirforma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirforma;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblContenido;
    }
}

