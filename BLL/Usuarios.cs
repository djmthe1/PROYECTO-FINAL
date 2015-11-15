using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {

        public int UsuarioId { set; get; }
        public string Nombre { set; get; }
        public string Pass { set; get; }
        public int Prioridad { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public Usuarios(int usuarioId, string nombre, string pass, int prioridad){
            this.UsuarioId = usuarioId;
            this.Nombre = nombre;
            this.Pass = pass;
            this.Prioridad = prioridad;
        }

        public Usuarios() {}

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Usuarios Where UsuarioId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Pass = dt.Rows[0]["Pass"].ToString();
                this.Prioridad = (int)dt.Rows[0]["Prioridad"];
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Usuarios set (Nombre,Pass,Prioridad) Values('{0}'{1}'{2}') where UsuarioId={4}", this.Nombre, this.Pass, this.Prioridad, this.UsuarioId));
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
                conexion.Ejecutar(String.Format("Delete From Usuarios where UsuarioId={0}", this.UsuarioId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Usuarios (Nombre,Pass,Prioridad) Values('{0}'{1}'{2}')", this.Nombre,this.Pass,this.Prioridad));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Usuarios where " + Condicion + ordenar));
        }
    }
}
