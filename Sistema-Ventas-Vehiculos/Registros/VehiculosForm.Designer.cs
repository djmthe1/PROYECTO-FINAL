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
            this.matriculaVehiculoLabel = new System.Windows.Forms.Label();
            this.placaVehiculoLabel = new System.Windows.Forms.Label();
            this.precioVehiculoLabel = new System.Windows.Forms.Label();
            this.kilometrajeVehiculoLabel = new System.Windows.Forms.Label();
            this.tipoVehiculoLabel = new System.Windows.Forms.Label();
            this.chasisVehiculoLabel = new System.Windows.Forms.Label();
            this.añoVehiculoLabel = new System.Windows.Forms.Label();
            this.colorVehiculoLabel = new System.Windows.Forms.Label();
            this.motorVehiculoLabel = new System.Windows.Forms.Label();
            this.marcaVehiculoLabel = new System.Windows.Forms.Label();
            this.modeloVehiculoLabel = new System.Windows.Forms.Label();
            this.estadoVehiculoLabel = new System.Windows.Forms.Label();
            this.matriculaVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.placaVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.precioVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.kilometrajeVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.tipoVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.chasisVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.añoVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.estadoVehiculoTextBox = new System.Windows.Forms.TextBox();
            this.vehiculoIdTextBox = new System.Windows.Forms.TextBox();
            this.vehiculoIdLabel = new System.Windows.Forms.Label();
            this.ModeloComboBox = new System.Windows.Forms.ComboBox();
            this.MotorComboBox = new System.Windows.Forms.ComboBox();
            this.MarcasComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(340, 370);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 29);
            this.botonEliminar.TabIndex = 22;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(248, 370);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 29);
            this.botonGuardar.TabIndex = 21;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(154, 370);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 29);
            this.botonNuevo.TabIndex = 20;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Location = new System.Drawing.Point(221, 21);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(33, 27);
            this.botonBuscar.TabIndex = 23;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAtras.BackgroundImage")));
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Location = new System.Drawing.Point(549, 357);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(51, 42);
            this.botonAtras.TabIndex = 32;
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // _Sistema_Ventas_VehiculosDataSet
            // 
            this._Sistema_Ventas_VehiculosDataSet.DataSetName = "_Sistema_Ventas_VehiculosDataSet";
            this._Sistema_Ventas_VehiculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.derechoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.derechoCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derechoCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.derechoCheckBox.Location = new System.Drawing.Point(66, 40);
            this.derechoCheckBox.Name = "derechoCheckBox";
            this.derechoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.derechoCheckBox.Size = new System.Drawing.Size(159, 20);
            this.derechoCheckBox.TabIndex = 34;
            this.derechoCheckBox.Text = "Espejo Retrovisor Derecho";
            this.derechoCheckBox.UseVisualStyleBackColor = false;
            // 
            // izquierdoCheckBox
            // 
            this.izquierdoCheckBox.AutoSize = true;
            this.izquierdoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.izquierdoCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierdoCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.izquierdoCheckBox.Location = new System.Drawing.Point(61, 78);
            this.izquierdoCheckBox.Name = "izquierdoCheckBox";
            this.izquierdoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.izquierdoCheckBox.Size = new System.Drawing.Size(164, 20);
            this.izquierdoCheckBox.TabIndex = 34;
            this.izquierdoCheckBox.Text = "Espejo Retrovisor Izquierdo";
            this.izquierdoCheckBox.UseVisualStyleBackColor = false;
            // 
            // radioCheckBox
            // 
            this.radioCheckBox.AutoSize = true;
            this.radioCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.radioCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioCheckBox.Location = new System.Drawing.Point(378, 59);
            this.radioCheckBox.Name = "radioCheckBox";
            this.radioCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCheckBox.Size = new System.Drawing.Size(56, 20);
            this.radioCheckBox.TabIndex = 34;
            this.radioCheckBox.Text = "Radio";
            this.radioCheckBox.UseVisualStyleBackColor = false;
            // 
            // gatoCheckBox
            // 
            this.gatoCheckBox.AutoSize = true;
            this.gatoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.gatoCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatoCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gatoCheckBox.Location = new System.Drawing.Point(382, 78);
            this.gatoCheckBox.Name = "gatoCheckBox";
            this.gatoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gatoCheckBox.Size = new System.Drawing.Size(52, 20);
            this.gatoCheckBox.TabIndex = 34;
            this.gatoCheckBox.Text = "Gato";
            this.gatoCheckBox.UseVisualStyleBackColor = false;
            // 
            // gomasCheckBox
            // 
            this.gomasCheckBox.AutoSize = true;
            this.gomasCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.gomasCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gomasCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gomasCheckBox.Location = new System.Drawing.Point(372, 40);
            this.gomasCheckBox.Name = "gomasCheckBox";
            this.gomasCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gomasCheckBox.Size = new System.Drawing.Size(62, 20);
            this.gomasCheckBox.TabIndex = 34;
            this.gomasCheckBox.Text = "Gomas";
            this.gomasCheckBox.UseVisualStyleBackColor = false;
            // 
            // gomaRepuestoCheckBox
            // 
            this.gomaRepuestoCheckBox.AutoSize = true;
            this.gomaRepuestoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.gomaRepuestoCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gomaRepuestoCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gomaRepuestoCheckBox.Location = new System.Drawing.Point(234, 78);
            this.gomaRepuestoCheckBox.Name = "gomaRepuestoCheckBox";
            this.gomaRepuestoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gomaRepuestoCheckBox.Size = new System.Drawing.Size(125, 20);
            this.gomaRepuestoCheckBox.TabIndex = 34;
            this.gomaRepuestoCheckBox.Text = "Goma De Repuesto";
            this.gomaRepuestoCheckBox.UseVisualStyleBackColor = false;
            // 
            // llaveDeRuedaCheckBox
            // 
            this.llaveDeRuedaCheckBox.AutoSize = true;
            this.llaveDeRuedaCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.llaveDeRuedaCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llaveDeRuedaCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llaveDeRuedaCheckBox.Location = new System.Drawing.Point(439, 59);
            this.llaveDeRuedaCheckBox.Name = "llaveDeRuedaCheckBox";
            this.llaveDeRuedaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.llaveDeRuedaCheckBox.Size = new System.Drawing.Size(107, 20);
            this.llaveDeRuedaCheckBox.TabIndex = 34;
            this.llaveDeRuedaCheckBox.Text = "Llave De Rueda";
            this.llaveDeRuedaCheckBox.UseVisualStyleBackColor = false;
            // 
            // alfombrasCheckBox
            // 
            this.alfombrasCheckBox.AutoSize = true;
            this.alfombrasCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.alfombrasCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alfombrasCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alfombrasCheckBox.Location = new System.Drawing.Point(467, 21);
            this.alfombrasCheckBox.Name = "alfombrasCheckBox";
            this.alfombrasCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alfombrasCheckBox.Size = new System.Drawing.Size(79, 20);
            this.alfombrasCheckBox.TabIndex = 34;
            this.alfombrasCheckBox.Text = "Alfombras";
            this.alfombrasCheckBox.UseVisualStyleBackColor = false;
            this.alfombrasCheckBox.CheckedChanged += new System.EventHandler(this.alfombrasCheckBox_CheckedChanged);
            // 
            // botiquinCheckBox
            // 
            this.botiquinCheckBox.AutoSize = true;
            this.botiquinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.botiquinCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botiquinCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botiquinCheckBox.Location = new System.Drawing.Point(365, 21);
            this.botiquinCheckBox.Name = "botiquinCheckBox";
            this.botiquinCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.botiquinCheckBox.Size = new System.Drawing.Size(69, 20);
            this.botiquinCheckBox.TabIndex = 34;
            this.botiquinCheckBox.Text = "Botiquin";
            this.botiquinCheckBox.UseVisualStyleBackColor = false;
            // 
            // taponGasolinaCheckBox
            // 
            this.taponGasolinaCheckBox.AutoSize = true;
            this.taponGasolinaCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.taponGasolinaCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taponGasolinaCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taponGasolinaCheckBox.Location = new System.Drawing.Point(236, 59);
            this.taponGasolinaCheckBox.Name = "taponGasolinaCheckBox";
            this.taponGasolinaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taponGasolinaCheckBox.Size = new System.Drawing.Size(123, 20);
            this.taponGasolinaCheckBox.TabIndex = 34;
            this.taponGasolinaCheckBox.Text = "Tapon De Gasolina";
            this.taponGasolinaCheckBox.UseVisualStyleBackColor = false;
            // 
            // taponRadiadorCheckBox
            // 
            this.taponRadiadorCheckBox.AutoSize = true;
            this.taponRadiadorCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.taponRadiadorCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taponRadiadorCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taponRadiadorCheckBox.Location = new System.Drawing.Point(235, 40);
            this.taponRadiadorCheckBox.Name = "taponRadiadorCheckBox";
            this.taponRadiadorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taponRadiadorCheckBox.Size = new System.Drawing.Size(124, 20);
            this.taponRadiadorCheckBox.TabIndex = 34;
            this.taponRadiadorCheckBox.Text = "Tapon De Radiador";
            this.taponRadiadorCheckBox.UseVisualStyleBackColor = false;
            // 
            // encendedorCheckBox
            // 
            this.encendedorCheckBox.AutoSize = true;
            this.encendedorCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.encendedorCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encendedorCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.encendedorCheckBox.Location = new System.Drawing.Point(461, 40);
            this.encendedorCheckBox.Name = "encendedorCheckBox";
            this.encendedorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.encendedorCheckBox.Size = new System.Drawing.Size(85, 20);
            this.encendedorCheckBox.TabIndex = 34;
            this.encendedorCheckBox.Text = "Encendedor";
            this.encendedorCheckBox.UseVisualStyleBackColor = false;
            // 
            // InternoCheckBox
            // 
            this.InternoCheckBox.AutoSize = true;
            this.InternoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.InternoCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternoCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InternoCheckBox.Location = new System.Drawing.Point(72, 59);
            this.InternoCheckBox.Name = "InternoCheckBox";
            this.InternoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InternoCheckBox.Size = new System.Drawing.Size(153, 20);
            this.InternoCheckBox.TabIndex = 34;
            this.InternoCheckBox.Text = "Espejo Retrovisor Interno";
            this.InternoCheckBox.UseVisualStyleBackColor = false;
            // 
            // manualCheckBox
            // 
            this.manualCheckBox.AutoSize = true;
            this.manualCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.manualCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manualCheckBox.Location = new System.Drawing.Point(235, 21);
            this.manualCheckBox.Name = "manualCheckBox";
            this.manualCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manualCheckBox.Size = new System.Drawing.Size(124, 20);
            this.manualCheckBox.TabIndex = 34;
            this.manualCheckBox.Text = "Manual De Usuario";
            this.manualCheckBox.UseVisualStyleBackColor = false;
            this.manualCheckBox.CheckedChanged += new System.EventHandler(this.manualCheckBox_CheckedChanged);
            // 
            // duplicadoLlaveCheckBox
            // 
            this.duplicadoLlaveCheckBox.AutoSize = true;
            this.duplicadoLlaveCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.duplicadoLlaveCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duplicadoLlaveCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.duplicadoLlaveCheckBox.Location = new System.Drawing.Point(28, 21);
            this.duplicadoLlaveCheckBox.Name = "duplicadoLlaveCheckBox";
            this.duplicadoLlaveCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.duplicadoLlaveCheckBox.Size = new System.Drawing.Size(197, 20);
            this.duplicadoLlaveCheckBox.TabIndex = 34;
            this.duplicadoLlaveCheckBox.Text = "Duplicado De Llave De Encendido";
            this.duplicadoLlaveCheckBox.UseVisualStyleBackColor = false;
            // 
            // matriculaVehiculoLabel
            // 
            this.matriculaVehiculoLabel.AutoSize = true;
            this.matriculaVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.matriculaVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.matriculaVehiculoLabel.Location = new System.Drawing.Point(249, 200);
            this.matriculaVehiculoLabel.Name = "matriculaVehiculoLabel";
            this.matriculaVehiculoLabel.Size = new System.Drawing.Size(60, 14);
            this.matriculaVehiculoLabel.TabIndex = 88;
            this.matriculaVehiculoLabel.Text = "Matricula";
            // 
            // placaVehiculoLabel
            // 
            this.placaVehiculoLabel.AutoSize = true;
            this.placaVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.placaVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.placaVehiculoLabel.Location = new System.Drawing.Point(2, 201);
            this.placaVehiculoLabel.Name = "placaVehiculoLabel";
            this.placaVehiculoLabel.Size = new System.Drawing.Size(57, 14);
            this.placaVehiculoLabel.TabIndex = 87;
            this.placaVehiculoLabel.Text = "Placa No.";
            // 
            // precioVehiculoLabel
            // 
            this.precioVehiculoLabel.AutoSize = true;
            this.precioVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.precioVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precioVehiculoLabel.Location = new System.Drawing.Point(3, 147);
            this.precioVehiculoLabel.Name = "precioVehiculoLabel";
            this.precioVehiculoLabel.Size = new System.Drawing.Size(43, 14);
            this.precioVehiculoLabel.TabIndex = 86;
            this.precioVehiculoLabel.Text = "Precio";
            // 
            // kilometrajeVehiculoLabel
            // 
            this.kilometrajeVehiculoLabel.AutoSize = true;
            this.kilometrajeVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.kilometrajeVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometrajeVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kilometrajeVehiculoLabel.Location = new System.Drawing.Point(249, 172);
            this.kilometrajeVehiculoLabel.Name = "kilometrajeVehiculoLabel";
            this.kilometrajeVehiculoLabel.Size = new System.Drawing.Size(73, 14);
            this.kilometrajeVehiculoLabel.TabIndex = 85;
            this.kilometrajeVehiculoLabel.Text = "Kilometraje";
            // 
            // tipoVehiculoLabel
            // 
            this.tipoVehiculoLabel.AutoSize = true;
            this.tipoVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.tipoVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tipoVehiculoLabel.Location = new System.Drawing.Point(249, 145);
            this.tipoVehiculoLabel.Name = "tipoVehiculoLabel";
            this.tipoVehiculoLabel.Size = new System.Drawing.Size(101, 14);
            this.tipoVehiculoLabel.TabIndex = 84;
            this.tipoVehiculoLabel.Text = "Tipo De Vehiculo";
            // 
            // chasisVehiculoLabel
            // 
            this.chasisVehiculoLabel.AutoSize = true;
            this.chasisVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.chasisVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chasisVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chasisVehiculoLabel.Location = new System.Drawing.Point(249, 61);
            this.chasisVehiculoLabel.Name = "chasisVehiculoLabel";
            this.chasisVehiculoLabel.Size = new System.Drawing.Size(64, 14);
            this.chasisVehiculoLabel.TabIndex = 83;
            this.chasisVehiculoLabel.Text = "Chasis No.";
            // 
            // añoVehiculoLabel
            // 
            this.añoVehiculoLabel.AutoSize = true;
            this.añoVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.añoVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añoVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.añoVehiculoLabel.Location = new System.Drawing.Point(3, 175);
            this.añoVehiculoLabel.Name = "añoVehiculoLabel";
            this.añoVehiculoLabel.Size = new System.Drawing.Size(29, 14);
            this.añoVehiculoLabel.TabIndex = 82;
            this.añoVehiculoLabel.Text = "Año";
            // 
            // colorVehiculoLabel
            // 
            this.colorVehiculoLabel.AutoSize = true;
            this.colorVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorVehiculoLabel.Location = new System.Drawing.Point(251, 117);
            this.colorVehiculoLabel.Name = "colorVehiculoLabel";
            this.colorVehiculoLabel.Size = new System.Drawing.Size(38, 14);
            this.colorVehiculoLabel.TabIndex = 81;
            this.colorVehiculoLabel.Text = "Color";
            // 
            // motorVehiculoLabel
            // 
            this.motorVehiculoLabel.AutoSize = true;
            this.motorVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.motorVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motorVehiculoLabel.Location = new System.Drawing.Point(250, 88);
            this.motorVehiculoLabel.Name = "motorVehiculoLabel";
            this.motorVehiculoLabel.Size = new System.Drawing.Size(41, 14);
            this.motorVehiculoLabel.TabIndex = 80;
            this.motorVehiculoLabel.Text = "Motor";
            // 
            // marcaVehiculoLabel
            // 
            this.marcaVehiculoLabel.AutoSize = true;
            this.marcaVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.marcaVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marcaVehiculoLabel.Location = new System.Drawing.Point(3, 117);
            this.marcaVehiculoLabel.Name = "marcaVehiculoLabel";
            this.marcaVehiculoLabel.Size = new System.Drawing.Size(41, 14);
            this.marcaVehiculoLabel.TabIndex = 79;
            this.marcaVehiculoLabel.Text = "Marca";
            // 
            // modeloVehiculoLabel
            // 
            this.modeloVehiculoLabel.AutoSize = true;
            this.modeloVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.modeloVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeloVehiculoLabel.Location = new System.Drawing.Point(3, 91);
            this.modeloVehiculoLabel.Name = "modeloVehiculoLabel";
            this.modeloVehiculoLabel.Size = new System.Drawing.Size(48, 14);
            this.modeloVehiculoLabel.TabIndex = 78;
            this.modeloVehiculoLabel.Text = "Modelo";
            // 
            // estadoVehiculoLabel
            // 
            this.estadoVehiculoLabel.AutoSize = true;
            this.estadoVehiculoLabel.BackColor = System.Drawing.Color.Transparent;
            this.estadoVehiculoLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoVehiculoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.estadoVehiculoLabel.Location = new System.Drawing.Point(0, 63);
            this.estadoVehiculoLabel.Name = "estadoVehiculoLabel";
            this.estadoVehiculoLabel.Size = new System.Drawing.Size(116, 14);
            this.estadoVehiculoLabel.TabIndex = 77;
            this.estadoVehiculoLabel.Text = "Estado Del Vehiculo";
            // 
            // matriculaVehiculoTextBox
            // 
            this.matriculaVehiculoTextBox.Location = new System.Drawing.Point(350, 195);
            this.matriculaVehiculoTextBox.Name = "matriculaVehiculoTextBox";
            this.matriculaVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.matriculaVehiculoTextBox.TabIndex = 76;
            // 
            // placaVehiculoTextBox
            // 
            this.placaVehiculoTextBox.Location = new System.Drawing.Point(117, 197);
            this.placaVehiculoTextBox.Name = "placaVehiculoTextBox";
            this.placaVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.placaVehiculoTextBox.TabIndex = 75;
            // 
            // precioVehiculoTextBox
            // 
            this.precioVehiculoTextBox.Location = new System.Drawing.Point(117, 142);
            this.precioVehiculoTextBox.Name = "precioVehiculoTextBox";
            this.precioVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.precioVehiculoTextBox.TabIndex = 74;
            // 
            // kilometrajeVehiculoTextBox
            // 
            this.kilometrajeVehiculoTextBox.Location = new System.Drawing.Point(350, 169);
            this.kilometrajeVehiculoTextBox.Name = "kilometrajeVehiculoTextBox";
            this.kilometrajeVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.kilometrajeVehiculoTextBox.TabIndex = 73;
            // 
            // tipoVehiculoTextBox
            // 
            this.tipoVehiculoTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tipoVehiculoTextBox.Location = new System.Drawing.Point(350, 143);
            this.tipoVehiculoTextBox.Name = "tipoVehiculoTextBox";
            this.tipoVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.tipoVehiculoTextBox.TabIndex = 72;
            // 
            // chasisVehiculoTextBox
            // 
            this.chasisVehiculoTextBox.Location = new System.Drawing.Point(350, 58);
            this.chasisVehiculoTextBox.Name = "chasisVehiculoTextBox";
            this.chasisVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.chasisVehiculoTextBox.TabIndex = 71;
            // 
            // añoVehiculoTextBox
            // 
            this.añoVehiculoTextBox.Location = new System.Drawing.Point(117, 169);
            this.añoVehiculoTextBox.Name = "añoVehiculoTextBox";
            this.añoVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.añoVehiculoTextBox.TabIndex = 70;
            // 
            // estadoVehiculoTextBox
            // 
            this.estadoVehiculoTextBox.Location = new System.Drawing.Point(117, 58);
            this.estadoVehiculoTextBox.Name = "estadoVehiculoTextBox";
            this.estadoVehiculoTextBox.Size = new System.Drawing.Size(101, 20);
            this.estadoVehiculoTextBox.TabIndex = 65;
            // 
            // vehiculoIdTextBox
            // 
            this.vehiculoIdTextBox.Location = new System.Drawing.Point(117, 25);
            this.vehiculoIdTextBox.Name = "vehiculoIdTextBox";
            this.vehiculoIdTextBox.Size = new System.Drawing.Size(101, 20);
            this.vehiculoIdTextBox.TabIndex = 64;
            // 
            // vehiculoIdLabel
            // 
            this.vehiculoIdLabel.AutoSize = true;
            this.vehiculoIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.vehiculoIdLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiculoIdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vehiculoIdLabel.Location = new System.Drawing.Point(2, 27);
            this.vehiculoIdLabel.Name = "vehiculoIdLabel";
            this.vehiculoIdLabel.Size = new System.Drawing.Size(66, 14);
            this.vehiculoIdLabel.TabIndex = 63;
            this.vehiculoIdLabel.Text = "VehiculoId";
            // 
            // ModeloComboBox
            // 
            this.ModeloComboBox.FormattingEnabled = true;
            this.ModeloComboBox.Location = new System.Drawing.Point(117, 85);
            this.ModeloComboBox.Name = "ModeloComboBox";
            this.ModeloComboBox.Size = new System.Drawing.Size(101, 21);
            this.ModeloComboBox.TabIndex = 89;
            // 
            // MotorComboBox
            // 
            this.MotorComboBox.FormattingEnabled = true;
            this.MotorComboBox.Location = new System.Drawing.Point(350, 85);
            this.MotorComboBox.Name = "MotorComboBox";
            this.MotorComboBox.Size = new System.Drawing.Size(101, 21);
            this.MotorComboBox.TabIndex = 91;
            // 
            // MarcasComboBox
            // 
            this.MarcasComboBox.FormattingEnabled = true;
            this.MarcasComboBox.Location = new System.Drawing.Point(117, 114);
            this.MarcasComboBox.Name = "MarcasComboBox";
            this.MarcasComboBox.Size = new System.Drawing.Size(101, 21);
            this.MarcasComboBox.TabIndex = 92;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(350, 116);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(101, 21);
            this.ColorComboBox.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.izquierdoCheckBox);
            this.panel1.Controls.Add(this.InternoCheckBox);
            this.panel1.Controls.Add(this.radioCheckBox);
            this.panel1.Controls.Add(this.gatoCheckBox);
            this.panel1.Controls.Add(this.gomasCheckBox);
            this.panel1.Controls.Add(this.gomaRepuestoCheckBox);
            this.panel1.Controls.Add(this.llaveDeRuedaCheckBox);
            this.panel1.Controls.Add(this.alfombrasCheckBox);
            this.panel1.Controls.Add(this.botiquinCheckBox);
            this.panel1.Controls.Add(this.taponGasolinaCheckBox);
            this.panel1.Controls.Add(this.taponRadiadorCheckBox);
            this.panel1.Controls.Add(this.encendedorCheckBox);
            this.panel1.Controls.Add(this.manualCheckBox);
            this.panel1.Controls.Add(this.duplicadoLlaveCheckBox);
            this.panel1.Controls.Add(this.derechoCheckBox);
            this.panel1.Location = new System.Drawing.Point(6, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 122);
            this.panel1.TabIndex = 94;
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.MarcasComboBox);
            this.Controls.Add(this.MotorComboBox);
            this.Controls.Add(this.ModeloComboBox);
            this.Controls.Add(this.matriculaVehiculoLabel);
            this.Controls.Add(this.placaVehiculoLabel);
            this.Controls.Add(this.precioVehiculoLabel);
            this.Controls.Add(this.kilometrajeVehiculoLabel);
            this.Controls.Add(this.tipoVehiculoLabel);
            this.Controls.Add(this.chasisVehiculoLabel);
            this.Controls.Add(this.añoVehiculoLabel);
            this.Controls.Add(this.colorVehiculoLabel);
            this.Controls.Add(this.motorVehiculoLabel);
            this.Controls.Add(this.marcaVehiculoLabel);
            this.Controls.Add(this.modeloVehiculoLabel);
            this.Controls.Add(this.estadoVehiculoLabel);
            this.Controls.Add(this.matriculaVehiculoTextBox);
            this.Controls.Add(this.placaVehiculoTextBox);
            this.Controls.Add(this.precioVehiculoTextBox);
            this.Controls.Add(this.kilometrajeVehiculoTextBox);
            this.Controls.Add(this.tipoVehiculoTextBox);
            this.Controls.Add(this.chasisVehiculoTextBox);
            this.Controls.Add(this.añoVehiculoTextBox);
            this.Controls.Add(this.estadoVehiculoTextBox);
            this.Controls.Add(this.vehiculoIdTextBox);
            this.Controls.Add(this.vehiculoIdLabel);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonNuevo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VehiculosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.VehiculosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Sistema_Ventas_VehiculosDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label matriculaVehiculoLabel;
        private System.Windows.Forms.Label placaVehiculoLabel;
        private System.Windows.Forms.Label precioVehiculoLabel;
        private System.Windows.Forms.Label kilometrajeVehiculoLabel;
        private System.Windows.Forms.Label tipoVehiculoLabel;
        private System.Windows.Forms.Label chasisVehiculoLabel;
        private System.Windows.Forms.Label añoVehiculoLabel;
        private System.Windows.Forms.Label colorVehiculoLabel;
        private System.Windows.Forms.Label motorVehiculoLabel;
        private System.Windows.Forms.Label marcaVehiculoLabel;
        private System.Windows.Forms.Label modeloVehiculoLabel;
        private System.Windows.Forms.Label estadoVehiculoLabel;
        private System.Windows.Forms.TextBox matriculaVehiculoTextBox;
        private System.Windows.Forms.TextBox placaVehiculoTextBox;
        private System.Windows.Forms.TextBox precioVehiculoTextBox;
        private System.Windows.Forms.TextBox kilometrajeVehiculoTextBox;
        private System.Windows.Forms.TextBox tipoVehiculoTextBox;
        private System.Windows.Forms.TextBox chasisVehiculoTextBox;
        private System.Windows.Forms.TextBox añoVehiculoTextBox;
        private System.Windows.Forms.TextBox estadoVehiculoTextBox;
        private System.Windows.Forms.TextBox vehiculoIdTextBox;
        private System.Windows.Forms.Label vehiculoIdLabel;
        private System.Windows.Forms.ComboBox ModeloComboBox;
        private System.Windows.Forms.ComboBox MotorComboBox;
        private System.Windows.Forms.ComboBox MarcasComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Panel panel1;
    }
}