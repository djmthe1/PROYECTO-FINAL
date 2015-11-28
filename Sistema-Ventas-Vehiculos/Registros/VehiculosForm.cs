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
        public Vehiculos vehiculo = new Vehiculos();
        public Modelos modelo = new Modelos();
        public Marcas marcas = new Marcas();
        public TipoMotores motores = new TipoMotores();
        public Colores colores = new Colores();
        public DataTable dato = new DataTable();

        public VehiculosForm()
        {
            InitializeComponent();
        }

        public void Borrar()
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

        private void VehiculosForm_Load(object sender, EventArgs e)
        {
            dato = modelo.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dato.Rows.Count - 1; i++)
                ModeloComboBox.Items.Add(modelo.Listado("*", "0=0","ORDER BY Descripcion").Rows[i]["Descripcion"]);

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

        private void botonAtras_Click(object sender, EventArgs e)
        {
            InsetarForm InsetarF = new InsetarForm();
            InsetarF.Show();
            this.Close();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void alfombrasCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            vehiculo.EstadoDelVehiculo = estadoVehiculoTextBox.Text;
            vehiculo.Motor = MotorComboBox.Text;
            vehiculo.Marca = MarcasComboBox.Text;
            vehiculo.Modelo = MotorComboBox.Text;
            vehiculo.Color = ColorComboBox.Text;
            int idAño = 0;
            int.TryParse(añoVehiculoTextBox.Text, out idAño);
            vehiculo.Año = idAño;

            vehiculo.NoChasis = chasisVehiculoTextBox.Text;
            vehiculo.TipoDeVehiculo = tipoVehiculoTextBox.Text;

            int idKilometraje = 0;
            int.TryParse(kilometrajeVehiculoTextBox.Text, out idKilometraje);
            vehiculo.Año = idKilometraje;

            int idPrecio = 0;
            int.TryParse(precioVehiculoTextBox.Text, out idPrecio);
            vehiculo.Año = idPrecio;

            vehiculo.Placa = placaVehiculoTextBox.Text;
            vehiculo.Matricula = matriculaVehiculoTextBox.Text;

            vehiculo.Insertar();

        }

        private void manualCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
