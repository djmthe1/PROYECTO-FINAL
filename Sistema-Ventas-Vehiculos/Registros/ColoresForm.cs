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
    public partial class ColoresForm : Form
    {
        public ColoresForm()
        {
            InitializeComponent();
        }

        Colores colores = new Colores();

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Colores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Colores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ColoresForm_Load(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            ColorIDtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                colores.ColorId = int.Parse(ColorIDtextBox.Text);
                if (colores.Eliminar())
                {
                    MensajeOk("Eliminado correctamente");
                    DescripciontextBox.Clear();
                    ColorIDtextBox.Clear();
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
                colores.Descripcion = DescripciontextBox.Text;
                if (ColorIDtextBox.Text == "")
                {

                    if (colores.Insertar())
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
                    int.TryParse(ColorIDtextBox.Text, out id);
                    colores.ColorId = id;
                    if (colores.Editar())
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
            int.TryParse(ColorIDtextBox.Text, out id);
            colores.ColorId = id;

            colores.Buscar(colores.ColorId);
            DescripciontextBox.Text = colores.Descripcion;
        }
    }
}
