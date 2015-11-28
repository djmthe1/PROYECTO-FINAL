using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class FacturasDeVentas : ClaseMaestra
    {

        public int FacturaId { set; get; }
        public string Fecha { set; get; }
        public int Año { set; get; }
        public string Marca { set; get; }
        public string Modelo { set; get; }
        public string Motor { set; get; }
        public string Color { set; get; }
        public string TipoDeVehiculo { set; get; }
        public string EstadoDelVehiculo { set; get; }
        public int PrecioVehiculo { set; get; }
        public int PagoInicialEnEfectivo { set; get; }
        public int PagoInicialEnCheque { set; get; }
        public int PrecioAPagar { set; get; }
        public string AutorizadoPor { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public FacturasDeVentas(int facturaId, string fecha, int año, string marca, string modelo, string motor, string color, string tipoDeVehiculo, string estadoDelVehiculo, int precioVehiculo, int pagoInicialEnEfectivo, int pagoInicialEnCheque, int precioAPagar, string autorizadoPor)
        {
            this.FacturaId = facturaId;
            this.Fecha = fecha;
            this.Año = año;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Motor = motor;
            this.Color = color;
            this.TipoDeVehiculo = tipoDeVehiculo;
            this.EstadoDelVehiculo = estadoDelVehiculo;
            this.PrecioVehiculo = precioVehiculo;
            this.PagoInicialEnEfectivo = pagoInicialEnEfectivo;
            this.PagoInicialEnCheque = pagoInicialEnCheque;
            this.PrecioAPagar = precioAPagar;
            this.AutorizadoPor = autorizadoPor;
        }

        public FacturasDeVentas() { }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from FacturaDeVentas Where FacturaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.FacturaId = (int)dt.Rows[0]["FacturaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Año = (int)dt.Rows[0]["Año"];
                this.Marca = dt.Rows[0]["Marca"].ToString();
                this.Modelo = dt.Rows[0]["Modelo"].ToString();
                this.Motor = dt.Rows[0]["Motor"].ToString();
                this.Color = dt.Rows[0]["Color"].ToString();
                this.TipoDeVehiculo = dt.Rows[0]["TipoDeVehiculo"].ToString();
                this.EstadoDelVehiculo = dt.Rows[0]["EstadoDelVehiculo"].ToString();
                this.PrecioVehiculo = (int)dt.Rows[0]["PrecioVehiculo"];
                this.PagoInicialEnEfectivo = (int)dt.Rows[0]["PagoInicialEnEfectivo"];
                this.PagoInicialEnCheque = (int)dt.Rows[0]["PagoInicialEnCheque"];
                this.PrecioAPagar = (int)dt.Rows[0]["PrecioAPagar"];
                this.AutorizadoPor = dt.Rows[0]["AutorizadoPor"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retornar = false;
            try
            {
                conexion.Ejecutar(String.Format("Update FacturaDeVentas set Fecha='{0}', Año={1}, Marca='{2}', Modelo='{3}', Motor='{4}', Color='{5}', TipoDeVehiculo='{6}', EstadoDelVehiculo='{7}', PrecioVehiculo={8}, PagoInicialEnEfectivo={9}, PagoInicialEnCheque={10}, PrecioAPagar={11}, AutorizadoPor='{12}' where FacturaId={13}", this.Fecha, this.Año, this.Marca, this.Modelo, this.Motor, this.Color, this.TipoDeVehiculo, this.EstadoDelVehiculo, this.PrecioVehiculo, this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor, this.FacturaId));
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
                conexion.Ejecutar(String.Format("Insert Into FacturaDeVentas (Fecha,Año,MarcaId,ModeloId,MotorId,ColorId,TipoDeVehiculoId,EstadoDelVehiculoId,PrecioVehiculo,PagoInicialEnEfectivo,PagoInicialEnCheque,PrecioAPagar,AutorizadoPor) Values('{0}',{1},{2},'{3}','{4}','{5}','{6}','{7}',{8},{9},{10},{11},'{12}')", this.Fecha, this.Año, this.Marca, this.Modelo, this.Motor, this.Color, this.TipoDeVehiculo, this.EstadoDelVehiculo, this.PrecioVehiculo, this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor));
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
