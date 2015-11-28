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
    public partial class MotoresForm : Form
    {
        public MotoresForm()
        {
            InitializeComponent();
        }

        TipoMotores motores = new TipoMotores();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Motores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Motores", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Tipos De Motores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MotoresForm_Load(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            MotorIDtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(MotorIDtextBox.Text, out id);
                motores.MotorId = id;

                if (motores.Buscar(motores.MotorId))
                {

                    if (motores.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
                        DescripciontextBox.Clear();
                        MotorIDtextBox.Clear();
                    }
                    else
                    {
                        MensajeError("Error al eliminar");
                    }
                }
                else
                {
                    MensajeAdvertencia("Este Id no existe");
                    MotorIDtextBox.Clear();
                }
            }
            catch (Exception)
            {
                MensajeError("Error al Eliminar");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            InsetarForm InsetarF = new InsetarForm();
            InsetarF.Show();
            this.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                motores.Descripcion = DescripciontextBox.Text;
                if (MotorIDtextBox.Text == "")
                {
                    if (DescripciontextBox.Text != "")
                    {
                        if (motores.Insertar())
                        {
                            DescripciontextBox.Clear();
                            MensajeOk("Insertado Correctamente");
                        }
                        else
                        {
                            MensajeError("Error al Insertar");
                        }
                    }
                    else{
                        MensajeAdvertencia("Inserte la descripcion");
                    }
                }
                else
                {
                    int id = 0;
                    int.TryParse(MotorIDtextBox.Text, out id);
                    motores.MotorId= id;
                    if (DescripciontextBox.Text != "")
                    {
                        if (motores.Editar())
                        {
                            DescripciontextBox.Clear();
                            MotorIDtextBox.Clear();
                            MensajeOk("Modificado Correctamente");
                        }
                        else
                        {
                            MensajeError("Error al Modificar");
                        }
                    }
                    else {
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
            int.TryParse(MotorIDtextBox.Text, out id);
            motores.MotorId = id;

            if (motores.Buscar(motores.MotorId))
            {
                DescripciontextBox.Text = motores.Descripcion;
            }
            else {
                MensajeAdvertencia("Id no encontrado");
                MotorIDtextBox.Clear();
            }
        }
    }
}
