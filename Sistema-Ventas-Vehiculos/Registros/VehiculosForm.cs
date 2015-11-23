using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BLL;

namespace Sistema_Ventas_Vehiculos.Registros
{
    public partial class VehiculosForm : Form
    {
        public Modelos modelo = new Modelos();
        public VehiculosForm()
        {
            InitializeComponent();
        }

        private void VehiculosForm_Load(object sender, EventArgs e)
        {
            DataTable datoModelo = new DataTable();
            datoModelo = modelo.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= datoModelo.Rows.Count - 1; i++)
                ModeloComboBox.Items.Add(modelo.Listado("*", "0=0","ORDER BY Descripcion").Rows[i]["Descripcion"]);
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
    }
}
