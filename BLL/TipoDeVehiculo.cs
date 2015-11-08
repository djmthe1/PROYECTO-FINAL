using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TipoDeVehiculo : ClaseMaestra
    {

        public int TipoDeVehiculoId { set; get; }
        public string Descripcion { set; get; }

        public TipoDeVehiculo()
        {
            this.TipoDeVehiculoId = 0;
            this.Descripcion = "";
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from TipoDeVehiculos Where TipoDeVehiculoId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.TipoDeVehiculoId = (int)dt.Rows[0]["TipoDeVehiculoId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Update into TipoDeVehiculos (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete From TipoDeVehiculos where TipoDeVehiculoId={0}", this.TipoDeVehiculoId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Insert Into TipoDeVehiculos (Descripcion) Values('{0}'')", this.Descripcion));
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from TipoDeVehiculos where " + Condicion + ordenar));
        }
    }
}
