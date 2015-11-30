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
            MessageBox.Show(mensaje, "Registro de Colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Colores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                int id = 0;
                int.TryParse(ColorIDtextBox.Text, out id);
                colores.ColorId = id;

                if (colores.Buscar(colores.ColorId))
                {

                    if (colores.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
                        DescripciontextBox.Clear();
                        ColorIDtextBox.Clear();
                    }
                    else {
                        MensajeError("Error al eliminar");
                    }
                }
                else {
                    MensajeAdvertencia("Este Id no existe");
                    ColorIDtextBox.Clear();
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

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                colores.Descripcion = DescripciontextBox.Text;
                if (ColorIDtextBox.Text == "")
                {
                    if (DescripciontextBox.Text != "")
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
                    else {
                        MensajeAdvertencia("Inserte la descripcion");
                    }

                }
                else
                {
                    int id = 0;
                    int.TryParse(ColorIDtextBox.Text, out id);
                    colores.ColorId = id;
                    if (DescripciontextBox.Text != "")
                    {
                        if (colores.Editar())
                        {
                            DescripciontextBox.Clear();
                            ColorIDtextBox.Clear();
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
            int.TryParse(ColorIDtextBox.Text, out id);
            colores.ColorId = id;

            if (colores.Buscar(colores.ColorId))
            {
                DescripciontextBox.Text = colores.Descripcion;
            }
            else {
                MensajeAdvertencia("Id no encontrado");
                ColorIDtextBox.Clear();
            }
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescripciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ColorIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
