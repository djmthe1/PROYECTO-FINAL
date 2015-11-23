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
        public int FacturaId { set; get; }
        public ConexionDb conexion = new ConexionDb();
        public StringBuilder comando = new StringBuilder();
        List <NumerosTelefono> NumerosTelefono { set; get; }
        public NumerosTelefono NumeroC = new NumerosTelefono();

        public Clientes(int clienteId, string nombreCompleto, string Apodo, int telefonoId, string direccion, string cedula, string nacionalidad, string ocupacion, string lugarDeNacimiento, string sexo, int facturaId) {
            this.ClienteId = clienteId;
            this.NombreCompleto = nombreCompleto;
            this.Apodo = Apodo;
            this.TelefonoId = telefonoId;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Nacionalidad = nacionalidad;
            this.Ocupacion = ocupacion;
            this.LugarDeNacimiento = lugarDeNacimiento;
            this.Sexo = sexo;
            this.FacturaId = facturaId;
        }

        public Clientes()
        {
            NumerosTelefono = new List <NumerosTelefono>();
        }

        public void InsertarNumerosTelefono (int id, int clienteId, string telefono)
        {
            this.NumerosTelefono.Add(new NumerosTelefono(id, ClienteId, telefono));

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
                this.FacturaId = (int)dt.Rows[0]["FacturaId"];
                datosNumerosTelefonos = conexion.ObtenerDatos("Select ct.ClienteId, c.NombreCompleto, c.Apodo, c.Direccion, c.Cedula, c.Nacionalidad, c.Ocupacion, c.LugarDeNacimiento, c.FacturaId, c.Sexo from NumerosTelefono ct Inner Join Cliente c On ct.ClienteId=c.ClienteId where c.ClienteId =" + this.ClienteId);
                foreach (DataRow row in datosNumerosTelefonos.Rows)
                {
                    this.InsertarNumerosTelefono((int)row["Id"], (int)row["ClienteId"], row["Telefono"].ToString());
                }
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Clientes set NombreCompleto='{0}', Apodo='{1}', TelefonoId={2}, Direccion='{3}', Cedula='{4}', Nacionalidad='{5}', Ocupacion='{6}', LugarDeNacimiento='{7}', Sexo='{8}', FacturaId={9} where ClienteId={10}", this.NombreCompleto, this.Apodo, this.TelefonoId, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo, this.FacturaId, this.ClienteId));
                retorno = true;
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("Delete from NumerosTelefono where PersonaId={0}", this.ClienteId));

                    foreach (var Cliente in this.NumerosTelefono)
                    {
                        comando.AppendLine(String.Format("insert into NumerosTelefono (ClienteId,Telefono) Values({0},'{1}')", this.ClienteId, Cliente.Telefono));
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
                conexion.Ejecutar(String.Format("Insert into Clientes (NombreCompleto, Apodo, TelefonoId, Direccion, Cedula, Nacionalidad, Ocupacion, LugarDeNacimiento, Sexo, FacturaId) Values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}',{9})", this.NombreCompleto, this.Apodo, this.TelefonoId, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo, this.FacturaId));
                retorno = true;

                if (retorno)
                {
                    this.ClienteId = (int) conexion.ObtenerValor ("Select Max (ClienteId) From Clientes");

                    this.InsertarNumerosTelefono (NumeroC.Id, this.ClienteId, NumeroC.Telefono);

                    foreach (var Cliente in this.NumerosTelefono)
                    {
                        comando.AppendLine(String.Format("Insert into NumerosTelefono (ClienteId,Telefono) Values({0},'{1}')", this.ClienteId, Cliente.Telefono));
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
