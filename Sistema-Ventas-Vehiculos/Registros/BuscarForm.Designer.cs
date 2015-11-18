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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarForm));
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarLabel = new System.Windows.Forms.Label();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.buscarDataGridView = new System.Windows.Forms.DataGridView();
            this.sistemaVentasVehiculosDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Sistema_Ventas_VehiculosDataSet2 = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet2();
            this.sistemaVentasVehiculosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonAtrasPortada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasVehiculosDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasVehiculosDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Location = new System.Drawing.Point(12, 30);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(121, 21);
            this.buscarComboBox.TabIndex = 0;
            // 
            // BuscarLabel
            // 
            this.BuscarLabel.AutoSize = true;
            this.BuscarLabel.Location = new System.Drawing.Point(13, 11);
            this.BuscarLabel.Name = "BuscarLabel";
            this.BuscarLabel.Size = new System.Drawing.Size(62, 13);
            this.BuscarLabel.TabIndex = 1;
            this.BuscarLabel.Text = "Buscar Por:";
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(162, 30);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(130, 20);
            this.buscarTextBox.TabIndex = 2;
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.Location = new System.Drawing.Point(427, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(77, 54);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // buscarDataGridView
            // 
            this.buscarDataGridView.AllowUserToAddRows = false;
            this.buscarDataGridView.AllowUserToDeleteRows = false;
            this.buscarDataGridView.AutoGenerateColumns = false;
            this.buscarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarDataGridView.DataSource = this.sistemaVentasVehiculosDataSet2BindingSource;
            this.buscarDataGridView.Location = new System.Drawing.Point(16, 114);
            this.buscarDataGridView.Name = "buscarDataGridView";
            this.buscarDataGridView.ReadOnly = true;
            this.buscarDataGridView.Size = new System.Drawing.Size(368, 183);
            this.buscarDataGridView.TabIndex = 4;
            // 
            // sistemaVentasVehiculosDataSet2BindingSource
            // 
            this.sistemaVentasVehiculosDataSet2BindingSource.DataSource = this._Sistema_Ventas_VehiculosDataSet2;
            this.sistemaVentasVehiculosDataSet2BindingSource.Position = 0;
            // 
            // _Sistema_Ventas_VehiculosDataSet2
            // 
            this._Sistema_Ventas_VehiculosDataSet2.DataSetName = "_Sistema_Ventas_VehiculosDataSet2";
            this._Sistema_Ventas_VehiculosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(427, 243);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(77, 54);
            this.botonAtras.TabIndex = 32;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonAtrasPortada
            // 
            this.botonAtrasPortada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtrasPortada.BackgroundImage")));
            this.botonAtrasPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtrasPortada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtrasPortada.Location = new System.Drawing.Point(427, 243);
            this.botonAtrasPortada.Name = "botonAtrasPortada";
            this.botonAtrasPortada.Size = new System.Drawing.Size(77, 54);
            this.botonAtrasPortada.TabIndex = 33;
            this.botonAtrasPortada.UseVisualStyleBackColor = true;
            this.botonAtrasPortada.Click += new System.EventHandler(this.botonAtrasPortada_Click);
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 309);
            this.Controls.Add(this.botonAtrasPortada);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.buscarDataGridView);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.buscarTextBox);
            this.Controls.Add(this.BuscarLabel);
            this.Controls.Add(this.buscarComboBox);
            this.DoubleBuffered = true;
            this.Name = "BuscarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasVehiculosDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasVehiculosDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.Label BuscarLabel;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView buscarDataGridView;
        private System.Windows.Forms.BindingSource sistemaVentasVehiculosDataSet2BindingSource;
        private _Sistema_Ventas_VehiculosDataSet2 _Sistema_Ventas_VehiculosDataSet2;
        private System.Windows.Forms.BindingSource sistemaVentasVehiculosDataSetBindingSource;
        internal System.Windows.Forms.Button botonAtras;
        internal System.Windows.Forms.Button botonAtrasPortada;
    }
}