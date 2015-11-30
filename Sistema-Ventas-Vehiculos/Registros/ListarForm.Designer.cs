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
            this.listarDataGridView = new System.Windows.Forms.DataGridView();
            this.listarComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listarDataGridView
            // 
            this.listarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarDataGridView.Location = new System.Drawing.Point(12, 76);
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
            this.listarComboBox.Location = new System.Drawing.Point(12, 35);
            this.listarComboBox.Name = "listarComboBox";
            this.listarComboBox.Size = new System.Drawing.Size(94, 21);
            this.listarComboBox.TabIndex = 37;
            this.listarComboBox.Text = "Buscar por . . .";
            this.listarComboBox.SelectedIndexChanged += new System.EventHandler(this.listarComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "LISTADO";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Marcas",
            "Modelos",
            "Colores",
            "Tipos de Vehiculos",
            "Tipos de Motores",
            "Vehiculos"});
            this.FiltroComboBox.Location = new System.Drawing.Point(112, 35);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(94, 21);
            this.FiltroComboBox.TabIndex = 39;
            this.FiltroComboBox.Text = "Filtrar por . . .";
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // ListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 275);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listarComboBox);
            this.Controls.Add(this.listarDataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ListarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.ListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listarDataGridView;
        public System.Windows.Forms.ComboBox listarComboBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox FiltroComboBox;
    }
}