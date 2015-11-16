namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class InsetarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsetarForm));
            this.SeleccionarComboBox = new System.Windows.Forms.ComboBox();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeleccionarComboBox
            // 
            this.SeleccionarComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeleccionarComboBox.FormattingEnabled = true;
            this.SeleccionarComboBox.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Color",
            "Tipo de Vehiculo",
            "Tipo de Motor",
            "Vehiculo"});
            this.SeleccionarComboBox.Location = new System.Drawing.Point(13, 13);
            this.SeleccionarComboBox.Name = "SeleccionarComboBox";
            this.SeleccionarComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeleccionarComboBox.TabIndex = 0;
            this.SeleccionarComboBox.SelectedIndexChanged += new System.EventHandler(this.selecionarComboBox_SelectedIndexChanged);
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(309, 205);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(53, 42);
            this.botonAtras.TabIndex = 32;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // InsetarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 259);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.SeleccionarComboBox);
            this.Name = "InsetarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsetarForm";
            this.Load += new System.EventHandler(this.InsetarForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SeleccionarComboBox;
        private System.Windows.Forms.Button botonAtras;
    }
}