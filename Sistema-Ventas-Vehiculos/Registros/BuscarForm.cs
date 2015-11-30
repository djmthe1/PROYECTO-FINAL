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
    public partial class BuscarForm : Form
    {
        public BuscarForm()
        {
            InitializeComponent();
        }

        Colores colores = new Colores();
        Marcas marcas = new Marcas();
        Modelos modelos = new Modelos();
        TipoDeVehiculos tipoDeVehiculos = new TipoDeVehiculos();
        TipoMotores tipoMotores = new TipoMotores();
        Vehiculos vehiculos = new Vehiculos();

        private void BuscarForm_Load(object sender, EventArgs e)
        {

        }

        public void mensaje()
        {
            if (buscarDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay Nada registrado");
            }
        }

        private void buscarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dato = new DataTable();
            descripcionComboBox.Items.Clear();


            if (buscarComboBox.Text == "Marca")
            {

                dato = marcas.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    descripcionComboBox.Items.Add(marcas.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (buscarComboBox.Text == "Modelo")
            {
                descripcionComboBox.ResetText();
                dato = modelos.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    descripcionComboBox.Items.Add(modelos.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (buscarComboBox.Text == "Tipo de motor")
            {
                dato = tipoMotores.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    descripcionComboBox.Items.Add(tipoMotores.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (buscarComboBox.Text == "Tipo de vehiculo")
            {
                dato = tipoDeVehiculos.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    descripcionComboBox.Items.Add(tipoDeVehiculos.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (buscarComboBox.Text == "Color")
            {
                dato = colores.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    descripcionComboBox.Items.Add(colores.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

        }

        private void descripcionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (descripcionComboBox.Text == "Marca")
            {
                buscarDataGridView.DataSource = vehiculos.Listado(" * ", "Marca = " + "'" + descripcionComboBox.Text + "'", " ORDER BY VehiculoId ");

            }
            if (descripcionComboBox.Text == "Modelo")
            {
                buscarDataGridView.DataSource = vehiculos.Listado(" * ", "Modelo = " + "'" + descripcionComboBox.Text + "'", " ORDER BY VehiculoId ");

            }
            if (descripcionComboBox.Text == "Tipo de vehiculo")
            {
                buscarDataGridView.DataSource = vehiculos.Listado(" * ", "TipoVehiculo = " + "'" + descripcionComboBox.Text + "'", " ORDER BY VehiculoId ");

            }

            if (descripcionComboBox.Text == "Color")
            {
                buscarDataGridView.DataSource = vehiculos.Listado(" * ", "Color = " + "'" + descripcionComboBox.Text + "'", " ORDER BY VehiculoId ");

            }
            if (descripcionComboBox.Text == "Tipo de motor")
            {
                buscarDataGridView.DataSource = vehiculos.Listado(" * ", "Motor = " + "'" + descripcionComboBox.Text + "'", " ORDER BY VehiculoId ");

            }
        }
    }
}
