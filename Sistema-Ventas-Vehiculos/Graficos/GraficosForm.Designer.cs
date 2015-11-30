namespace Sistema_Ventas_Vehiculos.Graficos
{
    partial class GraficosForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMarcas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMarcas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMarcas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMarcas.Legends.Add(legend1);
            this.chartMarcas.Location = new System.Drawing.Point(25, 100);
            this.chartMarcas.Name = "chartMarcas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMarcas.Series.Add(series1);
            this.chartMarcas.Size = new System.Drawing.Size(390, 256);
            this.chartMarcas.TabIndex = 0;
            this.chartMarcas.Text = "chart1";
            this.chartMarcas.Click += new System.EventHandler(this.chart1_Click);
            // 
            // GraficosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 368);
            this.Controls.Add(this.chartMarcas);
            this.Name = "GraficosForm";
            this.Text = "MarcasGraficoForm";
            this.Load += new System.EventHandler(this.MarcasGraficoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarcas;
    }
}