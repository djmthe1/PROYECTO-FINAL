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
    public partial class FacturaDeVentasForm : Form
    {
        public FacturaDeVentasForm()
        {
            InitializeComponent();
        }
        public Clientes clientes = new Clientes();
        public Vehiculos vehiculo = new Vehiculos();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Factura de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Factura de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Factura de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void botonSiguente_Click(object sender, EventArgs e)
        {
            
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
           ClientesForm ClientesF = new ClientesForm();
            ClientesF.Show();
            this.Close();
        }

        private void añoVehiculoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(vehiculoIdTextBox.Text, out id);
                vehiculo.VehiculoId = id;

                if (vehiculo.Buscar(vehiculo.VehiculoId))
                {
                    estadoVehiculoTextBox.Text = vehiculo.EstadoDelVehiculo;
                    precioVehiculoTextBox.Text = vehiculo.Precio.ToString();
                    placaVehiculoTextBox.Text = vehiculo.Placa;
                    matriculaVehiculoTextBox.Text = vehiculo.Matricula;
                    kilometrajeVehiculoTextBox.Text = vehiculo.Kilometraje.ToString();
                    marcaVehiculoTextBox.Text = vehiculo.Marca;
                    modeloVehiculoTextBox.Text = vehiculo.Modelo;
                    colorVehiculoTextBox.Text = vehiculo.Color;
                    tipoVehiculoTextBox.Text = vehiculo.TipoDeVehiculo;
                    motorVehiculoTextBox.Text = vehiculo.Motor;
                    chasisVehiculoTextBox.Text = vehiculo.NoChasis;
                    añoVehiculoTextBox.Text = vehiculo.Año.ToString();
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

        private void FacturaDeVentasForm_Load(object sender, EventArgs e)
        {
            
        }

        private void botonBuscarCliente_Click_1(object sender, EventArgs e)
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
                    sexoTextBox.Text = clientes.Sexo;
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
    }
}
