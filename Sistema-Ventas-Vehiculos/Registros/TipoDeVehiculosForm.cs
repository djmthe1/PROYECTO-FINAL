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

        TipoDeVehiculos tipoVehiculos = new TipoDeVehiculos();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                int id = 0;
                int.TryParse(TipoIDtextBox.Text, out id);
                tipoVehiculos.TipoDeVehiculoId = id;

                if (tipoVehiculos.Buscar(tipoVehiculos.TipoDeVehiculoId))
                {
                    if (tipoVehiculos.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
                        DescripciontextBox.Clear();
                        TipoIDtextBox.Clear();
                    }
                    else
                    {
                        MensajeError("Error al eliminar");
                    }
                }
                else
                {
                    MensajeAdvertencia("Este Id no existe");
                    TipoIDtextBox.Clear();
                }

            }catch (Exception)
            {
                MensajeError("Error al Eliminar");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tipoVehiculos.Descripcion = DescripciontextBox.Text;
                if (TipoIDtextBox.Text == "")
                {
                    if(DescripciontextBox.Text != ""){
                        if (tipoVehiculos.Insertar())
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
                        MensajeAdvertencia("Inserte la descripcion");
                    }

                }
                else
                {
                    int id = 0;
                    int.TryParse(TipoIDtextBox.Text, out id);
                    tipoVehiculos.TipoDeVehiculoId = id;
                    if (DescripciontextBox.Text != "")
                    {
                        if (tipoVehiculos.Editar())
                        {
                            DescripciontextBox.Clear();
                            TipoIDtextBox.Clear();
                            MensajeOk("Modificado Correctamente");
                        }
                        else
                        {
                            MensajeError("Error al Modificar");
                        }
                    }
                    else{
                        MensajeAdvertencia("Inserte la descripcion");
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
            this.Close();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(TipoIDtextBox.Text, out id);
            tipoVehiculos.TipoDeVehiculoId = id;

            if (tipoVehiculos.Buscar(tipoVehiculos.TipoDeVehiculoId))
            {
                DescripciontextBox.Text = tipoVehiculos.Descripcion;
            }
            else
            {
                MensajeAdvertencia("Id no encontrado");
                TipoIDtextBox.Clear();
            }
        }
    }
}
