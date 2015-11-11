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
            MessageBox.Show(mensaje, "Registro de Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

      

        private void listarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                marcas.MarcaId = int.Parse(MarcasIDtextBox.Text);
                if (marcas.Eliminar())
                {
                    
                }
                listarDataGridView.Refresh();
            }
            catch (Exception) {
                MessageBox.Show("Error al Borrar");
            }
        }

        private void botonGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                marcas.Descripcion = DescripciontextBox.Text;
                if (MarcasIDtextBox.Text == "")
                {
                    
                    if (marcas.Insertar())
                    {
                        DescripciontextBox.Clear();
                        MensajeOk("Insertado Correctamente");
                    }
                    else {
                        MensajeError("Error al Insertar");
                    }
                            
                    
                }
                else
                {
                    int id = 0;
                    int.TryParse(MarcasIDtextBox.Text,out id);
                    marcas.MarcaId = id;
                    if (marcas.Editar())
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

            listarDataGridView.Refresh();
        }
    }
}
