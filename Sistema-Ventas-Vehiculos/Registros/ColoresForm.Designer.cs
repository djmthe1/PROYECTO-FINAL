namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class ColoresForm
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
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.ColoresIDtextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(12, 227);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 3;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(197, 227);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 4;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // ColoresIDtextBox
            // 
            this.ColoresIDtextBox.Location = new System.Drawing.Point(124, 47);
            this.ColoresIDtextBox.Name = "ColoresIDtextBox";
            this.ColoresIDtextBox.Size = new System.Drawing.Size(51, 20);
            this.ColoresIDtextBox.TabIndex = 6;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(124, 97);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(81, 20);
            this.DescripciontextBox.TabIndex = 7;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(44, 50);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(16, 13);
            this.IDlabel.TabIndex = 8;
            this.IDlabel.Text = "Id";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(44, 100);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 10;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // ColoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.ColoresIDtextBox);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonNuevo);
            this.Name = "ColoresForm";
            this.Text = "ColoresForm";
            this.Load += new System.EventHandler(this.ColoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.TextBox ColoresIDtextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Descripcionlabel;
    }
}