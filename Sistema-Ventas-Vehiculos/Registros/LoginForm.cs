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
        public int prioridad = 1;

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "" || passwordTextBox.Text == "" || loginComboBox.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Error Al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (usuarios.Verificar(usuarioTextBox.Text, passwordTextBox.Text, prioridad))
                {
                    if (prioridad == 1)
                    {
                        PortadaF.Show();
                        this.Close();
                    }
                    else
                    {
                        PortadaF.Show();
                        PortadaF.botonAgregarUsuario.Visible = false;
                        PortadaF.botonInsertar.Visible = false;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario, Clave o Tipo De Usuario Incorrecto");
                }
            }
            usuarioTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyPressEventArgs e)
        {
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginComboBox.Text == "Administrador")
            {
                prioridad = 1;
            }
            if (loginComboBox.Text == "Usuario")
            {
                prioridad = 2;
            }
        }
    }
}
