namespace Sistema_Ventas_Vehiculos
{
    partial class Portada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            this.botonIngresar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.portadaLabel = new System.Windows.Forms.Label();
            this.botonVerVehiculos = new System.Windows.Forms.Button();
            this.botonListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonIngresar.BackgroundImage")));
            this.botonIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonIngresar.Location = new System.Drawing.Point(12, 242);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(80, 67);
            this.botonIngresar.TabIndex = 1;
            this.botonIngresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonSalir.BackgroundImage")));
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.Location = new System.Drawing.Point(604, 241);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(80, 68);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // portadaLabel
            // 
            this.portadaLabel.AutoSize = true;
            this.portadaLabel.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portadaLabel.Location = new System.Drawing.Point(177, 12);
            this.portadaLabel.Name = "portadaLabel";
            this.portadaLabel.Size = new System.Drawing.Size(312, 24);
            this.portadaLabel.TabIndex = 3;
            this.portadaLabel.Text = "Sistema-De-Ventas-De-Vehiculos";
            // 
            // botonVerVehiculos
            // 
            this.botonVerVehiculos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonVerVehiculos.BackgroundImage")));
            this.botonVerVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVerVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVerVehiculos.Location = new System.Drawing.Point(604, 12);
            this.botonVerVehiculos.Name = "botonVerVehiculos";
            this.botonVerVehiculos.Size = new System.Drawing.Size(80, 67);
            this.botonVerVehiculos.TabIndex = 4;
            this.botonVerVehiculos.UseVisualStyleBackColor = true;
            this.botonVerVehiculos.Click += new System.EventHandler(this.botonVerVehiculos_Click);
            // 
            // botonListar
            // 
            this.botonListar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonListar.BackgroundImage")));
            this.botonListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonListar.Location = new System.Drawing.Point(12, 12);
            this.botonListar.Name = "botonListar";
            this.botonListar.Size = new System.Drawing.Size(80, 67);
            this.botonListar.TabIndex = 5;
            this.botonListar.UseVisualStyleBackColor = true;
            this.botonListar.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 321);
            this.Controls.Add(this.botonListar);
            this.Controls.Add(this.botonVerVehiculos);
            this.Controls.Add(this.portadaLabel);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonIngresar);
            this.Name = "Portada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Ventas Vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label portadaLabel;
        private System.Windows.Forms.Button botonVerVehiculos;
        private System.Windows.Forms.Button botonListar;
    }
}

