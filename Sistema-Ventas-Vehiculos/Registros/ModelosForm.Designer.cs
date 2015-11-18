namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class ModelosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelosForm));
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ModeloIDtextBox = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(197, 171);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 22;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(105, 171);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 21;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(12, 171);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 20;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(52, 69);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(16, 13);
            this.IDlabel.TabIndex = 23;
            this.IDlabel.Text = "Id";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(52, 117);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 24;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(121, 117);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 25;
            // 
            // ModeloIDtextBox
            // 
            this.ModeloIDtextBox.Location = new System.Drawing.Point(121, 69);
            this.ModeloIDtextBox.Name = "ModeloIDtextBox";
            this.ModeloIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.ModeloIDtextBox.TabIndex = 26;
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.Location = new System.Drawing.Point(225, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(47, 41);
            this.botonBuscar.TabIndex = 27;
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(225, 209);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(47, 41);
            this.botonAtras.TabIndex = 32;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // ModelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.ModeloIDtextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonNuevo);
            this.Name = "ModelosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox ModeloIDtextBox;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonAtras;
    }
}