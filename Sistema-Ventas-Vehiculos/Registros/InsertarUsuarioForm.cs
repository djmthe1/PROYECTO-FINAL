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
    public partial class InsertarUsuarioForm : Form
    {
        public InsertarUsuarioForm()
        {
            InitializeComponent();
        }

        Usuarios usuarios = new Usuarios();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            PortadaForm PortadaF = new PortadaForm();
            PortadaF.Show();
            this.Close();
        }

        private void Limpiar() {
            usuarioIDTextBox.Clear();
            nombreTextBox.Clear();
            passTextBox.Clear();
            confirmarPassTextBox.Clear();
           
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarios.UsuarioId = int.Parse(usuarioIDTextBox.Text);
                if (usuarios.Eliminar())
                {
                    MensajeOk("Eliminado correctamente");
                    Limpiar();
                }
            }
            catch (Exception) {
                MessageBox.Show("Error al Eliminar");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            usuarios.Nombre = nombreTextBox.Text;
            int prioridad = 0;
           
            if (prioridad < 3)
            {
                usuarios.Prioridad = prioridad;

                if (usuarioIDTextBox.Text == "" && passTextBox.Text == confirmarPassTextBox.Text && nombreTextBox.Text.Length > 0 && passTextBox.Text.Length > 0 && confirmarPassTextBox.Text.Length > 0)
                {

                    usuarios.Password = passTextBox.Text;
                    if (usuarios.Insertar())
                    {
                        Limpiar();
                        MensajeOk("Insertado Correctamente");
                    }
                    else
                    {
                        MensajeError("Error al Insertar");
                    }
                }
                else
                {
                    if (passTextBox.Text == confirmarPassTextBox.Text && nombreTextBox.Text.Length > 0 && passTextBox.Text.Length > 0 && confirmarPassTextBox.Text.Length > 0) {
                        int id = 0;
                        int.TryParse(usuarioIDTextBox.Text, out id);
                        usuarios.UsuarioId = id;
                        if (usuarios.Editar())
                        {
                            Limpiar();
                            MensajeOk("Modificado Correctamente");
                        }
                        else
                        {
                            MensajeError("Error al Modificar");
                        }
                    }
                    else {
                        MessageBox.Show("Debe Llenar Los Campos Correspondientes");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Una Prioridad Correcta");
            }
        }

        private void InsertarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(usuarioIDTextBox.Text, out id);
            usuarios.UsuarioId = id;
            usuarios.Buscar(usuarios.UsuarioId);
            nombreTextBox.Text = usuarios.Nombre;
            
        }
    }
}
