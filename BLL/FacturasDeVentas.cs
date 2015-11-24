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
        public int MarcaId { set; get; }
        public int ModeloId { set; get; }
        public int MotorId { set; get; }
        public int ColorId { set; get; }
        public int TipoDeVehiculoId { set; get; }
        public int EstadoDelVehiculoId { set; get; }
        public int PrecioVehiculo { set; get; }
        public int PagoInicialEnEfectivo { set; get; }
        public int PagoInicialEnCheque { set; get; }
        public int PrecioAPagar { set; get; }
        public int AutorizadoPor { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public FacturasDeVentas(int facturaId, string fecha, int año, int marcaId, int modeloId, int motorId, int colorId, int tipoDeVehiculoId, int estadoDelVehiculoId, int precioVehiculo, int pagoInicialEnEfectivo, int pagoInicialEnCheque, int precioAPagar, int autorizadoPor)
        {
            this.FacturaId = facturaId;
            this.Fecha = fecha;
            this.Año = año;
            this.MarcaId = marcaId;
            this.ModeloId = modeloId;
            this.MotorId = motorId;
            this.ColorId = colorId;
            this.TipoDeVehiculoId = tipoDeVehiculoId;
            this.EstadoDelVehiculoId = estadoDelVehiculoId;
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
                this.MarcaId = (int)dt.Rows[0]["MarcaId"];
                this.ModeloId = (int)dt.Rows[0]["ModeloId"];
                this.MotorId = (int)dt.Rows[0]["MotorId"];
                this.ColorId = (int)dt.Rows[0]["ColorId"];
                this.TipoDeVehiculoId = (int)dt.Rows[0]["TipoDeVehiculoId"];
                this.EstadoDelVehiculoId = (int)dt.Rows[0]["EstadoDelVehiculoId"];
                this.PrecioVehiculo = (int)dt.Rows[0]["PrecioVehiculo"];
                this.PagoInicialEnEfectivo = (int)dt.Rows[0]["PagoInicialEnEfectivo"];
                this.PagoInicialEnCheque = (int)dt.Rows[0]["PagoInicialEnCheque"];
                this.PrecioAPagar = (int)dt.Rows[0]["PrecioAPagar"];
                this.AutorizadoPor = (int)dt.Rows[0]["AutorizadoPor"];
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retornar = false;
            try
            {
                conexion.Ejecutar(String.Format("Update FacturaDeVentas set Fecha='{0}', Año={1}, MarcaId={2}, ModeloId={3}, MotorId={4}, ColorId={5}, TipoDeVehiculoId={6}, EstadoDelVehiculoId={7}, PrecioVehiculo={8}, PagoInicialEnEfectivo={9}, PagoInicialEnCheque={10}, PrecioAPagar={11}, AutorizadoPor='{12}' where FacturaId={13}", this.Fecha, this.Año, this.MarcaId, this.ModeloId, this.MotorId, this.ColorId, this.TipoDeVehiculoId, this.EstadoDelVehiculoId, this.PrecioVehiculo, this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor, this.FacturaId));
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
                conexion.Ejecutar(String.Format("Insert Into FacturaDeVentas (Fecha,Año,MarcaId,ModeloId,MotorId,ColorId,TipoDeVehiculoId,EstadoDelVehiculoId,PrecioVehiculo,PagoInicialEnEfectivo,PagoInicialEnCheque,PrecioAPagar,AutorizadoPor) Values('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},'{12}')", this.Fecha, this.Año, this.MarcaId, this.ModeloId, this.MotorId, this.ColorId, this.TipoDeVehiculoId, this.EstadoDelVehiculoId, this.PrecioVehiculo, this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor));
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
