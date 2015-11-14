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
    public partial class PortadaForm : Form
    {
        public PortadaForm()
        {
            InitializeComponent();
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            Registros.InsetarForm InsertarF = new InsetarForm();
            InsertarF.Show();
        }

        private void botonAgregarUsuario_Click(object sender, EventArgs e)
        {
            Registros.InsertarUsuarioForm InsertarU = new InsertarUsuarioForm();
            InsertarU.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Registros.LoginForm LoginF = new LoginForm();
            LoginF.Show();
            this.Close();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Registros.BuscarForm BuscarF = new BuscarForm();
            BuscarF.Show();
        }
    }
}
