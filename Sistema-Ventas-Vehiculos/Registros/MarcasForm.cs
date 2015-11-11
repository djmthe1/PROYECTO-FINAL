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
                if (MarcasIDtextBox.Text.Length == 0)
                {
                    
                }
                listarDataGridView.Refresh();
                }
            }
            catch (Exception) {
                MessageBox.Show("Error al Insertar o Modificar");
            }

            listarDataGridView.Refresh();
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
    }
}
