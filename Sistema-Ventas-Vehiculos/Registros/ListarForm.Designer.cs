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
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.CbFiltro = new System.Windows.Forms.ComboBox();
            this.CbFiltro2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // DataListado
            // 
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Location = new System.Drawing.Point(12, 100);
            this.DataListado.Name = "DataListado";
            this.DataListado.Size = new System.Drawing.Size(412, 150);
            this.DataListado.TabIndex = 0;
            // 
            // CbFiltro
            // 
            this.CbFiltro.FormattingEnabled = true;
            this.CbFiltro.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Tipo de motor",
            "Tipo de vehiculo",
            "Color"});
            this.CbFiltro.Location = new System.Drawing.Point(13, 61);
            this.CbFiltro.Name = "CbFiltro";
            this.CbFiltro.Size = new System.Drawing.Size(121, 21);
            this.CbFiltro.TabIndex = 1;
            this.CbFiltro.SelectedIndexChanged += new System.EventHandler(this.CbFiltro_SelectedIndexChanged);
            // 
            // CbFiltro2
            // 
            this.CbFiltro2.FormattingEnabled = true;
            this.CbFiltro2.Location = new System.Drawing.Point(140, 61);
            this.CbFiltro2.Name = "CbFiltro2";
            this.CbFiltro2.Size = new System.Drawing.Size(121, 21);
            this.CbFiltro2.TabIndex = 2;
            this.CbFiltro2.SelectedIndexChanged += new System.EventHandler(this.CbFiltro2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar por . . . .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // ListarForm
            // 
            this.ClientSize = new System.Drawing.Size(436, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbFiltro2);
            this.Controls.Add(this.CbFiltro);
            this.Controls.Add(this.DataListado);
            this.Name = "ListarForm";
            this.Load += new System.EventHandler(this.ListarForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listarDataGridView;
        public System.Windows.Forms.ComboBox listarComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.ComboBox CbFiltro;
        private System.Windows.Forms.ComboBox CbFiltro2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}