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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registros.InsetarForm insert = new Registros.InsetarForm();
            insert.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registros.LoginForm LoginF = new Registros.LoginForm();
            LoginF.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

