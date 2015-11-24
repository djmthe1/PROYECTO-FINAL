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
            MessageBox.Show(mensaje, "Registro de Tipos De Motores", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                motores.MotorId = int.Parse(MotorIDtextBox.Text);
                if (motores.Eliminar())
                {
                    MensajeOk("Eliminado correctamente");
                    DescripciontextBox.Clear();
                    MotorIDtextBox.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Eliminar");
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
                else
                {
                    int id = 0;
                    int.TryParse(MotorIDtextBox.Text, out id);
                    motores.MotorId= id;
                    if (motores.Editar())
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

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(MotorIDtextBox.Text, out id);
            motores.MotorId = id;

            motores.Buscar(motores.MotorId);
            DescripciontextBox.Text = motores.Descripcion;
        }
    }
}
