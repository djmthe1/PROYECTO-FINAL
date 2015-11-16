using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas_Vehiculos
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            Registros.LoginForm LoginF = new Registros.LoginForm();
            LoginF.Show();
        }

        private void botonVerVehiculos_Click(object sender, EventArgs e)
        {
            Registros.BuscarForm BuscarF = new Registros.BuscarForm();
            BuscarF.Show();
        }
    }
}

