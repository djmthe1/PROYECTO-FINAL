using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TipoDeVehiculos : ClaseMaestra
    {

        public int TipoDeVehiculoId { set; get; }
        public string Descripcion { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public TipoDeVehiculos(int tipoDeVehiculoId, string descripcion)
        {
            this.TipoDeVehiculoId = tipoDeVehiculoId;
            this.Descripcion = descripcion;
        }

        public TipoDeVehiculos() { }

        public override bool Insertar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Insert Into TipoDeVehiculos (Descripcion) Values('{0}')", this.Descripcion));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Editar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Update TipoDeVehiculos set Descripcion='{0}' where TipoDeVehiculoId = {1}", this.Descripcion,this.TipoDeVehiculoId));
                return true; ;
            }
            catch (Exception) { return false; }
        }

        public override bool Eliminar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Delete From TipoDeVehiculos where TipoDeVehiculoId={0}", this.TipoDeVehiculoId));
                return true;
            }
            catch (Exception) { return false; }
        }

       

        public override bool Buscar(int IdBuscado)
        {
           
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from TipoDeVehiculos Where TipoDeVehiculoId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.TipoDeVehiculoId = (int)dt.Rows[0]["TipoDeVehiculoId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from TipoDeVehiculos where " + Condicion + ordenar));
        }
    }
}
