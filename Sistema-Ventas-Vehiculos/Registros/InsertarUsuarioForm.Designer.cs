namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class InsertarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarUsuarioForm));
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.prioridadLabel = new System.Windows.Forms.Label();
            this.usuarioIDTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.confirmarPassTextBox = new System.Windows.Forms.TextBox();
            this.confirmarContraseñaLabel = new System.Windows.Forms.Label();
            this.prioridadComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(197, 188);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 19;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(105, 188);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 18;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(12, 188);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 17;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(25, 32);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(16, 13);
            this.IDlabel.TabIndex = 20;
            this.IDlabel.Text = "Id";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(21, 62);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 21;
            this.nombreLabel.Text = "Nombre";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(12, 94);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(61, 13);
            this.passLabel.TabIndex = 22;
            this.passLabel.Text = "Contraseña";
            // 
            // prioridadLabel
            // 
            this.prioridadLabel.AutoSize = true;
            this.prioridadLabel.Location = new System.Drawing.Point(12, 151);
            this.prioridadLabel.Name = "prioridadLabel";
            this.prioridadLabel.Size = new System.Drawing.Size(48, 13);
            this.prioridadLabel.TabIndex = 23;
            this.prioridadLabel.Text = "Prioridad";
            // 
            // usuarioIDTextBox
            // 
            this.usuarioIDTextBox.Location = new System.Drawing.Point(119, 29);
            this.usuarioIDTextBox.Name = "usuarioIDTextBox";
            this.usuarioIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.usuarioIDTextBox.TabIndex = 1;
            this.usuarioIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuarioIDTextBox_KeyPress);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(119, 59);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 2;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(119, 91);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextBox_KeyPress);
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.Location = new System.Drawing.Point(225, 10);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(47, 35);
            this.botonBuscar.TabIndex = 28;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(228, 217);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(44, 33);
            this.botonAtras.TabIndex = 32;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // confirmarPassTextBox
            // 
            this.confirmarPassTextBox.Location = new System.Drawing.Point(119, 120);
            this.confirmarPassTextBox.Name = "confirmarPassTextBox";
            this.confirmarPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmarPassTextBox.TabIndex = 4;
            this.confirmarPassTextBox.UseSystemPasswordChar = true;
            this.confirmarPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmarPassTextBox_KeyPress);
            // 
            // confirmarContraseñaLabel
            // 
            this.confirmarContraseñaLabel.AutoSize = true;
            this.confirmarContraseñaLabel.Location = new System.Drawing.Point(9, 123);
            this.confirmarContraseñaLabel.Name = "confirmarContraseñaLabel";
            this.confirmarContraseñaLabel.Size = new System.Drawing.Size(108, 13);
            this.confirmarContraseñaLabel.TabIndex = 34;
            this.confirmarContraseñaLabel.Text = "Confirmar Contraseña";
            // 
            // prioridadComboBox
            // 
            this.prioridadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prioridadComboBox.FormattingEnabled = true;
            this.prioridadComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.prioridadComboBox.Location = new System.Drawing.Point(119, 151);
            this.prioridadComboBox.Name = "prioridadComboBox";
            this.prioridadComboBox.Size = new System.Drawing.Size(100, 21);
            this.prioridadComboBox.TabIndex = 5;
            // 
            // InsertarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.prioridadComboBox);
            this.Controls.Add(this.confirmarContraseñaLabel);
            this.Controls.Add(this.confirmarPassTextBox);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.usuarioIDTextBox);
            this.Controls.Add(this.prioridadLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonNuevo);
            this.Name = "InsertarUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertarUsuarioForm";
            this.Load += new System.EventHandler(this.InsertarUsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label prioridadLabel;
        private System.Windows.Forms.TextBox usuarioIDTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.TextBox confirmarPassTextBox;
        private System.Windows.Forms.Label confirmarContraseñaLabel;
        private System.Windows.Forms.ComboBox prioridadComboBox;
    }
}