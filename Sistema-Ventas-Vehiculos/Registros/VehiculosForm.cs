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
        public Modelos modelo = new Modelos();
        public Marcas marcas = new Marcas();
        public TipoMotores motores = new TipoMotores();
        public Colores colores = new Colores();
        public DataTable dato = new DataTable();
        public VehiculosForm()
        {
            InitializeComponent();
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
    }
}
