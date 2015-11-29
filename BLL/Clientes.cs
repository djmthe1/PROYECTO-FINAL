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
        public int TelefonoId { set; get; }
        public string Direccion { set; get; }
        public string Cedula { set; get; }
        public string Nacionalidad { set; get; }
        public string Ocupacion { set; get; }
        public string LugarDeNacimiento { set; get; }
        public string Sexo { set; get; }
        NumerosTelefonos numerosTelefono = new NumerosTelefonos();
        public List <NumerosTelefonos> numerostelefonos { get; set; }
        public ConexionDb conexion = new ConexionDb();
        public StringBuilder comando = new StringBuilder();

        public Clientes(int clienteId, string nombreCompleto, string Apodo, int telefonoId, string direccion, string cedula, string nacionalidad, string ocupacion, string lugarDeNacimiento, string sexo, int facturaId) {
            this.ClienteId = clienteId;
            this.NombreCompleto = nombreCompleto;
            this.Apodo = Apodo;
            this.TelefonoId = telefonoId;
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
            numerostelefonos = new List <NumerosTelefonos>();
        }

        public void InsertarTelefono(int Id, int ClienteId, string Telefono)
        {
            this.numerostelefonos.Add(new NumerosTelefonos(Id, ClienteId, Telefono));

        }

        public void LimpiarTelefono()
        {
            this.numerostelefonos.Clear();
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
                this.Apodo = dt.Rows[0]["Apodo"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Cedula = dt.Rows[0]["Cedula"].ToString();
                this.Nacionalidad = dt.Rows[0]["Nacionalidad"].ToString();
                this.Ocupacion = dt.Rows[0]["Ocupacion"].ToString();
                this.LugarDeNacimiento = dt.Rows[0]["LugarDeNacimiento"].ToString();
                this.Sexo = dt.Rows[0]["Sexo"].ToString();

                datosNumerosTelefonos = conexion.ObtenerDatos("Select c.Id as Id, n.Telefono as Telefono from NumerosTelefono c " + "Inner Join Telefonos n On c.TelefonoId = n.TelefonoId " + "Where c.ClienteId=" + IdBuscado);

                LimpiarTelefono();
                foreach (DataRow row in datosNumerosTelefonos.Rows)
                {
                    this.InsertarTelefono((int)row["Id"], (int)row["ClienteId"], row["Numero"].ToString());

                    this.TelefonoId = (int)dt.Rows[0]["TelefonoId"];
                }

            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Clientes set NombreCompleto='{0}', Apodo='{1}', TelefonoId={2}, Direccion='{3}', Cedula='{4}', Nacionalidad='{5}', Ocupacion='{6}', LugarDeNacimiento='{7}', Sexo='{8}' where ClienteId={9}", this.NombreCompleto, this.Apodo, this.TelefonoId, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo, this.ClienteId));
                if (retorno)
                {
                    conexion.Ejecutar("Delete From NumerosTelefono Where ClienteId=" + this.ClienteId);
                    foreach (var Telefono in this.numerostelefonos)
                    {
                        comando.AppendLine(String.Format("insert into NumerosTelefono (ClienteId,Telefono) Values({0},'{1}'); ", this.ClienteId, Telefono.Telefono));
                    }
                    retorno = conexion.Ejecutar(comando.ToString());
                }
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
                retorno = conexion.Ejecutar(String.Format("Insert into Clientes (NombreCompleto, Apodo, TelefonoId, Direccion, Cedula, Nacionalidad, Ocupacion, LugarDeNacimiento, Sexo) Values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}')", this.NombreCompleto, this.Apodo, this.TelefonoId, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo));
                if (retorno)
                {
                    this.ClienteId = (int)conexion.ObtenerDatos("Select Max(ClienteId) as ClienteId from Clientes").Rows[0]["ClienteId"];

                    foreach (var Telefono in this.numerostelefonos)
                    {
                        comando.AppendLine(String.Format("insert into NumerosTelefono (ClienteId,Telefono) Values({0},'{1}'); ", this.ClienteId, Telefono.Telefono));
                    }
                    retorno = conexion.Ejecutar(comando.ToString());
                }
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
