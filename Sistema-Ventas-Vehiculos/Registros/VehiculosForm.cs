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
    public partial class VehiculosForm : Form
    {
        public VehiculosForm()
        {
            InitializeComponent();
        }

        public Vehiculos vehiculo = new Vehiculos();
        public Modelos modelo = new Modelos();
        public Marcas marcas = new Marcas();
        public TipoMotores motores = new TipoMotores();
        public Colores colores = new Colores();
        public DataTable dato = new DataTable();

        public void Limpiar()
        {
            vehiculoIdTextBox.Clear();
            estadoVehiculoTextBox.Clear();
            ModeloComboBox.Refresh();
            MarcasComboBox.Refresh();
            MotorComboBox.Refresh();
            ColorComboBox.Refresh();
            tipoVehiculoTextBox.Clear();
            añoVehiculoTextBox.Clear();
            chasisVehiculoTextBox.Clear();
            kilometrajeVehiculoTextBox.Clear();
            precioVehiculoTextBox.Clear();
            placaVehiculoTextBox.Clear();
            matriculaVehiculoTextBox.Clear();
            duplicadoLlaveCheckBox.Checked = false;
            izquierdoCheckBox.Checked = false;
            derechoCheckBox.Checked = false;
            InternoCheckBox.Checked = false;
            gomaRepuestoCheckBox.Checked = false;
            taponRadiadorCheckBox.Checked = false;
            taponGasolinaCheckBox.Checked = false;
            manualCheckBox.Checked = false;
            llaveDeRuedaCheckBox.Checked = false;
            encendedorCheckBox.Checked = false;
            alfombrasCheckBox.Checked = false;
            botiquinCheckBox.Checked = false;
            gomasCheckBox.Checked = false;
            radioCheckBox.Checked = false;
            gatoCheckBox.Checked = false;
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void VehiculosForm_Load(object sender, EventArgs e)
        {
            dato = modelo.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dato.Rows.Count - 1; i++)
                ModeloComboBox.Items.Add(modelo.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);

            dato = marcas.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dato.Rows.Count - 1; i++)
                MarcasComboBox.Items.Add(marcas.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);

            dato = motores.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dato.Rows.Count - 1; i++)
                MotorComboBox.Items.Add(motores.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);

            dato = colores.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dato.Rows.Count - 1; i++)
                ColorComboBox.Items.Add(colores.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(vehiculoIdTextBox.Text, out id);
                vehiculo.VehiculoId = id;

                if (vehiculo.Buscar(vehiculo.VehiculoId))
                {

                    estadoVehiculoTextBox.Text = vehiculo.EstadoDelVehiculo;
                    MotorComboBox.Text = vehiculo.Motor;
                    MarcasComboBox.Text = vehiculo.Marca;
                    MotorComboBox.Text = vehiculo.Modelo;
                    ColorComboBox.Text = vehiculo.Color;
                    añoVehiculoTextBox.Text = vehiculo.Año.ToString();
                    chasisVehiculoTextBox.Text = vehiculo.NoChasis;
                    tipoVehiculoTextBox.Text = vehiculo.TipoDeVehiculo;
                    kilometrajeVehiculoTextBox.Text = vehiculo.Kilometraje.ToString();
                    precioVehiculoTextBox.Text = vehiculo.Precio.ToString();
                    placaVehiculoTextBox.Text = vehiculo.Placa;
                    matriculaVehiculoTextBox.Text = vehiculo.Matricula;
                    duplicadoLlaveCheckBox.ThreeState = vehiculo.DuplicadoDeLlaveDeEncendido;
                    derechoCheckBox.ThreeState = vehiculo.EspejoRetrovisorDerecho;
                    izquierdoCheckBox.ThreeState = vehiculo.EspejoRetrovisorIzquierdo;
                    InternoCheckBox.ThreeState = vehiculo.EspejoRetrovisorInterno;
                    manualCheckBox.ThreeState = vehiculo.ManualDeUsuario;
                    taponGasolinaCheckBox.ThreeState = vehiculo.TaponDeGasolina;
                    taponRadiadorCheckBox.ThreeState = vehiculo.TaponDeRadiador;
                    gomaRepuestoCheckBox.ThreeState = vehiculo.GomaDeRepuesto;
                    botiquinCheckBox.ThreeState = vehiculo.Botiquin;
                    gomasCheckBox.ThreeState = vehiculo.Gomas;
                    radioCheckBox.ThreeState = vehiculo.Radio;
                    gatoCheckBox.ThreeState = vehiculo.Gato;
                    alfombrasCheckBox.ThreeState = vehiculo.Alfombras;
                    encendedorCheckBox.ThreeState = vehiculo.Encendedor;
                    llaveDeRuedaCheckBox.ThreeState = vehiculo.LlaveDeRueda;
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Al buscar");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            InsetarForm InsetarF = new InsetarForm();
            InsetarF.Show();
            this.Close();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                vehiculo.EstadoDelVehiculo = estadoVehiculoTextBox.Text;
                vehiculo.Motor = MotorComboBox.Text;
                vehiculo.Marca = MarcasComboBox.Text;
                vehiculo.Modelo = MotorComboBox.Text;
                vehiculo.Color = ColorComboBox.Text;

                if (!duplicadoLlaveCheckBox.ThreeState)
                {
                    duplicadoLlaveCheckBox.ThreeState = true;
                }
                else
                {
                    duplicadoLlaveCheckBox.ThreeState = false;
                }

                if (!derechoCheckBox.ThreeState)
                {
                    derechoCheckBox.ThreeState = true;
                }
                else
                {
                    derechoCheckBox.ThreeState = false;
                }

                if (!izquierdoCheckBox.ThreeState)
                {
                    izquierdoCheckBox.ThreeState = true;
                }
                else
                {
                    izquierdoCheckBox.ThreeState = false;
                }

                if (!InternoCheckBox.ThreeState)
                {
                    InternoCheckBox.ThreeState = true;
                }
                else
                {
                    InternoCheckBox.ThreeState = false;
                }

                if (!manualCheckBox.ThreeState)
                {
                    manualCheckBox.ThreeState = true;
                }
                else
                {
                    manualCheckBox.ThreeState = false;
                }

                if (!taponGasolinaCheckBox.ThreeState)
                {
                    taponGasolinaCheckBox.ThreeState = true;
                }
                else
                {
                    taponGasolinaCheckBox.ThreeState = false;
                }

                if (!taponRadiadorCheckBox.ThreeState)
                {
                    taponRadiadorCheckBox.ThreeState = true;
                }
                else
                {
                    taponRadiadorCheckBox.ThreeState = false;
                }

                if (!gomaRepuestoCheckBox.ThreeState)
                {
                    gomaRepuestoCheckBox.ThreeState = true;
                }
                else
                {
                    gomaRepuestoCheckBox.ThreeState = false;
                }

                if (!botiquinCheckBox.ThreeState)
                {
                    botiquinCheckBox.ThreeState = true;
                }
                else
                {
                    botiquinCheckBox.ThreeState = false;
                }

                if (!gomasCheckBox.ThreeState)
                {
                    gomasCheckBox.ThreeState = true;
                }
                else
                {
                    gomasCheckBox.ThreeState = false;
                }

                if (!radioCheckBox.ThreeState)
                {
                    radioCheckBox.ThreeState = true;
                }
                else
                {
                    radioCheckBox.ThreeState = false;
                }

                if (!gatoCheckBox.ThreeState)
                {
                    gatoCheckBox.ThreeState = true;
                }
                else
                {
                    gatoCheckBox.ThreeState = false;
                }

                if (!alfombrasCheckBox.ThreeState)
                {
                    alfombrasCheckBox.ThreeState = true;
                }
                else
                {
                    alfombrasCheckBox.ThreeState = false;
                }

                if (!encendedorCheckBox.ThreeState)
                {
                    encendedorCheckBox.ThreeState = true;
                }
                else
                {
                    encendedorCheckBox.ThreeState = false;
                }

                if (!llaveDeRuedaCheckBox.ThreeState)
                {
                    llaveDeRuedaCheckBox.ThreeState = true;
                }
                else
                {
                    llaveDeRuedaCheckBox.ThreeState = false;
                }

                int Año = 0;
                int.TryParse(añoVehiculoTextBox.Text, out Año);
                vehiculo.Año = Año;

                vehiculo.NoChasis = chasisVehiculoTextBox.Text;
                vehiculo.TipoDeVehiculo = tipoVehiculoTextBox.Text;

                int Kilometraje = 0;
                int.TryParse(kilometrajeVehiculoTextBox.Text, out Kilometraje);
                vehiculo.Kilometraje = Kilometraje;

                int Precio = 0;
                int.TryParse(precioVehiculoTextBox.Text, out Precio);
                vehiculo.Precio = Precio;

                vehiculo.Placa = placaVehiculoTextBox.Text;
                vehiculo.Matricula = matriculaVehiculoTextBox.Text;

                if (vehiculoIdTextBox.Text == "")
                {
                    if (estadoVehiculoTextBox.Text != "" && MotorComboBox.Text != "" && MarcasComboBox.Text != "" && MotorComboBox.Text != "" && ColorComboBox.Text != "" && añoVehiculoTextBox.Text != "" && chasisVehiculoTextBox.Text != "" && tipoVehiculoTextBox.Text != "" && kilometrajeVehiculoTextBox.Text != "" && precioVehiculoTextBox.Text != "" && placaVehiculoTextBox.Text != "" && matriculaVehiculoTextBox.Text != "")
                    {

                        if (vehiculo.Insertar())
                        {
                            MensajeOk("Insertado correctamente");
                            Limpiar();
                        }
                        else
                        {
                            MensajeError("Error al insertar");
                        }
                    }
                    else
                    {
                        MensajeAdvertencia("Debe llenar las cajas de texto vacias");
                    }
                }
                else
                {
                    int id = 0;
                    int.TryParse(vehiculoIdTextBox.Text, out id);
                    vehiculo.VehiculoId = id;

                    if (estadoVehiculoTextBox.Text != "" && MotorComboBox.Text != "" && MarcasComboBox.Text != "" && MotorComboBox.Text != "" && ColorComboBox.Text != "" && añoVehiculoTextBox.Text != "" && chasisVehiculoTextBox.Text != "" && tipoVehiculoTextBox.Text != "" && kilometrajeVehiculoTextBox.Text != "" && precioVehiculoTextBox.Text != "" && placaVehiculoTextBox.Text != "" && matriculaVehiculoTextBox.Text != "")
                    {
                        if (vehiculo.Editar())
                        {
                            MensajeOk("Editado correctamente");
                            Limpiar();
                        }
                        else
                        {
                            MensajeError("Error al editar");
                        }
                    }
                    else
                    {
                        MensajeAdvertencia("Debe llenar las cajas de texto vacias");
                    }
                }

            }
            catch (Exception)
            {
                MensajeError("Error al intentar guardar o editar");
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try {
                int id = 0;
                int.TryParse(vehiculoIdTextBox.Text, out id);
                vehiculo.VehiculoId = id;

                if (vehiculo.Buscar(vehiculo.VehiculoId))
                {

                    if (vehiculo.Eliminar())
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
                    Limpiar();
                }

            }
            catch (Exception)
            {
                MensajeError("Error al Eliminar");
            }
        }
    }
}
