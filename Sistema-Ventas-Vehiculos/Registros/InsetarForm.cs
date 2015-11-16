using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas_Vehiculos.Registros
{
    public partial class InsetarForm : Form
    {
        public InsetarForm()
        {
            InitializeComponent();
        }

        private void InsetarForm_Load(object sender, EventArgs e)
        {

        }

        private void selecionarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionarComboBox.Text == "Marca")
            {
                MarcasForm MarcasF = new MarcasForm();
                MarcasF.Show();

            }
            if (SeleccionarComboBox.Text == "Modelo")
            {
                ModelosForm ModelosF = new ModelosForm();
                ModelosF.Show();

            }
            if (SeleccionarComboBox.Text == "Color")
            {
                ColoresForm ColoresF = new ColoresForm();
                ColoresF.Show();

            }
            if (SeleccionarComboBox.Text == "Tipo de Vehiculo")
            {
                TipoDeVehiculosForm TipoVehiculoF = new TipoDeVehiculosForm();
                TipoVehiculoF.Show();

            }
            if (SeleccionarComboBox.Text == "Tipo de Motor")
            {
                MotoresForm TipoMotorF = new MotoresForm();
                TipoMotorF.Show();

            }
            if (SeleccionarComboBox.Text == "Vehiculo")
            {
                VehiculosForm VehiculosF = new VehiculosForm();
                VehiculosF.Show();

            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            PortadaForm PortadaF = new PortadaForm();
            PortadaF.Show();
            this.Close();
        }
    }
}
