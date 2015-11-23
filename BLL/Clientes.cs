using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Clientes : ClaseMaestra
    {

        public int ClienteId { set; get; }
        public string NombreCompleto { set; get; }
        public string Apodo { set; get; }
        public string Telefono { set; get; }
        public string Celular { set; get; }
        public string Direccion { set; get; }
        public string Cedula { set; get; }
        public string Nacionalidad { set; get; }
        public string Ocupacion { set; get; }
        public string LugarDeNacimiento { set; get; }
        public string Sexo { set; get; }
      
        public ConexionDb conexion = new ConexionDb();
        public StringBuilder comando = new StringBuilder();


        public Clientes(int clienteId, string nombreCompleto, string Apodo, string telefono,string celular, string direccion, string cedula, string nacionalidad, string ocupacion, string lugarDeNacimiento, string sexo, int facturaId) {
            this.ClienteId = clienteId;
            this.NombreCompleto = nombreCompleto;
            this.Apodo = Apodo;
            this.Telefono = telefono;
            this.Cedula = cedula;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Nacionalidad = nacionalidad;
            this.Ocupacion = ocupacion;
            this.LugarDeNacimiento = lugarDeNacimiento;
            this.Sexo = sexo;
            
        }

        public Clientes()
        {
           
        }



        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable datosNumerosTelefonos = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Clientes Where ClienteId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                this.NombreCompleto = dt.Rows[0]["NombreCompleto"].ToString();
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
                this.Celular = dt.Rows[0]["Celular"].ToString();
                this.Apodo = dt.Rows[0]["Apodo"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Cedula = dt.Rows[0]["Cedula"].ToString();
                this.Nacionalidad = dt.Rows[0]["Nacionalidad"].ToString();
                this.Ocupacion = dt.Rows[0]["Ocupacion"].ToString();
                this.LugarDeNacimiento = dt.Rows[0]["LugarDeNacimiento"].ToString();
                this.Sexo = dt.Rows[0]["Sexo"].ToString();
                
                
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Clientes set NombreCompleto='{0}', Apodo='{1}', Telefono='{2}',Celular='{3}', Direccion='{4}', Cedula='{5}', Nacionalidad='{6}', Ocupacion='{7}', LugarDeNacimiento='{8}', Sexo='{9}' where ClienteId={10}", this.NombreCompleto, this.Apodo, this.Telefono,this.Celular, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo, this.ClienteId));
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
                conexion.Ejecutar(String.Format("Delete From Clientes where ClienteId={0}", this.ClienteId + ";" + "Delete from NumerosTelefono where Id = " + this.ClienteId));
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
                conexion.Ejecutar(String.Format("Insert into Clientes (NombreCompleto, Apodo, Telefono, Celular, Direccion, Cedula, Nacionalidad, Ocupacion, LugarDeNacimiento, Sexo, FacturaId) Values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10})", this.NombreCompleto, this.Apodo, this.Telefono,this.Celular, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo));
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
            return conexion.ObtenerDatos(("Select " + Campos + " from Clientes where " + Condicion + Orden));
        }
    }
}
