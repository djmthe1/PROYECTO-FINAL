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
    public partial class FacturaDeVentasForm : Form
    {
        public FacturaDeVentasForm()
        {
            InitializeComponent();
        }

        private void FacturaDeVentasForm_Load(object sender, EventArgs e)
        {

        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            ClientesForm ClientesF = new ClientesForm();
            ClientesF.Show();
            this.Close();
        }
    }
}
