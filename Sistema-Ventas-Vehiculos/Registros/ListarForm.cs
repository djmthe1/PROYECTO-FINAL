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
    public partial class ListarForm : Form
    {
        public ListarForm()
        {
            InitializeComponent();
        }

        Colores colores = new Colores();
        Marcas marcas = new Marcas();
        Modelos modelos = new Modelos();
        TipoDeVehiculos tipoDeVehiculos = new TipoDeVehiculos();
        TipoMotores tipoMotores = new TipoMotores();
        Vehiculos vehiculos = new Vehiculos();

        private void ListarForm_Load(object sender, EventArgs e)
        {
        
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            PortadaForm PortadaF = new PortadaForm();
            PortadaF.Show();
            this.Close();
        }

        private void botonAtrasPortada_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mensaje()
        {
            if (listarDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay Nada registrado");
            }
        }

    private void listarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listarComboBox.Text == "Marcas")
            {
                listarDataGridView.DataSource = marcas.Listado("*", "1=1", "ORDER BY Descripcion");
                mensaje();

            }
            if (listarComboBox.Text == "Modelos")
            {
                listarDataGridView.DataSource = modelos.Listado("*", "1=1", "ORDER BY Descripcion");
                mensaje();

            }
            if (listarComboBox.Text == "Colores")
            {
                listarDataGridView.DataSource = colores.Listado("*", "1=1", "ORDER BY Descripcion");
                mensaje();

            }
            if (listarComboBox.Text == "Tipos de Vehiculos")
            {
                listarDataGridView.DataSource = tipoDeVehiculos.Listado("*", "1=1", "ORDER BY Descripcion");
                mensaje();

            }
            if (listarComboBox.Text == "Tipos de Motores")
            {
                listarDataGridView.DataSource = tipoMotores.Listado("*", "1=1", "ORDER BY Descripcion");
                mensaje();

            }
            if (listarComboBox.Text == "Vehiculos")
            {
                listarDataGridView.DataSource = vehiculos.Listado("*", "1=1", "ORDER BY VehiculoId");
                mensaje();

            }
        }

        private void listarFueraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listarFueraComboBox.Text == "Vehiculos")
            {
                listarDataGridView.DataSource = vehiculos.Listado("*", "1=1", "ORDER BY VehiculoId");
                mensaje();

            }

        }

        private void listarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
