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
                int telefonoid = 0;
                int.TryParse(TelefonoTextBox.Text, out telefonoid);
                clientes.ClienteId = telefonoid;
                clientes.Direccion = DireccionTextBox.Text;
                clientes.Cedula = CedulaTextBox.Text;
                clientes.Nacionalidad = nacionalidadTextBox.Text;
                clientes.Ocupacion = OcupacionTextBox.Text;
                clientes.LugarDeNacimiento = LugardeNacimientoTextBox.Text;
                clientes.Sexo = sexoComboBox.Text;

                if (clienteIdTextBox.Text.Length == 0)
                {
                    if (NombreTextBox.Text != "" || ApodoTextBox.Text != "" || TelefonoTextBox.Text != "" || DireccionTextBox.Text != "" || CedulaTextBox.Text != "" || nacionalidadTextBox.Text != "" || OcupacionTextBox.Text != "" || LugardeNacimientoTextBox.Text != "" || sexoComboBox.Text != "")
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
                    TelefonoTextBox.Text = clientes.TelefonoId.ToString();
                    DireccionTextBox.Text = clientes.Direccion;
                    CedulaTextBox.Text = clientes.Cedula;
                    nacionalidadTextBox.Text = clientes.Nacionalidad;
                    OcupacionTextBox.Text = clientes.Ocupacion;
                    LugardeNacimientoTextBox.Text = clientes.LugarDeNacimiento;
                    sexoComboBox.Text = clientes.Sexo;
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
    }
}
