namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.botonSiguente = new System.Windows.Forms.Button();
            this.botonAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonSiguente
            // 
            this.botonSiguente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonSiguente.BackgroundImage")));
            this.botonSiguente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSiguente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguente.Location = new System.Drawing.Point(633, 418);
            this.botonSiguente.Name = "botonSiguente";
            this.botonSiguente.Size = new System.Drawing.Size(65, 55);
            this.botonSiguente.TabIndex = 0;
            this.botonSiguente.UseVisualStyleBackColor = true;
            this.botonSiguente.Click += new System.EventHandler(this.botonSiguente_Click);
            // 
            // botonAnterior
            // 
            this.botonAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAnterior.BackgroundImage")));
            this.botonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAnterior.Location = new System.Drawing.Point(12, 418);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(65, 55);
            this.botonAnterior.TabIndex = 1;
            this.botonAnterior.UseVisualStyleBackColor = true;
            this.botonAnterior.Click += new System.EventHandler(this.botonAnterior_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.botonAnterior);
            this.Controls.Add(this.botonSiguente);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonSiguente;
        private System.Windows.Forms.Button botonAnterior;
    }
}