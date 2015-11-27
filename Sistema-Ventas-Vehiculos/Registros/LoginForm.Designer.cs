namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.mensajeLabel = new System.Windows.Forms.Label();
            this.loginComboBox = new System.Windows.Forms.ComboBox();
            this.prioridadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(172, 155);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(54, 14);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "USUARIO";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(172, 181);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 14);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "CONTRASEÑA";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(273, 149);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(273, 175);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonEntrar.BackgroundImage")));
            this.botonEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEntrar.Location = new System.Drawing.Point(12, 280);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(60, 47);
            this.botonEntrar.TabIndex = 4;
            this.botonEntrar.UseVisualStyleBackColor = true;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(487, 280);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(60, 47);
            this.botonAtras.TabIndex = 5;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // mensajeLabel
            // 
            this.mensajeLabel.AutoSize = true;
            this.mensajeLabel.BackColor = System.Drawing.Color.Transparent;
            this.mensajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeLabel.Location = new System.Drawing.Point(132, 126);
            this.mensajeLabel.Name = "mensajeLabel";
            this.mensajeLabel.Size = new System.Drawing.Size(325, 16);
            this.mensajeLabel.TabIndex = 6;
            this.mensajeLabel.Text = "Introduzca su nombre de usuario y contraseña";
            this.mensajeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginComboBox
            // 
            this.loginComboBox.FormattingEnabled = true;
            this.loginComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.loginComboBox.Location = new System.Drawing.Point(273, 202);
            this.loginComboBox.Name = "loginComboBox";
            this.loginComboBox.Size = new System.Drawing.Size(100, 21);
            this.loginComboBox.TabIndex = 7;
            this.loginComboBox.SelectedIndexChanged += new System.EventHandler(this.loginComboBox_SelectedIndexChanged);
            // 
            // prioridadLabel
            // 
            this.prioridadLabel.AutoSize = true;
            this.prioridadLabel.BackColor = System.Drawing.Color.Transparent;
            this.prioridadLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioridadLabel.Location = new System.Drawing.Point(172, 205);
            this.prioridadLabel.Name = "prioridadLabel";
            this.prioridadLabel.Size = new System.Drawing.Size(98, 14);
            this.prioridadLabel.TabIndex = 8;
            this.prioridadLabel.Text = "TIPO DE USUARIO";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 339);
            this.Controls.Add(this.prioridadLabel);
            this.Controls.Add(this.loginComboBox);
            this.Controls.Add(this.mensajeLabel);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonEntrar);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usuarioLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button botonEntrar;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label mensajeLabel;
        private System.Windows.Forms.ComboBox loginComboBox;
        private System.Windows.Forms.Label prioridadLabel;
    }
}