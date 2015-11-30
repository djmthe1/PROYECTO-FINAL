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
        public string EstadoDelVehiculo { set; get; }
        public string Modelo { set; get; }
        public string Marca { set; get; }
        public string Motor { set; get; }
        public string Color { set; get; }
        public int Año { set; get; }
        public string NoChasis { set; get; }
        public string TipoDeVehiculo { set; get; }
        public int Kilometraje { set; get; }
        public int Precio { set; get; }
        public string Placa { set; get; }
        public string Matricula { set; get; }
        public bool EspejoRetrovisorInterno { set; get; }
        public bool EspejoRetrovisorDerecho { set; get; }
        public bool EspejoRetrovisorIzquierdo { set; get; }
        public bool Radio { set; get; }
        public bool Gato { set; get; }
        public bool Gomas { set; get; }
        public bool GomaDeRepuesto { set; get; }
        public bool Alfombras { set; get; }
        public bool Botiquin { set; get; }
        public bool TaponDeGasolina { set; get; }
        public bool TaponDeRadiador { set; get; }
        public bool Encendedor { set; get; }
        public bool ManualDeUsuario { set; get; }
        public bool DuplicadoDeLlaveDeEncendido { set; get; }
        public bool LlaveDeRueda { set; get; }
        public int PagoInicialEnEfectivo { set; get; }
        public int PagoInicialEnCheque { set; get; }
        public int PrecioAPagar { set; get; }
        public int ClienteId { set; get; }
        public string NombreCompleto { set; get; }
        public string Apodo { set; get; }
        public string Direccion { set; get; }
        public string Cedula { set; get; }
        public string Nacionalidad { set; get; }
        public string Ocupacion { set; get; }
        public string LugarDeNacimiento { set; get; }
        public string Sexo { set; get; }
        public string AutorizadoPor { set; get; }
        NumerosTelefonos numerosTelefono = new NumerosTelefonos();
        public List<NumerosTelefonos> numerostelefonos { get; set; }
        public ConexionDb conexion = new ConexionDb();
        public StringBuilder comando = new StringBuilder();

        public FacturasDeVentas(int facturaId, string fecha, int vehiculoId, string estadoDelVehiculo, string modelo, string marca, string motor, string color, int año, string noChasis, string tipoDeVehiculo, int kilometraje, int precio, string placa, string matricula, bool espejoRetrovisorInterno, bool espejoRetrovisorDerecho, bool espejoRetrovisorIzquierdo, bool radio, bool gato, bool gomas, bool gomaDeRepuesto, bool alfombras, bool botiquin, bool taponDeGasolina, bool taponDeRadiador, bool encendedor, bool manualDeUsuario, bool duplicadoDeLlaveDeEncendido, bool llaveDeRueda, int clienteId, string nombreCompleto, string Apodo, string direccion, string cedula, string nacionalidad, string ocupacion, string lugarDeNacimiento, string sexo, int pagoInicialEnEfectivo, int pagoInicialEnCheque, int precioAPagar, string autorizadoPor)
        {
            this.FacturaId = facturaId;
            this.Fecha = fecha;
            this.VehiculoId = vehiculoId;
            this.EstadoDelVehiculo = estadoDelVehiculo;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Motor = motor;
            this.Color = color;
            this.Año = año;
            this.NoChasis = noChasis;
            this.TipoDeVehiculo = tipoDeVehiculo;
            this.Kilometraje = kilometraje;
            this.Precio = precio;
            this.Placa = placa;
            this.Matricula = matricula;
            this.EspejoRetrovisorInterno = espejoRetrovisorInterno;
            this.EspejoRetrovisorDerecho = espejoRetrovisorDerecho;
            this.EspejoRetrovisorIzquierdo = espejoRetrovisorIzquierdo;
            this.Radio = radio;
            this.Gato = gato;
            this.Gomas = gomas;
            this.GomaDeRepuesto = gomaDeRepuesto;
            this.Alfombras = alfombras;
            this.Botiquin = botiquin;
            this.TaponDeGasolina = taponDeGasolina;
            this.TaponDeRadiador = taponDeRadiador;
            this.Encendedor = encendedor;
            this.ManualDeUsuario = manualDeUsuario;
            this.DuplicadoDeLlaveDeEncendido = duplicadoDeLlaveDeEncendido;
            this.LlaveDeRueda = llaveDeRueda;
            this.PagoInicialEnEfectivo = pagoInicialEnEfectivo;
            this.PagoInicialEnCheque = pagoInicialEnCheque;
            this.PrecioAPagar = precioAPagar;
            this.ClienteId = clienteId;
            this.NombreCompleto = nombreCompleto;
            this.Apodo = Apodo;
            this.Cedula = cedula;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Nacionalidad = nacionalidad;
            this.Ocupacion = ocupacion;
            this.LugarDeNacimiento = lugarDeNacimiento;
            this.Sexo = sexo;
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
            DataTable datosNumerosTelefonos = new DataTable();

            datos = conexion.ObtenerDatos("Select * from FacturaDeVentas Where FacturaId=" + IdBuscado);
            if (datos.Rows.Count > 0)
            {
                this.FacturaId = (int)datos.Rows[0]["FacturaId"];
                this.Fecha = datos.Rows[0]["Fecha"].ToString();
                this.VehiculoId = (int)datos.Rows[0]["VehiculoId"];
                this.EstadoDelVehiculo = datos.Rows[0]["EstadoDelVehiculo"].ToString();
                this.Modelo = datos.Rows[0]["Modelo"].ToString();
                this.Marca = datos.Rows[0]["Marca"].ToString();
                this.Motor = datos.Rows[0]["Motor"].ToString();
                this.Color = datos.Rows[0]["Color"].ToString();
                this.Año = (int)datos.Rows[0]["Año"];
                this.NoChasis = datos.Rows[0]["NoChasis"].ToString();
                this.TipoDeVehiculo = datos.Rows[0]["TipoVehiculo"].ToString();
                this.Kilometraje = (int)datos.Rows[0]["Kilometraje"];
                this.Precio = (int)datos.Rows[0]["Precio"];
                this.Placa = datos.Rows[0]["Placa"].ToString();
                this.Matricula = datos.Rows[0]["Matricula"].ToString();
                this.EspejoRetrovisorInterno = (bool)datos.Rows[0]["EspejoRetrovisorInterno"];
                this.EspejoRetrovisorDerecho = (bool)datos.Rows[0]["EspejoRetrovisorDerecho"];
                this.EspejoRetrovisorIzquierdo = (bool)datos.Rows[0]["EspejoRetrovisorIzquierdo"];
                this.Radio = (bool)datos.Rows[0]["Radio"];
                this.Gato = (bool)datos.Rows[0]["Gato"];
                this.Gomas = (bool)datos.Rows[0]["Gomas"];
                this.GomaDeRepuesto = (bool)datos.Rows[0]["GomaDeRepuesto"];
                this.Alfombras = (bool)datos.Rows[0]["Alfombras"];
                this.Botiquin = (bool)datos.Rows[0]["Botiquin"];
                this.TaponDeGasolina = (bool)datos.Rows[0]["TaponDeGasolina"];
                this.TaponDeRadiador = (bool)datos.Rows[0]["TaponDeRadiador"];
                this.Encendedor = (bool)datos.Rows[0]["Encendedor"];
                this.ManualDeUsuario = (bool)datos.Rows[0]["ManualDeUsuario"];
                this.DuplicadoDeLlaveDeEncendido = (bool)datos.Rows[0]["DuplicadoDeLlaveDeEncendido"];
                this.LlaveDeRueda = (bool)datos.Rows[0]["LlaveDeRueda"];
                this.PagoInicialEnEfectivo = (int)datos.Rows[0]["PagoInicialEnEfectivo"];
                this.PagoInicialEnCheque = (int)datos.Rows[0]["PagoInicialEnCheque"];
                this.PrecioAPagar = (int)datos.Rows[0]["PrecioAPagar"];
                this.ClienteId = (int)datos.Rows[0]["ClienteId"];
                this.NombreCompleto = datos.Rows[0]["NombreCompleto"].ToString();
                this.Apodo = datos.Rows[0]["Apodo"].ToString();
                this.Direccion = datos.Rows[0]["Direccion"].ToString();
                this.Cedula = datos.Rows[0]["Cedula"].ToString();
                this.Nacionalidad = datos.Rows[0]["Nacionalidad"].ToString();
                this.Ocupacion = datos.Rows[0]["Ocupacion"].ToString();
                this.LugarDeNacimiento = datos.Rows[0]["LugarDeNacimiento"].ToString();
                this.Sexo = datos.Rows[0]["Sexo"].ToString();

                datosNumerosTelefonos = conexion.ObtenerDatos(String.Format("select C.NombreCompleto, T.Telefono as Telefono from FacturaDeVentas C inner join NumerosTelefono T on C.ClienteId = T.ClienteId where C.ClienteId = {0}", IdBuscado));
                LimpiarTelefono();
                foreach (DataRow row in datosNumerosTelefonos.Rows)
                {
                    InsertarTelefono(1, row["Telefono"].ToString());
                }
                this.AutorizadoPor = datos.Rows[0]["AutorizadoPor"].ToString();

            }
            return datos.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retornar = false;
            try
            {
                conexion.Ejecutar(String.Format("Update FacturaDeVentas set Fecha='{0}', VehiculoId={1}, EstadoDelVehiculo='{2}', Modelo='{3}', Marca='{4}', Motor='{5}', Color='{6}', Año={7}, NoChasis='{8}', TipoVehiculo='{9}', Kilometraje={10}, Precio={11}, Placa='{12}', Matricula='{13}', EspejoRetrovisorInterno='{14}', EspejoRetrovisorDerecho='{15}', EspejoRetrovisorIzquierdo='{16}', Radio='{17}', Gato='{18}', Gomas='{19}', GomaDeRepuesto='{20}', Alfombras='{21}', Botiquin='{22}', TaponDeGasolina='{23}', TaponDeRadiador='{24}', Encendedor='{25}', ManualDeUsuario='{26}', DuplicadoDeLlaveDeEncendido='{27}', LlaveDeRueda='{28}', ClienteId={29}, NombreCompleto='{30}', Apodo='{31}', Direccion='{32}', Cedula='{33}', Nacionalidad='{34}', Ocupacion='{35}', LugarDeNacimiento='{36}', Sexo='{37}', PagoInicialEnEfectivo={38}, PagoInicialEnCheque={39}, PrecioAPagar={40}, AutorizadoPor='{41}' where FacturaId={42}", this.Fecha, this.VehiculoId, this.EstadoDelVehiculo, this.Modelo, this.Marca, this.Motor, this.Color, this.Año, this.NoChasis, this.TipoDeVehiculo, this.Kilometraje, this.Precio, this.Placa, this.Matricula, this.EspejoRetrovisorInterno, this.EspejoRetrovisorDerecho, this.EspejoRetrovisorIzquierdo, this.Radio, this.Gato, this.Gomas, this.GomaDeRepuesto, this.Alfombras, this.Botiquin, this.TaponDeGasolina, this.TaponDeRadiador, this.Encendedor, this.ManualDeUsuario, this.DuplicadoDeLlaveDeEncendido, this.LlaveDeRueda, this.ClienteId, this.NombreCompleto, this.Apodo, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo, this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor, this.FacturaId));
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
                conexion.Ejecutar(String.Format("Insert Into FacturaDeVentas (Fecha, VehiculoId, EstadoDelVehiculo, Año, NoChasis, Kilometraje, Precio, Placa, Matricula, Marca, Modelo, Color, TipoVehiculo, Motor, EspejoRetrovisorInterno, EspejoRetrovisorDerecho, EspejoRetrovisorIzquierdo, Radio, Gato, Gomas, GomaDeRepuesto, Alfombras, Botiquin, TaponDeGasolina, TaponDeRadiador, Encendedor, ManualDeUsuario, DuplicadoDeLlaveDeEncendido, LlaveDeRueda, ClienteId, NombreCompleto, Apodo, Direccion, Cedula, Nacionalidad, Ocupacion, LugarDeNacimiento, Sexo, PagoInicialEnEfectivo, PagoInicialEnCheque, PrecioAPagar, AutorizadoPor) Values('{0}',{1},'{2}',{3},'{4}',{5},{6},'{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}',{29},'{30}','{31}','{32}','{33}','{34}','{35}','{36}',{37},{38},{39},'{40}','{41}')", this.Fecha, this.VehiculoId, this.EstadoDelVehiculo, this.Año, this.NoChasis, this.Kilometraje, this.Precio, this.Placa, this.Matricula, this.Marca, this.Modelo, this.Color, this.TipoDeVehiculo, this.Motor, this.EspejoRetrovisorInterno, this.EspejoRetrovisorDerecho, this.EspejoRetrovisorIzquierdo, this.Radio, this.Gato, this.Gomas, this.GomaDeRepuesto, this.Alfombras, this.Botiquin, this.TaponDeGasolina, this.TaponDeRadiador, this.Encendedor, this.ManualDeUsuario, this.DuplicadoDeLlaveDeEncendido, this.LlaveDeRueda, this.ClienteId, this.NombreCompleto, this.Apodo, this.Direccion, this.Cedula, this.Nacionalidad, this.Ocupacion, this.LugarDeNacimiento, this.Sexo, this.PagoInicialEnEfectivo, this.PagoInicialEnCheque, this.PrecioAPagar, this.AutorizadoPor));
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
