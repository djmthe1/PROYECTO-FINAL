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
        public FacturasDeVentas factura = new FacturasDeVentas();

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

        private void Limpiar()
        {
            clienteIdTextBox.Clear();
            NombreTextBox.Clear();
            ApodoTextBox.Clear();
            DireccionTextBox.Clear();
            CedulaTextBox.Clear();
            nacionalidadTextBox.Clear();
            OcupacionTextBox.Clear();
            LugardeNacimientoTextBox.Clear();
            sexoTextBox.ResetText();
            telefonosListBox.Items.Clear();
            vehiculoIdTextBox.Clear();
            estadoVehiculoTextBox.Clear();
            modeloVehiculoTextBox.ResetText();
            marcaVehiculoTextBox.ResetText();
            motorVehiculoTextBox.ResetText();
            colorVehiculoTextBox.ResetText();
            tipoVehiculoTextBox.ResetText();
            añoVehiculoTextBox.Clear();
            chasisVehiculoTextBox.Clear();
            kilometrajeVehiculoTextBox.Clear();
            precioVehiculoTextBox.Clear();
            placaVehiculoTextBox.Clear();
            matriculaVehiculoTextBox.Clear();
            pagoInicialEfectivoTextBox.Clear();
            pagoInicialChequeTextBox.Clear();
            precioAPagarTextBox.Clear();
            autorizadoPorTextBox.Clear();
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

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int CId = 0;
                int.TryParse(clienteIdTextBox.Text, out CId);
                factura.ClienteId = CId;
                factura.NombreCompleto = NombreTextBox.Text;
                factura.Apodo = ApodoTextBox.Text;
                factura.Direccion = DireccionTextBox.Text;
                factura.Cedula = CedulaTextBox.Text;
                factura.Nacionalidad = nacionalidadTextBox.Text;
                factura.Ocupacion = OcupacionTextBox.Text;
                factura.LugarDeNacimiento = LugardeNacimientoTextBox.Text;
                factura.Sexo = sexoTextBox.Text;
                factura.LimpiarTelefono();
                for (int i = 0; i < telefonosListBox.Items.Count; i++)
                {
                    clientes.InsertarTelefono(1, telefonosListBox.Items[i].ToString());
                }
                int VId = 0;
                int.TryParse(vehiculoIdTextBox.Text, out VId);
                factura.VehiculoId = VId;
                factura.EstadoDelVehiculo = estadoVehiculoTextBox.Text;
                factura.Motor = motorVehiculoTextBox.Text;
                factura.Marca = marcaVehiculoTextBox.Text;
                factura.Modelo = motorVehiculoTextBox.Text;
                factura.Color = colorVehiculoTextBox.Text;
                int VAño = 0;
                int.TryParse(vehiculoIdTextBox.Text, out VAño);
                factura.VehiculoId = VAño;
                factura.Año = VAño;
                factura.NoChasis = chasisVehiculoTextBox.Text;
                factura.TipoDeVehiculo = tipoVehiculoTextBox.Text;
                int Kvehiculo = 0;
                int.TryParse(vehiculoIdTextBox.Text, out Kvehiculo);
                factura.Kilometraje = Kvehiculo;
                factura.DuplicadoDeLlaveDeEncendido = vehiculo.DuplicadoDeLlaveDeEncendido;
                factura.EspejoRetrovisorDerecho = vehiculo.EspejoRetrovisorDerecho;
                factura.EspejoRetrovisorIzquierdo = vehiculo.EspejoRetrovisorIzquierdo;
                factura.EspejoRetrovisorInterno = vehiculo.EspejoRetrovisorInterno;
                factura.ManualDeUsuario = vehiculo.ManualDeUsuario;
                factura.TaponDeGasolina = vehiculo.TaponDeGasolina;
                factura.TaponDeRadiador = vehiculo.TaponDeRadiador;
                factura.GomaDeRepuesto = vehiculo.GomaDeRepuesto;
                factura.Botiquin = vehiculo.Botiquin;
                factura.Gomas = vehiculo.Gomas;
                factura.Radio = vehiculo.Radio;
                factura.Gato = vehiculo.Gato;
                factura.Alfombras = vehiculo.Alfombras;
                factura.Encendedor = vehiculo.Encendedor;
                factura.LlaveDeRueda = vehiculo.LlaveDeRueda;
                factura.Matricula = marcaVehiculoTextBox.Text;
                factura.Placa = placaVehiculoTextBox.Text;
                int Pvehiculo = 0;
                int.TryParse(vehiculoIdTextBox.Text, out Pvehiculo);
                factura.Precio = Pvehiculo;
                int PagoInicialE = 0;
                int.TryParse(vehiculoIdTextBox.Text, out PagoInicialE);
                factura.PagoInicialEnEfectivo = PagoInicialE;
                int PagoInicialC = 0;
                int.TryParse(vehiculoIdTextBox.Text, out PagoInicialC);
                factura.PagoInicialEnCheque = PagoInicialC;
                int PrecioAP = 0;
                int.TryParse(vehiculoIdTextBox.Text, out PrecioAP);
                factura.PrecioAPagar = PrecioAP;
                factura.AutorizadoPor = autorizadoPorTextBox.Text;
                factura.Fecha = facturaDateTimePicker.Text;

                if (facturaIdTextBox.Text.Length == 0)
                {
                    if (pagoInicialEfectivoTextBox.Text != "" || pagoInicialChequeTextBox.Text != "" || precioAPagarTextBox.Text != "" || autorizadoPorTextBox.Text != "" || vehiculoIdTextBox.Text != "" || clienteIdTextBox.Text != "")
                    {

                        if (factura.Insertar())
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
                    MessageBox.Show("Debe llenar todos los Campos", "Error Al Inserar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MensajeError("Error al Insertar");
            }
        }

        private void botonBuscarFactura_Click(object sender, EventArgs e)
        {

           /* vehiculoIdTextBox  = factura.VehiculoId;
            estadoVehiculoTextBox = factura.EstadoDelVehiculo;
            modeloVehiculoTextBox = factura.Modelo;



            factura.Marca = marcaVehiculoTextBox;
            factura.Motor = modeloVehiculoTextBox;
            factura.Color = colorVehiculoTextBox.Text;
            factura.Año = añoVehiculoTextBox.Text;
            factura.NoChasis = chasisVehiculoTextBox.Text;
            factura.TipoVehiculo = tipoVehiculoTextBox.Text;
            factura.Kilometraje int,
            factura.Precio int,
            factura.Placa = placaVehiculoTextBox.Text;
            factura.Matricula = marcaVehiculoTextBox.Text;
            factura.PagoInicialEnEfectivo int,
            factura.PagoInicialEnCheque int,
            factura.PrecioAPagar int,
            factura.ClienteId int,
            factura.NombreCompleto = NombreTextBox.Text;
            factura.Apodo = ApodoTextBox.Text;
            factura.Cedula = CedulaTextBox.Text;
            factura.Direccion = DireccionTextBox.Text;
            factura.Nacionalidad = nacionalidadTextBox;
            factura.Ocupacion = OcupacionTextBox.Text;
            factura.LugarDeNacimiento = LugardeNacimientoTextBox.Text;
            factura.Sexo = sexoTextBox.Text;
            factura.AutorizadoPor = autorizadoPorTextBox.Text;
            */
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ApodoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void telefonosListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DireccionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CedulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void nacionalidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void OcupacionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void LugardeNacimientoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void estadoVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void modeloVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void marcaVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void motorVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void colorVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void chasisVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tipoVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void placaVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void matriculaVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void autorizadoPorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void precioAPagarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void pagoInicialChequeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void pagoInicialEfectivoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
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

        private void vehiculoIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void añoVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void kilometrajeVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void precioVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
