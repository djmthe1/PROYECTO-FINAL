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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            Registros.PortadaForm PortadaF = new PortadaForm();
            PortadaF.Show();
            this.Close();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
