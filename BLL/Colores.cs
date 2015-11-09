using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class Colores : ClaseMaestra
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
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Colores (Descripcion) Values('{0}'')", this.Descripcion));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Editar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Update Colores set Descripcion='{0}' where ColorId={1}", this.Descripcion,this.ColorId));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Eliminar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Delete From Colores where ColorId={0}", this.ColorId));
                return true;
            }
            catch (Exception) { return false; }
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
            return conexion.ObtenerDatos(("Select " + Campos + " from Colores where " + Condicion + ordenar));
        }
    }
}
