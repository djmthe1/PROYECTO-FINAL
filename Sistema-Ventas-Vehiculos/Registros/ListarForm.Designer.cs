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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarForm));
            this.botonAtrasPortada = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.listarDataGridView = new System.Windows.Forms.DataGridView();
            this._Sistema_Ventas_VehiculosDataSet2 = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet2();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet2TableAdapters.VehiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
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
            // _Sistema_Ventas_VehiculosDataSet2
            // 
            this._Sistema_Ventas_VehiculosDataSet2.DataSetName = "_Sistema_Ventas_VehiculosDataSet2";
            this._Sistema_Ventas_VehiculosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this._Sistema_Ventas_VehiculosDataSet2;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // ListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 318);
            this.Controls.Add(this.listarDataGridView);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonAtrasPortada);
            this.DoubleBuffered = true;
            this.Name = "ListarForm";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.ListarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button botonAtrasPortada;
        internal System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.DataGridView listarDataGridView;
        private _Sistema_Ventas_VehiculosDataSet2 _Sistema_Ventas_VehiculosDataSet2;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private _Sistema_Ventas_VehiculosDataSet2TableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
    }
}