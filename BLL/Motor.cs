using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Motor : ClaseMaestra
    {

        public int MotorId { set; get; }
        public string Descripcion { set; get; }

        public Motor()
        {
            this.MotorId = 0;
            this.Descripcion = "";
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Motores Where MotorId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.MotorId = (int)dt.Rows[0]["MotorId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Update into Motores (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete From Motores where MotorId={0}", this.MotorId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("insert into Motores (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Motores where " + Condicion + ordenar));
        }
    }
}
