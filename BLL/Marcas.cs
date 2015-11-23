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
            bool retornar = false;
            try
            {
                conexion.Ejecutar(String.Format("insert into Marcas (Descripcion) Values('{0}')", this.Descripcion));
                retornar = true;
            }
            catch (Exception ex) { throw ex; }
            return retornar;
        }

        public override bool Editar()
        {
            bool retornar = false;
            try {
                conexion.Ejecutar(String.Format("Update Marcas set Descripcion='{0}' where MarcaId={1}", this.Descripcion,this.MarcaId));
                retornar = true;
            }
            catch (Exception ex) { throw ex; }
            return retornar;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Delete From Marcas where MarcaId={0}", this.MarcaId));
                retorno= true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
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
            return conexion.ObtenerDatos(("Select " + Campos + " from Marcas where " + Condicion + Orden));
        }
    }
}
