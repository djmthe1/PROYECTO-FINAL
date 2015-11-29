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
        public TipoDeVehiculos tipoVehiculo = new TipoDeVehiculos();
        public Colores colores = new Colores();
        public DataTable dato = new DataTable();

        public void Limpiar()
        {
            vehiculoIdTextBox.Clear();
            estadoVehiculoTextBox.Clear();
            ModeloComboBox.ResetText();
            MarcasComboBox.ResetText();
            MotorComboBox.ResetText();
            ColorComboBox.ResetText();
            tipoVehiculoComboBox.ResetText();
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
                    ModeloComboBox.Text = vehiculo.Modelo;
                    ColorComboBox.Text = vehiculo.Color;
                    añoVehiculoTextBox.Text = vehiculo.Año.ToString();
                    chasisVehiculoTextBox.Text = vehiculo.NoChasis;
                    tipoVehiculoComboBox.Text = vehiculo.TipoDeVehiculo;
                    kilometrajeVehiculoTextBox.Text = vehiculo.Kilometraje.ToString();
                    precioVehiculoTextBox.Text = vehiculo.Precio.ToString();
                    placaVehiculoTextBox.Text = vehiculo.Placa;
                    matriculaVehiculoTextBox.Text = vehiculo.Matricula;

                    if (vehiculo.DuplicadoDeLlaveDeEncendido == true)
                    {
                        duplicadoLlaveCheckBox.Checked = true;
                    }

                    if (vehiculo.EspejoRetrovisorDerecho == true)
                    {
                        izquierdoCheckBox.Checked = true;
                    }

                    if (vehiculo.EspejoRetrovisorIzquierdo == true)
                    {
                        izquierdoCheckBox.Checked = true;
                    }

                    if (vehiculo.EspejoRetrovisorInterno == true)
                    {
                        InternoCheckBox.Checked = true;
                    }

                    if (vehiculo.ManualDeUsuario == true)
                    {
                        manualCheckBox.Checked = true;
                    }

                    if (vehiculo.TaponDeGasolina == true)
                    {
                        taponGasolinaCheckBox.Checked = true;
                    }

                    if (vehiculo.TaponDeRadiador == true)
                    {
                        taponGasolinaCheckBox.Checked = true;
                    }

                    if (vehiculo.GomaDeRepuesto == true)
                    {
                        gomaRepuestoCheckBox.Checked = true;
                    }

                    if (vehiculo.Botiquin == true)
                    {
                        botiquinCheckBox.Checked = true;
                    }

                    if (vehiculo.Gomas == true)
                    {
                        gomasCheckBox.Checked = true;
                    }

                    if (vehiculo.Radio == true)
                    {
                        radioCheckBox.Checked = true;
                    }

                    if (vehiculo.Gato == true)
                    {
                        gatoCheckBox.Checked = true;
                    }

                    if (vehiculo.Alfombras == true)
                    {
                        alfombrasCheckBox.Checked = true;
                    }

                    if (vehiculo.Encendedor == true)
                    {
                        encendedorCheckBox.Checked = true;
                    }

                    if (vehiculo.LlaveDeRueda == true)
                    {
                        llaveDeRuedaCheckBox.Checked = true;
                    }

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

                if (duplicadoLlaveCheckBox.Checked)
                {
                    vehiculo.DuplicadoDeLlaveDeEncendido = true;
                }
                else
                {
                    vehiculo.DuplicadoDeLlaveDeEncendido = false;
                }

                if (derechoCheckBox.Checked)
                {
                    vehiculo.EspejoRetrovisorDerecho = true;
                }
                else
                {
                    vehiculo.EspejoRetrovisorDerecho = false;
                }

                if (izquierdoCheckBox.Checked)
                {
                    vehiculo.EspejoRetrovisorIzquierdo = true;
                }
                else
                {
                    vehiculo.EspejoRetrovisorIzquierdo= false;
                }

                if (InternoCheckBox.Checked)
                {
                    vehiculo.EspejoRetrovisorInterno = true;
                }
                else
                {
                    vehiculo.EspejoRetrovisorInterno = false;
                }

                if (manualCheckBox.Checked)
                {
                    vehiculo.ManualDeUsuario = true;
                }
                else
                {
                    vehiculo.ManualDeUsuario = false;
                }

                if (taponGasolinaCheckBox.Checked)
                {
                    vehiculo.TaponDeGasolina = true;
                }
                else
                {
                    vehiculo.TaponDeGasolina = false;
                }

                if (taponRadiadorCheckBox.Checked)
                {
                    vehiculo.TaponDeRadiador = true;
                }
                else
                {
                    vehiculo.TaponDeRadiador = false;
                }

                if (gomaRepuestoCheckBox.Checked)
                {
                    vehiculo.GomaDeRepuesto = true;
                }
                else
                {
                    vehiculo.GomaDeRepuesto = false;
                }

                if (botiquinCheckBox.Checked)
                {
                    vehiculo.Botiquin = true;
                }
                else
                {
                    vehiculo.Botiquin = false;
                }

                if (gomasCheckBox.Checked)
                {
                    vehiculo.Gomas = true;
                }
                else
                {
                    vehiculo.Gomas = false;
                }

                if (radioCheckBox.Checked)
                {
                    vehiculo.Radio = true;
                }
                else
                {
                    vehiculo.Radio = false;
                }

                if (gatoCheckBox.Checked)
                {
                    vehiculo.Gato = true;
                }
                else
                {
                    vehiculo.Gato = false;
                }

                if (alfombrasCheckBox.Checked)
                {
                    vehiculo.Alfombras= true;
                }
                else
                {
                    vehiculo.Alfombras = false;
                }

                if (encendedorCheckBox.Checked)
                {
                    vehiculo.Encendedor= true;
                }
                else
                {
                   vehiculo.Encendedor = false;
                }

                if (llaveDeRuedaCheckBox.Checked)
                {
                    vehiculo.LlaveDeRueda = true;
                }
                else
                {
                    vehiculo.LlaveDeRueda = false;
                }

                int Año = 0;
                int.TryParse(añoVehiculoTextBox.Text, out Año);
                vehiculo.Año = Año;

                vehiculo.NoChasis = chasisVehiculoTextBox.Text;
                vehiculo.TipoDeVehiculo = tipoVehiculoComboBox.Text;

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
                    if (estadoVehiculoTextBox.Text != "" && MotorComboBox.Text != "" && MarcasComboBox.Text != "" && MotorComboBox.Text != "" && ColorComboBox.Text != "" && añoVehiculoTextBox.Text != "" && chasisVehiculoTextBox.Text != "" && tipoVehiculoComboBox.Text != "" && kilometrajeVehiculoTextBox.Text != "" && precioVehiculoTextBox.Text != "" && placaVehiculoTextBox.Text != "" && matriculaVehiculoTextBox.Text != "")
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

                    if (estadoVehiculoTextBox.Text != "" && MotorComboBox.Text != "" && MarcasComboBox.Text != "" && MotorComboBox.Text != "" && ColorComboBox.Text != "" && añoVehiculoTextBox.Text != "" && chasisVehiculoTextBox.Text != "" && tipoVehiculoComboBox.Text != "" && kilometrajeVehiculoTextBox.Text != "" && precioVehiculoTextBox.Text != "" && placaVehiculoTextBox.Text != "" && matriculaVehiculoTextBox.Text != "")
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

        private void VehiculosForm_Load_1(object sender, EventArgs e)
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

            dato = tipoVehiculo.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dato.Rows.Count - 1; i++)
                tipoVehiculoComboBox.Items.Add(tipoVehiculo.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
        }
    }
}
