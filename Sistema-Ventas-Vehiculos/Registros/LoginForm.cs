using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Sistema_Ventas_Vehiculos.Registros
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Registros.PortadaForm PortadaF = new PortadaForm();
        Usuarios usuarios = new Usuarios();

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "" || passTextBox.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Error Al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (usuarios.Verificar(usuarioTextBox.Text, passTextBox.Text))
                {
                    PortadaF.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecta");
                }
            }
            usuarioTextBox.Clear();
            passTextBox.Clear();
        }

        private void passTextBox_KeyDown(object sender, KeyPressEventArgs e)
        {
      
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
