using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas_Vehiculos.Registros
{
    public partial class ListarForm : Form
    {
        public ListarForm()
        {
            InitializeComponent();
        }

        private void ListarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Sistema_Ventas_VehiculosDataSet2.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this._Sistema_Ventas_VehiculosDataSet2.Vehiculos);

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            PortadaForm PortadaF = new PortadaForm();
            PortadaF.Show();
            this.Close();
        }

        private void botonAtrasPortada_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
