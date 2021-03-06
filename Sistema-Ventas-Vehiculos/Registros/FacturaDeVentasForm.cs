﻿using System;
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
                int vehiculoId = 0;
                int.TryParse(vehiculoIdTextBox.Text, out vehiculoId);
                factura.VehiculoId = vehiculoId;

                int clienteId = 0;
                int.TryParse(clienteIdTextBox.Text, out clienteId);
                factura.ClienteId = clienteId;


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
            int id = 0;
            int.TryParse(facturaIdTextBox.Text, out id);
            factura.FacturaId = id;
            if (factura.Buscar(factura.FacturaId)) {

                pagoInicialEfectivoTextBox.Text = factura.PagoInicialEnEfectivo.ToString();
                pagoInicialChequeTextBox.Text = factura.PagoInicialEnCheque.ToString();
                precioAPagarTextBox.Text = factura.PrecioAPagar.ToString();
                autorizadoPorTextBox.Text = factura.AutorizadoPor;

                if (clientes.Buscar(factura.ClienteId) && vehiculo.Buscar(factura.VehiculoId))
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
            else
            {
                MensajeAdvertencia("Id no encontrado");
            }

        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
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

        private void telefonosListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 45) || (e.KeyChar == 8))
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

        private void CedulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
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

        private void OcupacionTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void estadoVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 45) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void modeloVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void marcaVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void motorVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void colorVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void chasisVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tipoVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void placaVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void matriculaVehiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 45) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void autorizadoPorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
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

        private void facturaIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
