using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Modelos : ClaseMaestra
    {
        public ConexionDb conexion = new ConexionDb();
        public int ModeloId { set; get; }
        public string Descripcion { set; get; }

        public Modelos(int modeloId,string descripcion)
        {
            this.ModeloId = modeloId ;
            this.Descripcion = descripcion;
        }

        public Modelos() { }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("insert into Modelos (Descripcion) Values('{0}')", this.Descripcion));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Modelos set Descripcion='{0}' where ModeloId={1}", this.Descripcion,this.ModeloId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Delete From Modelos where ModeloId={0}", this.ModeloId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public DataTable ObtenerModeloId(string Descripcion)
        {
            return conexion.ObtenerDatos(String.Format("select ModeloId from Modelos where Descripcion ='{0}'", Descripcion));
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Modelos Where ModeloId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ModeloId = (int)dt.Rows[0]["ModeloId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Modelos where " + Condicion + Orden));
        }
    }
}
