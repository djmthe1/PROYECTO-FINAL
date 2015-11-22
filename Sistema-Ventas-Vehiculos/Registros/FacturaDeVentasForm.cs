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

        private void botonSiguente_Click(object sender, EventArgs e)
        {
            FacturaDeVentasForm Factura = new FacturaDeVentasForm();
            Factura.Show();
            this.Close();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            PortadaForm Portada = new PortadaForm();
            Portada.Show();
            this.Close();
        }
    }
}
