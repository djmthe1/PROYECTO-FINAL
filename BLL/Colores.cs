using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Colores : ClaseMaestra
    {

        public int ColorId { set; get; }
        public string Descripcion { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public Colores(int colorId, string descripcion)
        {
            this.ColorId = colorId;
            this.Descripcion =descripcion;
        }

        public Colores() { }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Colores (Descripcion) Values('{0}')", this.Descripcion));
                retorno = true;
            }
            catch (Exception ex) {throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Colores set Descripcion='{0}' where ColorId={1}", this.Descripcion,this.ColorId));
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
                conexion.Ejecutar(String.Format("Delete From Colores where ColorId={0}", this.ColorId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }


        public override bool Buscar(int IdBuscado)
        {
            
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Colores Where ColorId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ColorId = (int)dt.Rows[0]["ColorId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Colores where " + Condicion + Orden));
        }
    }
}
