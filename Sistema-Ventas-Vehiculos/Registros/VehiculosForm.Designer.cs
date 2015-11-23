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
            this.coloresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Sistema_Ventas_VehiculosDataSet3 = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet3();
            this.coloresTableAdapter = new Sistema_Ventas_Vehiculos._Sistema_Ventas_VehiculosDataSet3TableAdapters.ColoresTableAdapter();
            this.derechoCheckBox = new System.Windows.Forms.CheckBox();
            this.izquierdoCheckBox = new System.Windows.Forms.CheckBox();
            this.radioCheckBox = new System.Windows.Forms.CheckBox();
            this.gatoCheckBox = new System.Windows.Forms.CheckBox();
            this.gomasCheckBox = new System.Windows.Forms.CheckBox();
            this.gomaRepuestoCheckBox = new System.Windows.Forms.CheckBox();
            this.llaveDeRuedaCheckBox = new System.Windows.Forms.CheckBox();
            this.alfombrasCheckBox = new System.Windows.Forms.CheckBox();
            this.botiquinCheckBox = new System.Windows.Forms.CheckBox();
            this.taponGasolinaCheckBox = new System.Windows.Forms.CheckBox();
            this.taponRadiadorCheckBox = new System.Windows.Forms.CheckBox();
            this.encendedorCheckBox = new System.Windows.Forms.CheckBox();
            this.InternoCheckBox = new System.Windows.Forms.CheckBox();
            this.manualCheckBox = new System.Windows.Forms.CheckBox();
            this.duplicadoLlaveCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet3)).BeginInit();
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
            this.botonBuscar.Location = new System.Drawing.Point(12, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(52, 36);
            this.botonBuscar.TabIndex = 23;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(634, 357);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(49, 36);
            this.botonAtras.TabIndex = 32;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(12, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "Descripcion";
            // 
            // coloresBindingSource
            // 
            this.coloresBindingSource.DataMember = "Colores";
            this.coloresBindingSource.DataSource = this._Sistema_Ventas_VehiculosDataSet3;
            // 
            // _Sistema_Ventas_VehiculosDataSet3
            // 
            this._Sistema_Ventas_VehiculosDataSet3.DataSetName = "_Sistema_Ventas_VehiculosDataSet3";
            this._Sistema_Ventas_VehiculosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloresTableAdapter
            // 
            this.coloresTableAdapter.ClearBeforeFill = true;
            // 
            // derechoCheckBox
            // 
            this.derechoCheckBox.AutoSize = true;
            this.derechoCheckBox.Location = new System.Drawing.Point(527, 58);
            this.derechoCheckBox.Name = "derechoCheckBox";
            this.derechoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.derechoCheckBox.Size = new System.Drawing.Size(153, 17);
            this.derechoCheckBox.TabIndex = 34;
            this.derechoCheckBox.Text = "Espejo Retrovisor Derecho";
            this.derechoCheckBox.UseVisualStyleBackColor = true;
            // 
            // izquierdoCheckBox
            // 
            this.izquierdoCheckBox.AutoSize = true;
            this.izquierdoCheckBox.Location = new System.Drawing.Point(525, 35);
            this.izquierdoCheckBox.Name = "izquierdoCheckBox";
            this.izquierdoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.izquierdoCheckBox.Size = new System.Drawing.Size(155, 17);
            this.izquierdoCheckBox.TabIndex = 34;
            this.izquierdoCheckBox.Text = "Espejo Retrovisor Izquierdo";
            this.izquierdoCheckBox.UseVisualStyleBackColor = true;
            // 
            // radioCheckBox
            // 
            this.radioCheckBox.AutoSize = true;
            this.radioCheckBox.Location = new System.Drawing.Point(626, 311);
            this.radioCheckBox.Name = "radioCheckBox";
            this.radioCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCheckBox.Size = new System.Drawing.Size(54, 17);
            this.radioCheckBox.TabIndex = 34;
            this.radioCheckBox.Text = "Radio";
            this.radioCheckBox.UseVisualStyleBackColor = true;
            // 
            // gatoCheckBox
            // 
            this.gatoCheckBox.AutoSize = true;
            this.gatoCheckBox.Location = new System.Drawing.Point(631, 334);
            this.gatoCheckBox.Name = "gatoCheckBox";
            this.gatoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gatoCheckBox.Size = new System.Drawing.Size(49, 17);
            this.gatoCheckBox.TabIndex = 34;
            this.gatoCheckBox.Text = "Gato";
            this.gatoCheckBox.UseVisualStyleBackColor = true;
            // 
            // gomasCheckBox
            // 
            this.gomasCheckBox.AutoSize = true;
            this.gomasCheckBox.Location = new System.Drawing.Point(621, 288);
            this.gomasCheckBox.Name = "gomasCheckBox";
            this.gomasCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gomasCheckBox.Size = new System.Drawing.Size(59, 17);
            this.gomasCheckBox.TabIndex = 34;
            this.gomasCheckBox.Text = "Gomas";
            this.gomasCheckBox.UseVisualStyleBackColor = true;
            // 
            // gomaRepuestoCheckBox
            // 
            this.gomaRepuestoCheckBox.AutoSize = true;
            this.gomaRepuestoCheckBox.Location = new System.Drawing.Point(560, 173);
            this.gomaRepuestoCheckBox.Name = "gomaRepuestoCheckBox";
            this.gomaRepuestoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gomaRepuestoCheckBox.Size = new System.Drawing.Size(120, 17);
            this.gomaRepuestoCheckBox.TabIndex = 34;
            this.gomaRepuestoCheckBox.Text = "Goma De Repuesto";
            this.gomaRepuestoCheckBox.UseVisualStyleBackColor = true;
            // 
            // llaveDeRuedaCheckBox
            // 
            this.llaveDeRuedaCheckBox.AutoSize = true;
            this.llaveDeRuedaCheckBox.Location = new System.Drawing.Point(576, 196);
            this.llaveDeRuedaCheckBox.Name = "llaveDeRuedaCheckBox";
            this.llaveDeRuedaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.llaveDeRuedaCheckBox.Size = new System.Drawing.Size(104, 17);
            this.llaveDeRuedaCheckBox.TabIndex = 34;
            this.llaveDeRuedaCheckBox.Text = "Llave De Rueda";
            this.llaveDeRuedaCheckBox.UseVisualStyleBackColor = true;
            // 
            // alfombrasCheckBox
            // 
            this.alfombrasCheckBox.AutoSize = true;
            this.alfombrasCheckBox.Location = new System.Drawing.Point(608, 242);
            this.alfombrasCheckBox.Name = "alfombrasCheckBox";
            this.alfombrasCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alfombrasCheckBox.Size = new System.Drawing.Size(72, 17);
            this.alfombrasCheckBox.TabIndex = 34;
            this.alfombrasCheckBox.Text = "Alfombras";
            this.alfombrasCheckBox.UseVisualStyleBackColor = true;
            this.alfombrasCheckBox.CheckedChanged += new System.EventHandler(this.alfombrasCheckBox_CheckedChanged);
            // 
            // botiquinCheckBox
            // 
            this.botiquinCheckBox.AutoSize = true;
            this.botiquinCheckBox.Location = new System.Drawing.Point(616, 265);
            this.botiquinCheckBox.Name = "botiquinCheckBox";
            this.botiquinCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.botiquinCheckBox.Size = new System.Drawing.Size(64, 17);
            this.botiquinCheckBox.TabIndex = 34;
            this.botiquinCheckBox.Text = "Botiquin";
            this.botiquinCheckBox.UseVisualStyleBackColor = true;
            // 
            // taponGasolinaCheckBox
            // 
            this.taponGasolinaCheckBox.AutoSize = true;
            this.taponGasolinaCheckBox.Location = new System.Drawing.Point(562, 127);
            this.taponGasolinaCheckBox.Name = "taponGasolinaCheckBox";
            this.taponGasolinaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taponGasolinaCheckBox.Size = new System.Drawing.Size(118, 17);
            this.taponGasolinaCheckBox.TabIndex = 34;
            this.taponGasolinaCheckBox.Text = "Tapon De Gasolina";
            this.taponGasolinaCheckBox.UseVisualStyleBackColor = true;
            // 
            // taponRadiadorCheckBox
            // 
            this.taponRadiadorCheckBox.AutoSize = true;
            this.taponRadiadorCheckBox.Location = new System.Drawing.Point(560, 104);
            this.taponRadiadorCheckBox.Name = "taponRadiadorCheckBox";
            this.taponRadiadorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taponRadiadorCheckBox.Size = new System.Drawing.Size(120, 17);
            this.taponRadiadorCheckBox.TabIndex = 34;
            this.taponRadiadorCheckBox.Text = "Tapon De Radiador";
            this.taponRadiadorCheckBox.UseVisualStyleBackColor = true;
            // 
            // encendedorCheckBox
            // 
            this.encendedorCheckBox.AutoSize = true;
            this.encendedorCheckBox.Location = new System.Drawing.Point(596, 219);
            this.encendedorCheckBox.Name = "encendedorCheckBox";
            this.encendedorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.encendedorCheckBox.Size = new System.Drawing.Size(84, 17);
            this.encendedorCheckBox.TabIndex = 34;
            this.encendedorCheckBox.Text = "Encendedor";
            this.encendedorCheckBox.UseVisualStyleBackColor = true;
            // 
            // InternoCheckBox
            // 
            this.InternoCheckBox.AutoSize = true;
            this.InternoCheckBox.Location = new System.Drawing.Point(535, 81);
            this.InternoCheckBox.Name = "InternoCheckBox";
            this.InternoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InternoCheckBox.Size = new System.Drawing.Size(145, 17);
            this.InternoCheckBox.TabIndex = 34;
            this.InternoCheckBox.Text = "Espejo Retrovisor Interno";
            this.InternoCheckBox.UseVisualStyleBackColor = true;
            // 
            // manualCheckBox
            // 
            this.manualCheckBox.AutoSize = true;
            this.manualCheckBox.Location = new System.Drawing.Point(563, 150);
            this.manualCheckBox.Name = "manualCheckBox";
            this.manualCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manualCheckBox.Size = new System.Drawing.Size(117, 17);
            this.manualCheckBox.TabIndex = 34;
            this.manualCheckBox.Text = "Manual De Usuario";
            this.manualCheckBox.UseVisualStyleBackColor = true;
            // 
            // duplicadoLlaveCheckBox
            // 
            this.duplicadoLlaveCheckBox.AutoSize = true;
            this.duplicadoLlaveCheckBox.Location = new System.Drawing.Point(489, 12);
            this.duplicadoLlaveCheckBox.Name = "duplicadoLlaveCheckBox";
            this.duplicadoLlaveCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.duplicadoLlaveCheckBox.Size = new System.Drawing.Size(191, 17);
            this.duplicadoLlaveCheckBox.TabIndex = 34;
            this.duplicadoLlaveCheckBox.Text = "Duplicado De Llave De Encendido";
            this.duplicadoLlaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 405);
            this.Controls.Add(this.duplicadoLlaveCheckBox);
            this.Controls.Add(this.manualCheckBox);
            this.Controls.Add(this.encendedorCheckBox);
            this.Controls.Add(this.taponRadiadorCheckBox);
            this.Controls.Add(this.taponGasolinaCheckBox);
            this.Controls.Add(this.botiquinCheckBox);
            this.Controls.Add(this.alfombrasCheckBox);
            this.Controls.Add(this.llaveDeRuedaCheckBox);
            this.Controls.Add(this.gomaRepuestoCheckBox);
            this.Controls.Add(this.gomasCheckBox);
            this.Controls.Add(this.gatoCheckBox);
            this.Controls.Add(this.radioCheckBox);
            this.Controls.Add(this.izquierdoCheckBox);
            this.Controls.Add(this.InternoCheckBox);
            this.Controls.Add(this.derechoCheckBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox derechoCheckBox;
        private System.Windows.Forms.CheckBox izquierdoCheckBox;
        private System.Windows.Forms.CheckBox radioCheckBox;
        private System.Windows.Forms.CheckBox gatoCheckBox;
        private System.Windows.Forms.CheckBox gomasCheckBox;
        private System.Windows.Forms.CheckBox gomaRepuestoCheckBox;
        private System.Windows.Forms.CheckBox llaveDeRuedaCheckBox;
        private System.Windows.Forms.CheckBox alfombrasCheckBox;
        private System.Windows.Forms.CheckBox botiquinCheckBox;
        private System.Windows.Forms.CheckBox taponGasolinaCheckBox;
        private System.Windows.Forms.CheckBox taponRadiadorCheckBox;
        private System.Windows.Forms.CheckBox encendedorCheckBox;
        private System.Windows.Forms.CheckBox InternoCheckBox;
        private System.Windows.Forms.CheckBox manualCheckBox;
        private System.Windows.Forms.CheckBox duplicadoLlaveCheckBox;
    }
}