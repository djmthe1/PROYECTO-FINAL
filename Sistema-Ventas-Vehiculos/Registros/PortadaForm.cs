using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas_Vehiculos.Registros
{
    public partial class PortadaForm : Form
    {
        public PortadaForm()
        {
            InitializeComponent();
        }


        private void PortadaForm_Load(object sender, EventArgs e)
        {
            
        }

        Reportes.PresentarReporte PresentarR = new Reportes.PresentarReporte();

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult opcion;
            opcion = MessageBox.Show("Realmente Desea Cerrar Sesion?", "Registro de Marcas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion== DialogResult.OK) {

                Registros.LoginForm LoginF = new LoginForm();
                LoginF.Show();
                this.Close();
            }
        }

        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MarcasForm MarcasF = new MarcasForm();
            MarcasF.Show();

        }

        private void modeloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ModelosForm ModelosF = new ModelosForm();
            ModelosF.Show();
        }

        private void tipoDeVehiculoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TipoDeVehiculosForm TipoVehiculoF = new TipoDeVehiculosForm();
            TipoVehiculoF.Show();
        }

        private void tipoDeMotorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MotoresForm TipoMotorF = new MotoresForm();
            TipoMotorF.Show();
        }

        private void colorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColoresForm ColorF = new ColoresForm();
            ColorF.Show();
        }

        private void vehiculoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            VehiculosForm VehiculosF = new VehiculosForm();
            VehiculosF.Show();
        }

        private void usuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InsertarUsuarioForm InsertarU = new InsertarUsuarioForm();
            InsertarU.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.ListarForm ListarF = new ListarForm();
            ListarF.Show();
        }

        private void compraDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm ClientesF = new ClientesForm();
            ClientesF.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarForm BuscarF = new BuscarForm();
            BuscarF.Show();
        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graficos.GraficosForm MarcaG = new Graficos.GraficosForm();
            MarcaG.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Reportes.CrystalReportMarcas ReporteM = new Reportes.CrystalReportMarcas();
            PresentarR.crystalReportViewer1.ReportSource = ReporteM;
            PresentarR.ShowDialog();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.CrystalReportModelos ReporteMod = new Reportes.CrystalReportModelos();
            PresentarR.crystalReportViewer1.ReportSource = ReporteMod;
            PresentarR.ShowDialog();
        }

        private void coloresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.CrystalReportColores ReporteC = new Reportes.CrystalReportColores();
            PresentarR.crystalReportViewer1.ReportSource = ReporteC;
            PresentarR.ShowDialog();
        }

        private void tipoDeVehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.CrystalReportTipoVehiculo ReporteTV = new Reportes.CrystalReportTipoVehiculo();
            PresentarR.crystalReportViewer1.ReportSource = ReporteTV;
            PresentarR.ShowDialog();
        }

        private void tipoDeMotoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.CrystalReportMotores ReporteTM = new Reportes.CrystalReportMotores();
            PresentarR.crystalReportViewer1.ReportSource = ReporteTM;
            PresentarR.ShowDialog();
        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.CrystalReportVehiculo ReporteV = new Reportes.CrystalReportVehiculo();
            PresentarR.crystalReportViewer1.ReportSource = ReporteV;
            PresentarR.ShowDialog();
        }
    }
}
