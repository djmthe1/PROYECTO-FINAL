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
    public partial class VehiculosForm : Form
    {
        public VehiculosForm()
        {
            InitializeComponent();
        }

        private void VehiculosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Sistema_Ventas_VehiculosDataSet3.Colores' table. You can move, or remove it, as needed.
            this.coloresTableAdapter.Fill(this._Sistema_Ventas_VehiculosDataSet3.Colores);

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            InsetarForm InsetarF = new InsetarForm();
            InsetarF.Show();
            this.Close();
        }
    }
}
