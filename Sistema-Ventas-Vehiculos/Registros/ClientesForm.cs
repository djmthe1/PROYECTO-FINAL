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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        Clientes clientes = new Clientes();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void botonSiguente_Click(object sender, EventArgs e)
        {
            FacturaDeVentasForm Factura = new FacturaDeVentasForm();
            Factura.Show();
            this.Close();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            PortadaForm PortadaF = new PortadaForm();
            PortadaF.Show();
            this.Close();
        }

        private void Limpiar()
        {
            clienteIdTextBox.Clear();
            NombreTextBox.Clear();
            ApodoTextBox.Clear();
            TelefonoTextBox.Clear();
            DireccionTextBox.Clear();
            CedulaTextBox.Clear();
            nacionalidadTextBox.Clear();
            OcupacionTextBox.Clear();
            LugardeNacimientoTextBox.Clear();
            sexoComboBox.ResetText();
            telefonosListBox.Items.Clear();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(clienteIdTextBox.Text, out id);
                clientes.ClienteId = id;

                if (clientes.Buscar(clientes.ClienteId))
                {

                    if (clientes.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MensajeError("Error al Eliminar");
                    }

                }
                else
                {
                    MensajeAdvertencia("Este Id no existe");
                    clienteIdTextBox.Clear();
                }

            }
            catch (Exception)
            {
                MensajeError("Error al Eliminar");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clientes.NombreCompleto = NombreTextBox.Text;
                clientes.Apodo = ApodoTextBox.Text;
                clientes.Direccion = DireccionTextBox.Text;
                clientes.Cedula = CedulaTextBox.Text;
                clientes.Nacionalidad = nacionalidadTextBox.Text;
                clientes.Ocupacion = OcupacionTextBox.Text;
                clientes.LugarDeNacimiento = LugardeNacimientoTextBox.Text;
                clientes.Sexo = sexoComboBox.Text;
                clientes.LimpiarTelefono();
                for (int i = 0; i < telefonosListBox.Items.Count; i++)
                {
                    clientes.InsertarTelefono(1, telefonosListBox.Items[i].ToString());
                }

                if (clienteIdTextBox.Text.Length == 0)
                {
                    if (NombreTextBox.Text != "" || ApodoTextBox.Text != "" || DireccionTextBox.Text != "" || CedulaTextBox.Text != "" || nacionalidadTextBox.Text != "" || OcupacionTextBox.Text != "" || LugardeNacimientoTextBox.Text != "" || sexoComboBox.Text != "")
                    {

                        if (clientes.Insertar())
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
                        MessageBox.Show("Debe llenar todos los Campos", "Error Al Inserar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {

                    int id = 0;
                    int.TryParse(clienteIdTextBox.Text, out id);
                    clientes.ClienteId = id;
                    if (NombreTextBox.Text != "" || ApodoTextBox.Text != "" || TelefonoTextBox.Text != "" || DireccionTextBox.Text != "" || CedulaTextBox.Text != "" || nacionalidadTextBox.Text != "" || OcupacionTextBox.Text != "" || LugardeNacimientoTextBox.Text != "" || sexoComboBox.Text != "")
                    {
                        if (clientes.Editar())
                        {
                            Limpiar();
                            MensajeOk("Modificado Correctamente");
                        }
                        else
                        {
                            MensajeError("Error al Modificar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe llenar todos los Campos", "Error Al Mofdificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MensajeError("Error al Insertar o Modificar");
            }
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(clienteIdTextBox.Text, out id);
                clientes.ClienteId = id;

                if (clientes.Buscar(clientes.ClienteId))
                {
                    NombreTextBox.Text = clientes.NombreCompleto;
                    ApodoTextBox.Text = clientes.Apodo;
                    DireccionTextBox.Text = clientes.Direccion;
                    CedulaTextBox.Text = clientes.Cedula;
                    nacionalidadTextBox.Text = clientes.Nacionalidad;
                    OcupacionTextBox.Text = clientes.Ocupacion;
                    LugardeNacimientoTextBox.Text = clientes.LugarDeNacimiento;
                    sexoComboBox.Text = clientes.Sexo;
                    telefonosListBox.Items.Clear();
                    foreach (var telefono in clientes.numerostelefonos)
                    {
                        telefonosListBox.Items.Add(telefono.Telefono);
                    }
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    clienteIdTextBox.Clear();
                }
            }
            catch (Exception)
            {
                MensajeError("Error al Buscar");
            }
        }

        private void botonEliminarTelefono_Click(object sender, EventArgs e)
        {
            if (telefonosListBox.SelectedIndex > 0)
            {
                if (MessageBox.Show("Eliminar el Telefono: ", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    telefonosListBox.Items.RemoveAt(telefonosListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un Telefono");
            }
        }

        private void botonInsertarTelefono_Click(object sender, EventArgs e)
        {
            telefonosListBox.Items.Add(telefonosListBox.Text);
            TelefonoTextBox.Clear();
        }


        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void LugardeNacimientoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void OcupacionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void nacionalidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CedulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DireccionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 45) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ApodoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void clienteIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
