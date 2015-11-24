using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Vehiculos : ClaseMaestra
    {

        public int VehiculoId { set; get; }
        public string EstadoDelVehiculo { set; get; }
        public int AtributosId { set; get; }
        public int ModelosId { set; get; }
        public int MarcasId { set; get; }
        public int MotorId { set; get; }
        public int ColorId { set; get; }
        public int Año { set; get; }
        public string NoChasis { set; get; }
        public int TipoDeVehiculoId { set; get; }
        public int Kilometraje { set; get; }
        public int Precio { set; get; }
        public string Placa { set; get; }
        public string Matricula { set; get; }
        public ConexionDb conexion = new ConexionDb();
        public StringBuilder comando = new StringBuilder();
        List <Atributos> Atributos { get; set; }
        List <Marcas> Marcas { get; set; }
        List <Modelos> Modelos { get; set; }
        List <TipoMotores> TipoMotores { get; set; }
        List <Colores> Colores { get; set; }
        List <TipoDeVehiculos> TipoDeVehiculos { get; set; }
        public Atributos AtributosV = new Atributos();
        public Marcas MarcasV = new Marcas();
        public Modelos ModelosV = new Modelos();
        public TipoMotores TipoMotoresV = new TipoMotores();
        public Colores ColoresV = new Colores();
        public TipoDeVehiculos TipoDeVehiculosV = new TipoDeVehiculos();

        public Vehiculos(int vehiculoId, string estadoDelVehiculo, int atributosId, int modeloId, int marcaId, int motorId, int colorId, int año, string noChasis, int tipoDeVehiculoId, int kilometraje, int precio, string placa, string matricula)
        {
            this.VehiculoId = vehiculoId;
            this.EstadoDelVehiculo = estadoDelVehiculo;
            this.AtributosId = atributosId;
            this.ModelosId = modeloId;
            this.MarcasId = marcaId;
            this.MotorId = motorId;
            this.ColorId = colorId;
            this.Año = año;
            this.NoChasis = noChasis;
            this.TipoDeVehiculoId = tipoDeVehiculoId;
            this.Kilometraje = kilometraje;
            this.Precio = precio;
            this.Placa = placa;
            this.Matricula = matricula;
            this.Atributos = new List<Atributos>();
            this.Modelos = new List<Modelos>();
            this.Marcas = new List<Marcas>();
            this.TipoMotores = new List<TipoMotores>();
            this.Colores = new List<Colores>();
            this.TipoDeVehiculos = new List<TipoDeVehiculos>();
        }

        public Vehiculos()
        {
            Atributos = new List<Atributos>();
            Modelos = new List<Modelos>();
            Marcas = new List<Marcas>();
            TipoMotores = new List<TipoMotores>();
            Colores = new List<Colores>();
            TipoDeVehiculos = new List<TipoDeVehiculos>();
        }

        public void InsertarAtributos(int AtributosId, bool EspejoRetrovisorInterno, bool EspejoRetrovisorDerecho, bool EspejoRetrovisorIzquierdo, bool Radio, bool Gato, bool Gomas, bool GomaDeRepuesto, bool Alfombras, bool Botiquin, bool TaponDeGasolina, bool TaponDeRadiador, bool Encendedor, bool ManualDeUsuario, bool DuplicadoDeLlaveDeEncendido, bool LlaveDeRueda)
        {
            this.Atributos.Add(new Atributos(AtributosId, EspejoRetrovisorInterno, EspejoRetrovisorDerecho, EspejoRetrovisorIzquierdo, Radio, Gato, Gomas, GomaDeRepuesto, Alfombras, Botiquin, TaponDeGasolina, TaponDeRadiador, Encendedor, ManualDeUsuario, DuplicadoDeLlaveDeEncendido, LlaveDeRueda));
        }

        public void InsertarModelos(int ModeloId, string Descripcion)
        {
            this.Modelos.Add(new Modelos(ModeloId, Descripcion));
        }

        public void InsertarMarcas(int MarcaId, string Descripcion)
        {
            this.Marcas.Add(new Marcas(MarcaId, Descripcion));
        }

        public void InsertarTipoMotores(int MotorId, string Descripcion)
        {
            this.TipoMotores.Add(new TipoMotores( MotorId, Descripcion));
        }

        public void InsertarColores(int ColorId, string Descripcion)
        {
            this.Colores.Add(new Colores(ColorId, Descripcion));
        }

        public void InsertarTipoDeVehiculos(int TipoDeVehiculosId, string Descripcion)
        {
            this.TipoDeVehiculos.Add(new TipoDeVehiculos(TipoDeVehiculosId, Descripcion));
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Vehiculos (EstadoDelVehiculo, Año, NoChasis, Kilometraje, Precio, Placa, Matricula) Values('{0}',{1},'{2}',{3},{4},'{5}','{6}')", this.EstadoDelVehiculo, this.Año, this.NoChasis, this.Kilometraje, this.Precio, this.Placa, this.Matricula));
                retorno = true;




                foreach (var marcas in this.Marcas)
                {
                    comando.AppendLine(String.Format("Update Vehiculos set MarcaId={0}, VehiculoId={1}; ", marcas.MarcaId,this.VehiculoId));
                }
                retorno = conexion.Ejecutar(comando.ToString());


                
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Vehiculos set EstadoDelVehiculo='{0}', AtributosId={1}, ModelosId={2}, MarcasId={3}, MotorId={4}, ColorId={5}, Año={6}, NoChasis='{7}', TipoDeVehiculoId={8}, Kilometraje={9}, Precio={10}, Placa='{11}', Matricula='{12}' where VehiculoId={13}", this.EstadoDelVehiculo, this.AtributosId, this.ModelosId, this.MarcasId, this.MotorId, this.ColorId, this.Año, this.NoChasis, this.TipoDeVehiculoId, this.Kilometraje, this.Precio, this.Placa, this.Matricula, this.VehiculoId));
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
                conexion.Ejecutar(String.Format("Delete From Vehiculos where VehiculoId={0}", this.VehiculoId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable datos = new DataTable();
            DataTable vehiculodatos = new DataTable();

            datos = conexion.ObtenerDatos("Select * from Vehiculos Where VehiculoId=" + IdBuscado);
            if (datos.Rows.Count > 0)
            {
                this.VehiculoId = (int)datos.Rows[0]["VehiculoId"];
                this.EstadoDelVehiculo = datos.Rows[0]["EstadoDelVehiculo"].ToString();
                this.AtributosId = (int)datos.Rows[0]["AtributosId"];
                this.ModelosId = (int)datos.Rows[0]["ModelosId"];
                this.MarcasId = (int)datos.Rows[0]["MarcasId"];
                this.MotorId = (int)datos.Rows[0]["MotorId"];
                this.ColorId = (int)datos.Rows[0]["ColorId"];
                this.Año = (int)datos.Rows[0]["Año"];
                this.NoChasis = datos.Rows[0]["NoChasis"].ToString();
                this.TipoDeVehiculoId = (int)datos.Rows[0]["TipoDeVehiculoId"];
                this.Kilometraje = (int)datos.Rows[0]["Kilometraje"];
                this.Precio = (int)datos.Rows[0]["Precio"];
                this.Placa = datos.Rows[0]["Placa"].ToString();
                this.Matricula = datos.Rows[0]["Matricula"].ToString();

                vehiculodatos = conexion.ObtenerDatos("Select v.MarcaId, m.Descripcion From Vehiculos v Inner Join Marcas m On v.MarcaId = m.MarcaId where v.VehiculoId =" + this.VehiculoId);

                
                this.InsertarMarcas((int)vehiculodatos.Rows[0]["MarcaId"], vehiculodatos.Rows[0]["Descripcion"].ToString());
                

            }
            return datos.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Vehiculos where " + Condicion + Orden));
        }
    }
}
