namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class PortadaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortadaForm));
            this.botonInsertar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonAgregarUsuario = new System.Windows.Forms.Button();
            this.botonVenderVehiculo = new System.Windows.Forms.Button();
            this.botonListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInsertar.BackgroundImage")));
            this.botonInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonInsertar.Location = new System.Drawing.Point(12, 12);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(72, 54);
            this.botonInsertar.TabIndex = 0;
            this.botonInsertar.UseVisualStyleBackColor = true;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonSalir.BackgroundImage")));
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonSalir.Location = new System.Drawing.Point(446, 246);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(72, 54);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonAgregarUsuario
            // 
            this.botonAgregarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAgregarUsuario.BackgroundImage")));
            this.botonAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAgregarUsuario.Location = new System.Drawing.Point(446, 12);
            this.botonAgregarUsuario.Name = "botonAgregarUsuario";
            this.botonAgregarUsuario.Size = new System.Drawing.Size(72, 54);
            this.botonAgregarUsuario.TabIndex = 3;
            this.botonAgregarUsuario.UseVisualStyleBackColor = true;
            this.botonAgregarUsuario.Click += new System.EventHandler(this.botonAgregarUsuario_Click);
            // 
            // botonVenderVehiculo
            // 
            this.botonVenderVehiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonVenderVehiculo.BackgroundImage")));
            this.botonVenderVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVenderVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVenderVehiculo.Location = new System.Drawing.Point(225, 245);
            this.botonVenderVehiculo.Name = "botonVenderVehiculo";
            this.botonVenderVehiculo.Size = new System.Drawing.Size(72, 55);
            this.botonVenderVehiculo.TabIndex = 4;
            this.botonVenderVehiculo.UseVisualStyleBackColor = true;
            this.botonVenderVehiculo.Click += new System.EventHandler(this.botonVenderVehiculo_Click);
            // 
            // botonListar
            // 
            this.botonListar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonListar.BackgroundImage")));
            this.botonListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonListar.Location = new System.Drawing.Point(12, 246);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(72, 54);
            this.botonListar.TabIndex = 6;
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // PortadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 312);
            this.Controls.Add(this.botonListar);
            this.Controls.Add(this.botonVenderVehiculo);
            this.Controls.Add(this.botonAgregarUsuario);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonInsertar);
            this.Name = "PortadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portada";
            this.Load += new System.EventHandler(this.PortadaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonVenderVehiculo;
        private System.Windows.Forms.Button botonListar;
        public System.Windows.Forms.Button botonInsertar;
        public System.Windows.Forms.Button botonAgregarUsuario;
    }
}