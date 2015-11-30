using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class FacturasDeVentas : ClaseMaestra
    {

        public int FacturaId { set; get; }
        public string Fecha { set; get; }
        public int VehiculoId { set; get; }
        public int PagoInicialEnEfectivo { set; get; }
        public int PagoInicialEnCheque { set; get; }
        public int PrecioAPagar { set; get; }
        public int ClienteId { set; get; }
        
        public string AutorizadoPor { set; get; }
        NumerosTelefonos numerosTelefono = new NumerosTelefonos();
        public List<NumerosTelefonos> numerostelefonos { get; set; }
        public ConexionDb conexion = new ConexionDb();
        public StringBuilder comando = new StringBuilder();

        public FacturasDeVentas(int facturaId, string fecha, int vehiculoId,int clienteId,int pagoInicialEnEfectivo, int pagoInicialEnCheque, int precioAPagar, string autorizadoPor)
        {
            this.FacturaId = facturaId;
            this.Fecha = fecha;
            this.VehiculoId = vehiculoId;
            this.PagoInicialEnEfectivo = pagoInicialEnEfectivo;
            this.PagoInicialEnCheque = pagoInicialEnCheque;
            this.PrecioAPagar = precioAPagar;
            this.ClienteId = clienteId;
            this.AutorizadoPor = autorizadoPor;
        }

        public FacturasDeVentas()
        {
            numerostelefonos = new List<NumerosTelefonos>();
        }

        public void InsertarTelefono(int Id, string Telefono)
        {
            this.numerostelefonos.Add(new NumerosTelefonos(Id, Telefono));

        }

        public void LimpiarTelefono()
        {
            this.numerostelefonos.Clear();
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable datos = new DataTable();

            datos = conexion.ObtenerDatos("Select * from FacturaDeVentas Where FacturaId=" + IdBuscado);
            if (datos.Rows.Count > 0)
            {
                this.FacturaId = (int)datos.Rows[0]["FacturaId"];
                this.Fecha = datos.Rows[0]["Fecha"].ToString();
                this.VehiculoId = (int)datos.Rows[0]["VehiculoId"];
                this.PagoInicialEnEfectivo = (int)datos.Rows[0]["PagoInicialEnEfectivo"];
                this.PagoInicialEnCheque = (int)datos.Rows[0]["PagoInicialEnCheque"];
                this.PrecioAPagar = (int)datos.Rows[0]["PrecioAPagar"];
                this.ClienteId = (int)datos.Rows[0]["ClienteId"];
                this.AutorizadoPor = datos.Rows[0]["AutorizadoPor"].ToString();

            }
            return datos.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retornar = false;
            try
            {
                conexion.Ejecutar(String.Format("Update FacturaDeVentas set Fecha='{0}', VehiculoId={1}, ClienteId={2},PagoInicialEnEfectivo={3}, PagoInicialEnCheque={4}, PrecioAPagar={5}, AutorizadoPor='{6}' where FacturaId={7}", this.Fecha, this.VehiculoId, this.ClienteId, this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor, this.FacturaId));
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
                conexion.Ejecutar(String.Format("Delete From FacturaDeVentas where FacturaId={0}", this.FacturaId));
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
                conexion.Ejecutar(String.Format("Insert Into FacturaDeVentas (Fecha, VehiculoId, ClienteId, PagoInicialEnEfectivo, PagoInicialEnCheque, PrecioAPagar, AutorizadoPor) Values('{0}',{1},{2},{3},{4},{5},'{6}')", this.Fecha, this.VehiculoId, this.ClienteId,this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor));
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
            return conexion.ObtenerDatos(("Select " + Campos + " from FacturaDeVentas where " + Condicion + Orden));
        }
    }
}
