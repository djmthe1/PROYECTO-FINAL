namespace Sistema_Ventas_Vehiculos.Registros
{
    partial class VehiculosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculosForm));
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this._Sistema_Ventas_VehiculosDataSet = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._Sistema_Ventas_VehiculosDataSet3 = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet3();
            this.coloresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coloresTableAdapter = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet3TableAdapters.ColoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(406, 370);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 22;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(314, 370);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 21;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(220, 370);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 20;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Location = new System.Drawing.Point(628, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(52, 43);
            this.botonBuscar.TabIndex = 23;
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(628, 350);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(52, 43);
            this.botonAtras.TabIndex = 32;
            this.botonAtras.UseVisualStyleBackColor = true;
            // 
            // _Sistema_Ventas_VehiculosDataSet
            // 
            this._Sistema_Ventas_VehiculosDataSet.DataSetName = "_Sistema_Ventas_VehiculosDataSet";
            this._Sistema_Ventas_VehiculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coloresBindingSource, "Descripcion", true));
            this.comboBox1.DataSource = this.coloresBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "Descripcion";
            // 
            // _Sistema_Ventas_VehiculosDataSet3
            // 
            this._Sistema_Ventas_VehiculosDataSet3.DataSetName = "_Sistema_Ventas_VehiculosDataSet3";
            this._Sistema_Ventas_VehiculosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloresBindingSource
            // 
            this.coloresBindingSource.DataMember = "Colores";
            this.coloresBindingSource.DataSource = this._Sistema_Ventas_VehiculosDataSet3;
            // 
            // coloresTableAdapter
            // 
            this.coloresTableAdapter.ClearBeforeFill = true;
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonNuevo);
            this.Name = "VehiculosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.VehiculosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonAtras;
        private _Sistema_Ventas_VehiculosDataSet _Sistema_Ventas_VehiculosDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private _Sistema_Ventas_VehiculosDataSet3 _Sistema_Ventas_VehiculosDataSet3;
        private System.Windows.Forms.BindingSource coloresBindingSource;
        private _Sistema_Ventas_VehiculosDataSet3TableAdapters.ColoresTableAdapter coloresTableAdapter;
    }
}