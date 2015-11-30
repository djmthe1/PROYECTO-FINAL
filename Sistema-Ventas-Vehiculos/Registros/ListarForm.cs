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

    

        private void listarFueraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void listarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListarForm_Load_1(object sender, EventArgs e)
        {
            

        }

        private void CbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dato = new DataTable();
            CbFiltro2.Items.Clear();
            

            if (CbFiltro.Text == "Marca")
            {
                
                dato = marcas.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    CbFiltro2.Items.Add(marcas.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (CbFiltro.Text == "Modelo")
            {
                CbFiltro2.ResetText();
                dato = modelos.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    CbFiltro2.Items.Add(modelos.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (CbFiltro.Text == "Tipo de motor")
            {
                dato = tipoMotores.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    CbFiltro2.Items.Add(tipoMotores.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (CbFiltro.Text == "Tipo de vehiculo")
            {
                dato = tipoDeVehiculos.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    CbFiltro2.Items.Add(tipoDeVehiculos.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

            if (CbFiltro.Text == "Color")
            {
                dato = colores.Listado("*", "0=0", "ORDER BY Descripcion");

                for (int i = 0; i <= dato.Rows.Count - 1; i++)
                    CbFiltro2.Items.Add(colores.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
            }

    


        }

        private void CbFiltro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFiltro.Text == "Marca")
            {
                DataListado.DataSource = vehiculos.Listado(" * ", "Marca = "+"'"+CbFiltro2.Text+"'", " ORDER BY VehiculoId ");
                
            }
            if (CbFiltro.Text == "Modelo")
            {
                DataListado.DataSource = vehiculos.Listado(" * ", "Modelo = " + "'" + CbFiltro2.Text + "'", " ORDER BY VehiculoId ");

            }
            if (CbFiltro.Text == "Tipo de vehiculo")
            {
                DataListado.DataSource = vehiculos.Listado(" * ", "TipoVehiculo = " + "'" + CbFiltro2.Text + "'", " ORDER BY VehiculoId ");

            }

            if (CbFiltro.Text == "Color")
            {
                DataListado.DataSource = vehiculos.Listado(" * ", "Color = " + "'" + CbFiltro2.Text + "'", " ORDER BY VehiculoId ");

            }
            if (CbFiltro.Text == "Tipo de motor")
            {
                DataListado.DataSource = vehiculos.Listado(" * ", "Motor = " + "'" + CbFiltro2.Text + "'", " ORDER BY VehiculoId ");

            }
        }
    }
}
