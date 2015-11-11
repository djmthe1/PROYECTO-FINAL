namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class MarcasForm
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
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.MarcasIDtextBox = new System.Windows.Forms.TextBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.listarDataGridView = new System.Windows.Forms.DataGridView();
            this.marcaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Sistema_Ventas_VehiculosDataSet = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet();
            this.marcasTableAdapter = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSetTableAdapters.MarcasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(103, 49);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(81, 20);
            this.DescripciontextBox.TabIndex = 10;
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(29, 49);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 11;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(12, 214);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 13;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(103, 214);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 14;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click_1);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(29, 9);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(16, 13);
            this.IDlabel.TabIndex = 9;
            this.IDlabel.Text = "Id";
            // 
            // MarcasIDtextBox
            // 
            this.MarcasIDtextBox.Location = new System.Drawing.Point(103, 12);
            this.MarcasIDtextBox.Name = "MarcasIDtextBox";
            this.MarcasIDtextBox.Size = new System.Drawing.Size(51, 20);
            this.MarcasIDtextBox.TabIndex = 12;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(195, 214);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 15;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // listarDataGridView
            // 
            this.listarDataGridView.AutoGenerateColumns = false;
            this.listarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaIdDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.listarDataGridView.DataSource = this.marcasBindingSource;
            this.listarDataGridView.Location = new System.Drawing.Point(12, 92);
            this.listarDataGridView.Name = "listarDataGridView";
            this.listarDataGridView.Size = new System.Drawing.Size(247, 116);
            this.listarDataGridView.TabIndex = 16;
            this.listarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listarDataGridView_CellContentClick);
            // 
            // marcaIdDataGridViewTextBoxColumn
            // 
            this.marcaIdDataGridViewTextBoxColumn.DataPropertyName = "MarcaId";
            this.marcaIdDataGridViewTextBoxColumn.HeaderText = "MarcaId";
            this.marcaIdDataGridViewTextBoxColumn.Name = "marcaIdDataGridViewTextBoxColumn";
            this.marcaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this._Sistema_Ventas_VehiculosDataSet;
            // 
            // _Sistema_Ventas_VehiculosDataSet
            // 
            this._Sistema_Ventas_VehiculosDataSet.DataSetName = "_Sistema_Ventas_VehiculosDataSet";
            this._Sistema_Ventas_VehiculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // MarcasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 249);
            this.Controls.Add(this.listarDataGridView);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.MarcasIDtextBox);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.IDlabel);
            this.Name = "MarcasForm";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.MarcasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox MarcasIDtextBox;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.DataGridView listarDataGridView;
        private _Sistema_Ventas_VehiculosDataSet _Sistema_Ventas_VehiculosDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private _Sistema_Ventas_VehiculosDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}