using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;

namespace Sistema_Ventas_Vehiculos.Graficos
{
    public partial class GraficosForm : Form
    {
        public GraficosForm()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void MarcasGraficoForm_Load(object sender, EventArgs e)
        {
           /* DataTable table = new DataTable();
            DateTime date = DateTime.Now;

            Marcas marcas = new Marcas();

            string[] series = marcas;

            

            table = marcas.Listado("", "", "");
            chartMarcas.Series.Add("Marcas");
            for (int x = 0; x < series.Length; x++) {
                chartMarcas.Series["Series1"].XValueMember = "Marca";
                chartMarcas.Series["Series1"].YValueMembers = "Descripcion";
                chartMarcas.DataSource = table;
                chartMarcas.DataBind();
            }
            */
        }
    }
}
