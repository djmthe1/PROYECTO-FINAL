namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class ListarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarForm));
            this.botonAtrasPortada = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.listarDataGridView = new System.Windows.Forms.DataGridView();
            this.listarComboBox = new System.Windows.Forms.ComboBox();
            this.listarFueraComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAtrasPortada
            // 
            this.botonAtrasPortada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtrasPortada.BackgroundImage")));
            this.botonAtrasPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtrasPortada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtrasPortada.Location = new System.Drawing.Point(447, 252);
            this.botonAtrasPortada.Name = "botonAtrasPortada";
            this.botonAtrasPortada.Size = new System.Drawing.Size(77, 54);
            this.botonAtrasPortada.TabIndex = 34;
            this.botonAtrasPortada.UseVisualStyleBackColor = true;
            this.botonAtrasPortada.Click += new System.EventHandler(this.botonAtrasPortada_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(447, 252);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(77, 54);
            this.botonAtras.TabIndex = 35;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // listarDataGridView
            // 
            this.listarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarDataGridView.Location = new System.Drawing.Point(12, 118);
            this.listarDataGridView.Name = "listarDataGridView";
            this.listarDataGridView.Size = new System.Drawing.Size(381, 188);
            this.listarDataGridView.TabIndex = 36;
            // 
            // listarComboBox
            // 
            this.listarComboBox.FormattingEnabled = true;
            this.listarComboBox.Items.AddRange(new object[] {
            "Marcas",
            "Modelos",
            "Colores",
            "Tipos de Vehiculos",
            "Tipos de Motores",
            "Vehiculos"});
            this.listarComboBox.Location = new System.Drawing.Point(12, 12);
            this.listarComboBox.Name = "listarComboBox";
            this.listarComboBox.Size = new System.Drawing.Size(121, 21);
            this.listarComboBox.TabIndex = 37;
            this.listarComboBox.SelectedIndexChanged += new System.EventHandler(this.listarComboBox_SelectedIndexChanged);
            // 
            // listarFueraComboBox
            // 
            this.listarFueraComboBox.FormattingEnabled = true;
            this.listarFueraComboBox.Items.AddRange(new object[] {
            "Vehiculos"});
            this.listarFueraComboBox.Location = new System.Drawing.Point(13, 12);
            this.listarFueraComboBox.Name = "listarFueraComboBox";
            this.listarFueraComboBox.Size = new System.Drawing.Size(121, 21);
            this.listarFueraComboBox.TabIndex = 38;
            this.listarFueraComboBox.SelectedIndexChanged += new System.EventHandler(this.listarFueraComboBox_SelectedIndexChanged);
            // 
            // ListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 318);
            this.Controls.Add(this.listarFueraComboBox);
            this.Controls.Add(this.listarComboBox);
            this.Controls.Add(this.listarDataGridView);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonAtrasPortada);
            this.DoubleBuffered = true;
            this.Name = "ListarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.ListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button botonAtrasPortada;
        internal System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.DataGridView listarDataGridView;
        public System.Windows.Forms.ComboBox listarComboBox;
        public System.Windows.Forms.ComboBox listarFueraComboBox;
    }
}