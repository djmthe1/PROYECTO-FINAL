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
            Application.Exit();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            Registros.LoginForm LoginF = new Registros.LoginForm();
            LoginF.Show();
        }

       
        private void botonListar_Click(object sender, EventArgs e)
        {
            Registros.ListarForm ListarF = new Registros.ListarForm();
           
            ListarF.listarComboBox.Visible = false;
            ListarF.Show();
        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }
    }
}

