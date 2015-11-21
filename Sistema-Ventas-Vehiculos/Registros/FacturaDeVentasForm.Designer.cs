namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class FacturaDeVentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaDeVentasForm));
            this.botonAnterior = new System.Windows.Forms.Button();
            this.botonSiguente = new System.Windows.Forms.Button();
            this.vehiculoIdComboBox = new System.Windows.Forms.ComboBox();
            this.facturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // botonAnterior
            // 
            this.botonAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAnterior.BackgroundImage")));
            this.botonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAnterior.Location = new System.Drawing.Point(12, 422);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(65, 55);
            this.botonAnterior.TabIndex = 2;
            this.botonAnterior.UseVisualStyleBackColor = true;
            this.botonAnterior.Click += new System.EventHandler(this.botonAnterior_Click);
            // 
            // botonSiguente
            // 
            this.botonSiguente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonSiguente.BackgroundImage")));
            this.botonSiguente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSiguente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguente.Location = new System.Drawing.Point(634, 422);
            this.botonSiguente.Name = "botonSiguente";
            this.botonSiguente.Size = new System.Drawing.Size(65, 55);
            this.botonSiguente.TabIndex = 3;
            this.botonSiguente.UseVisualStyleBackColor = true;
            // 
            // vehiculoIdComboBox
            // 
            this.vehiculoIdComboBox.FormattingEnabled = true;
            this.vehiculoIdComboBox.Location = new System.Drawing.Point(13, 13);
            this.vehiculoIdComboBox.Name = "vehiculoIdComboBox";
            this.vehiculoIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.vehiculoIdComboBox.TabIndex = 4;
            // 
            // facturaDateTimePicker
            // 
            this.facturaDateTimePicker.Location = new System.Drawing.Point(13, 55);
            this.facturaDateTimePicker.Name = "facturaDateTimePicker";
            this.facturaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.facturaDateTimePicker.TabIndex = 5;
            // 
            // FacturaDeVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 489);
            this.Controls.Add(this.facturaDateTimePicker);
            this.Controls.Add(this.vehiculoIdComboBox);
            this.Controls.Add(this.botonSiguente);
            this.Controls.Add(this.botonAnterior);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FacturaDeVentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura De Ventas";
            this.Load += new System.EventHandler(this.FacturaDeVentasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Button botonSiguente;
        private System.Windows.Forms.ComboBox vehiculoIdComboBox;
        private System.Windows.Forms.DateTimePicker facturaDateTimePicker;
    }
}