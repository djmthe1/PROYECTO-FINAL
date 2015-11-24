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
        public Clientes cliente = new Clientes();
        public Vehiculos vehiculo = new Vehiculos();
         
        private void botonSiguente_Click(object sender, EventArgs e)
        {
            FacturaDeVentasForm Factura = new FacturaDeVentasForm();
            Factura.Show();
            this.Close();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            PortadaForm Portada = new PortadaForm();
            Portada.Show();
            this.Close();
        }

        private void añoVehiculoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {

            int id = 0;
            int.TryParse(IdClinteTextBox.Text, out id);
            cliente.ClienteId = id;

            cliente.Buscar(cliente.ClienteId);

            NombreTextBox.Text = cliente.NombreCompleto;
            ApodoTextBox.Text = cliente.Apodo;
            DireccionTextBox.Text = cliente.Direccion;
            TelefonoTextBox.Text = cliente.Telefono;
            CelularTextBox.Text = cliente.Celular;
            CedulaTextBox.Text = cliente.Cedula;
            NacimientoTextBox.Text = cliente.Nacionalidad;
            OcupacionTextBox.Text = cliente.Ocupacion;
            LugardeNacimientoTextBox.Text = cliente.LugarDeNacimiento;
            SexoTextBox.Text = cliente.Sexo;
        }

        private void botonBuscarVehiculo_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(vehiculoIdTextBox.Text, out id);
            vehiculo.VehiculoId = id;

            vehiculo.Buscar(vehiculo.VehiculoId);

            estadoVehiculoTextBox.Text = vehiculo.EstadoDelVehiculo;
            precioVehiculoTextBox.Text = vehiculo.Precio.ToString();
            placaVehiculoTextBox.Text = vehiculo.Placa;
            matriculaVehiculoTextBox.Text = vehiculo.Matricula;
            kilometrajeVehiculoTextBox.Text = vehiculo.Kilometraje.ToString();
            chasisVehiculoTextBox.Text = vehiculo.NoChasis;
            
            
        }

        private void FacturaDeVentasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
