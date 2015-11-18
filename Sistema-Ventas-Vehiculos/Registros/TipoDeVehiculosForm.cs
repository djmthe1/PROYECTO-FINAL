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
    public partial class TipoDeVehiculosForm : Form
    {
        public TipoDeVehiculosForm()
        {
            InitializeComponent();
        }

        TipoDeVehiculos tipovehiculos = new TipoDeVehiculos();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TipoDeVehiculosForm_Load(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            TipoIDtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tipovehiculos.TipoDeVehiculoId = int.Parse(TipoIDtextBox.Text);
                if (tipovehiculos.Eliminar())
                {
                    MensajeOk("Eliminado correctamente");
                    DescripciontextBox.Clear();
                    TipoIDtextBox.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Eliminar");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tipovehiculos.Descripcion = DescripciontextBox.Text;
                if (TipoIDtextBox.Text == "")
                {

                    if (tipovehiculos.Insertar())
                    {
                        DescripciontextBox.Clear();
                        MensajeOk("Insertado Correctamente");
                    }
                    else
                    {
                        MensajeError("Error al Insertar");
                    }

                }
                else
                {
                    int id = 0;
                    int.TryParse(TipoIDtextBox.Text, out id);
                    tipovehiculos.TipoDeVehiculoId = id;
                    if (tipovehiculos.Editar())
                    {
                        DescripciontextBox.Clear();
                        MensajeOk("Modificado Correctamente");
                    }
                    else
                    {
                        MensajeError("Error al Modificar");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Insertar o Modificar");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            InsetarForm InsetarF = new InsetarForm();
            InsetarF.Show();
            this.Close();
        }
    }
}
