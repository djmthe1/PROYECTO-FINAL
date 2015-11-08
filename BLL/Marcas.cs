using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Marcas : ClaseMaestra
    {

        public int MarcaId { set; get; }
        public string Descripcion { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public Marcas(int marcaId, string descripcion)
        {
            this.MarcaId = marcaId;
            this.Descripcion = descripcion;
        }
        public Marcas() { }

        public override bool Insertar()
        {
            try
            {
                conexion.Ejecutar(String.Format("insert into Marcas (Descripcion) Values('{0}')", this.Descripcion));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Editar()
        {
            try {
                conexion.Ejecutar(String.Format("Update Marcas set Descripcion='{0}' where MarcaId={1}", this.Descripcion,this.MarcaId));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Eliminar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Delete From Marcas where MarcaId={0}", this.MarcaId));
                return true;
            }
            catch (Exception) { return false; }
        }


        public override bool Buscar(int IdBuscado)
        {
            
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Marcas Where MarcaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.MarcaId = (int)dt.Rows[0]["MarcaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Marcas where " + Condicion + ordenar));
        }
    }
}
