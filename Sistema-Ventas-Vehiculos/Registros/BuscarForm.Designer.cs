namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class BuscarForm
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
            this.buscarDataGridView = new System.Windows.Forms.DataGridView();
            this.buscarLabel = new System.Windows.Forms.Label();
            this.buscarPorLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarDataGridView
            // 
            this.buscarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarDataGridView.Location = new System.Drawing.Point(12, 88);
            this.buscarDataGridView.Name = "buscarDataGridView";
            this.buscarDataGridView.ReadOnly = true;
            this.buscarDataGridView.Size = new System.Drawing.Size(381, 199);
            this.buscarDataGridView.TabIndex = 37;
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarLabel.Location = new System.Drawing.Point(340, 9);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(114, 37);
            this.buscarLabel.TabIndex = 38;
            this.buscarLabel.Text = "Buscador";
            // 
            // buscarPorLabel
            // 
            this.buscarPorLabel.AutoSize = true;
            this.buscarPorLabel.Location = new System.Drawing.Point(12, 33);
            this.buscarPorLabel.Name = "buscarPorLabel";
            this.buscarPorLabel.Size = new System.Drawing.Size(62, 13);
            this.buscarPorLabel.TabIndex = 39;
            this.buscarPorLabel.Text = "Buscar Por:";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(150, 33);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.descripcionLabel.TabIndex = 40;
            this.descripcionLabel.Text = "Descripcion";
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Tipo de motor",
            "Tipo de vehiculo",
            "Color"});
            this.buscarComboBox.Location = new System.Drawing.Point(15, 61);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(121, 21);
            this.buscarComboBox.TabIndex = 41;
            this.buscarComboBox.SelectedIndexChanged += new System.EventHandler(this.buscarComboBox_SelectedIndexChanged);
            // 
            // descripcionComboBox
            // 
            this.descripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descripcionComboBox.FormattingEnabled = true;
            this.descripcionComboBox.Location = new System.Drawing.Point(153, 61);
            this.descripcionComboBox.Name = "descripcionComboBox";
            this.descripcionComboBox.Size = new System.Drawing.Size(121, 21);
            this.descripcionComboBox.TabIndex = 42;
            this.descripcionComboBox.SelectedIndexChanged += new System.EventHandler(this.descripcionComboBox_SelectedIndexChanged);
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 299);
            this.Controls.Add(this.descripcionComboBox);
            this.Controls.Add(this.buscarComboBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.buscarPorLabel);
            this.Controls.Add(this.buscarLabel);
            this.Controls.Add(this.buscarDataGridView);
            this.Name = "BuscarForm";
            this.Text = "BuscarForm";
            this.Load += new System.EventHandler(this.BuscarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView buscarDataGridView;
        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.Label buscarPorLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.ComboBox descripcionComboBox;
    }
}