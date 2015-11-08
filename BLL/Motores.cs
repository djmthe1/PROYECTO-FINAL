using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Motores : ClaseMaestra
    {

        public int MotorId { set; get; }
        public string Descripcion { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public Motores(int motorId, string descripcion)
        {
            this.MotorId = motorId;
            this.Descripcion = descripcion;
        }
        public Motores() { }


        public override bool Insertar()
        {
            try
            {
                conexion.Ejecutar(String.Format("insert into Motores (Descripcion) Values('{0}')", this.Descripcion));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Editar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Update Motores set Descripcion='{0}' where MotorId={1}", this.Descripcion,this.MotorId));
                return true;
            }
            catch (Exception) { return false; }
        }

        public override bool Eliminar()
        {
            try
            {
                conexion.Ejecutar(String.Format("Delete From Motores where MotorId={0}", this.MotorId));
                return true;
            }
            catch (Exception) { return false; }
        }

       

        public override bool Buscar(int IdBuscado)
        {
            
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Motores Where MotorId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.MotorId = (int)dt.Rows[0]["MotorId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
           
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Motores where " + Condicion + ordenar));
        }
    }
}
