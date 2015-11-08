using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Modelo : ClaseMaestra
    {

        public int ModeloId { set; get; }
        public string Descripcion { set; get; }

        public Modelo()
        {
            this.ModeloId = 0;
            this.Descripcion = "";
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Modelos Where ModeloId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ModeloId = (int)dt.Rows[0]["ModeloId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Update into Modelos (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete From Modelos where ModeloId={0}", this.ModeloId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("insert into Modelos (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Modelos where " + Condicion + ordenar));
        }
    }
}
