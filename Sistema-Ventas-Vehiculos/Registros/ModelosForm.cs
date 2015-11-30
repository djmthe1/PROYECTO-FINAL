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
    public partial class ModelosForm : Form
    {
        public ModelosForm()
        {
            InitializeComponent();
        }

        Modelos modelos = new Modelos();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Modelos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Modelos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Modelos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            ModeloIDtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(ModeloIDtextBox.Text, out id);
                modelos.ModeloId = id;

                if (modelos.Buscar(modelos.ModeloId))
                {

                    if (modelos.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
                        DescripciontextBox.Clear();
                        ModeloIDtextBox.Clear();
                    }
                    else
                    {
                        MensajeError("Error al eliminar");
                    }
                }
                else
                {
                MensajeAdvertencia("Este Id no existe");
                ModeloIDtextBox.Clear();
                }
        }
            catch (Exception)
            {
                MensajeError("Error al Eliminar");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModelosForm_Load(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                modelos.Descripcion = DescripciontextBox.Text;
                if (ModeloIDtextBox.Text == "")
                {
                    if (DescripciontextBox.Text != "")
                    {
                        if (modelos.Insertar())
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
                    int.TryParse(ModeloIDtextBox.Text, out id);
                    modelos.ModeloId = id;
                    if (DescripciontextBox.Text != "")
                    {
                        if (modelos.Editar())
                        {
                            DescripciontextBox.Clear();
                            ModeloIDtextBox.Clear();
                            MensajeOk("Modificado Correctamente");
                        }
                        else
                        {
                            MensajeError("Error al Modificar");
                        }
                    }
                    else
                    {
                        MensajeAdvertencia("Inserte la descripcion");
                    }
                }
            }
            catch (Exception)
            {
                MensajeError("Error al Insertar o Modificar");
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(ModeloIDtextBox.Text, out id);
            modelos.ModeloId = id;

            if (modelos.Buscar(modelos.ModeloId))
            {
                DescripciontextBox.Text = modelos.Descripcion;
            }
            else {
                MensajeAdvertencia("Id no encontrado");
                ModeloIDtextBox.Focus();
            }
        }
    }
}
