﻿using System;
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
    public partial class MarcasForm : Form
    {
        public MarcasForm()
        {
            InitializeComponent();
        }

        Marcas marcas = new Marcas();
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MarcasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Sistema_Ventas_VehiculosDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this._Sistema_Ventas_VehiculosDataSet.Marcas);

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            MarcasIDtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(MarcasIDtextBox.Text, out id);
                marcas.MarcaId = id;

                if (marcas.Buscar(marcas.MarcaId))
                {
 
                    if (marcas.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
                        DescripciontextBox.Clear();
                        MarcasIDtextBox.Clear();
                    }
                    else
                    {
                        MensajeError("Error al Eliminar");
                    }

                }
                else
                {
                    MensajeAdvertencia("Este Id no existe");
                    MarcasIDtextBox.Clear();
                }

            }
            catch (Exception) {
                MensajeError("Error al Eliminar");
            }
        }

        private void botonGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                marcas.Descripcion = DescripciontextBox.Text;
                if (MarcasIDtextBox.Text == "")
                {
                    if (DescripciontextBox.Text != "")
                    {
                        if (marcas.Insertar())
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
                    int.TryParse(MarcasIDtextBox.Text, out id);
                    marcas.MarcaId = id;
                    if (DescripciontextBox.Text != "")
                    {
                        if (marcas.Editar())
                        {
                            DescripciontextBox.Clear();
                            MarcasIDtextBox.Clear();
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
            catch (Exception) { MensajeError("Error al Insertar o Modificar"); }
            }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            InsetarForm InsetarF = new InsetarForm();
            InsetarF.Show();
            this.Close();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(MarcasIDtextBox.Text, out id);
            marcas.MarcaId = id;

            if (marcas.Buscar(marcas.MarcaId))
            {
                DescripciontextBox.Text = marcas.Descripcion;
            }
            else
            {
                MensajeAdvertencia("Id no encontrado");
                MarcasIDtextBox.Clear();
            }
        }
    }
}
