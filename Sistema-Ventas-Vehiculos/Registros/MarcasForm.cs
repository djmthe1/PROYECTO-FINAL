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

        Marcas M = new Marcas();

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
                M.MarcaId = int.Parse(MarcasIDtextBox.Text);
                M.Eliminar();
                MessageBox.Show("Marca Borrada");
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
                if (MarcasIDtextBox.Text.Length == 0)
                {
                    M.Descripcion = DescripciontextBox.Text;
                    M.Insertar();
                    MessageBox.Show("Marca Insertada");
                }
                else
                {
                    M.MarcaId = int.Parse(MarcasIDtextBox.Text);
                    M.Descripcion = DescripciontextBox.Text;
                    M.Editar();
                    MessageBox.Show("Marca Modificada");
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
