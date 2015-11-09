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
                MarcasForm MaF = new MarcasForm();
                MaF.Show();

            }
            if (SeleccionarComboBox.Text == "Modelo")
            {
                ModelosForm MoF = new ModelosForm();
                MoF.Show();

            }
            if (SeleccionarComboBox.Text == "Color")
            {
                ColoresForm CF = new ColoresForm();
                CF.Show();

            }
            if (SeleccionarComboBox.Text == "Tipo de Vehiculo")
            {
                TipoDeVehiculosForm TF = new TipoDeVehiculosForm();
                TF.Show();

            }
            if (SeleccionarComboBox.Text == "Motor")
            {
                MotoresForm MF = new MotoresForm();
                MF.Show();

            }
            if (SeleccionarComboBox.Text == "Vehiculo")
            {
                VehiculosForm VF = new VehiculosForm();
                VF.Show();

            }
        }
    }
}
