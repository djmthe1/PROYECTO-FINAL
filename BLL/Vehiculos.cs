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
        public ConexionDb conexion = new ConexionDb();
       

        List<Atributos> Atributos { get; set; }


        public Vehiculos(int vehiculoId, string estadoDelVehiculo, int atributosId, string modelo, string marca, string motor, string color, int año, string noChasis, string tipoDeVehiculo, int kilometraje, int precio, string placa, string matricula)
        {
            this.VehiculoId = vehiculoId;
            this.EstadoDelVehiculo = estadoDelVehiculo;
            this.AtributosId = atributosId;
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
            
        }

        public Vehiculos()
        {
            
        }

        public void InsertarAtributos(int AtributosId, bool EspejoRetrovisorInterno, bool EspejoRetrovisorDerecho, bool EspejoRetrovisorIzquierdo, bool Radio, bool Gato, bool Gomas, bool GomaDeRepuesto, bool Alfombras, bool Botiquin, bool TaponDeGasolina, bool TaponDeRadiador, bool Encendedor, bool ManualDeUsuario, bool DuplicadoDeLlaveDeEncendido, bool LlaveDeRueda)
        {
            this.Atributos.Add(new Atributos(AtributosId, EspejoRetrovisorInterno, EspejoRetrovisorDerecho, EspejoRetrovisorIzquierdo, Radio, Gato, Gomas, GomaDeRepuesto, Alfombras, Botiquin, TaponDeGasolina, TaponDeRadiador, Encendedor, ManualDeUsuario, DuplicadoDeLlaveDeEncendido, LlaveDeRueda));
        }

       

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder comando = new StringBuilder();
            try
            {
            

                conexion.Ejecutar(String.Format("Insert Into Vehiculos (EstadoDelVehiculo, Año, NoChasis, Kilometraje, Precio, Placa, Matricula,Marca,Modelo,Color,EstadoDelVehiculo,TipoVehiculo,Motor) Values('{0}',{1},'{2}',{3},{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", this.EstadoDelVehiculo, this.Año, this.NoChasis, this.Kilometraje, this.Precio, this.Placa, this.Matricula,this.Marca,this.Modelo,this.Color,this.EstadoDelVehiculo,this.TipoDeVehiculo,this.Motor));
                retorno = true;

               

            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Vehiculos set EstadoDelVehiculo='{0}', AtributosId={1}, Modelo='{2}', Marca='{3}', Motor='{4}', Color='{5}', Año={6}, NoChasis='{7}', TipoDeVehiculoId={8}, Kilometraje={9}, Precio={10}, Placa='{11}', Matricula='{12}' where VehiculoId={13}", this.EstadoDelVehiculo, this.AtributosId, this.Modelo, this.Marca, this.Motor, this.Color, this.Año, this.NoChasis, this.TipoDeVehiculo, this.Kilometraje, this.Precio, this.Placa, this.Matricula, this.VehiculoId));
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
                this.Modelo = datos.Rows[0]["Modelo"].ToString();
                this.Marca = datos.Rows[0]["Marca"].ToString();
                this.Motor = datos.Rows[0]["Motor"].ToString();
                this.Color = datos.Rows[0]["Color"].ToString();
                this.Año = (int)datos.Rows[0]["Año"];
                this.NoChasis = datos.Rows[0]["NoChasis"].ToString();
                this.TipoDeVehiculo = datos.Rows[0]["TipoDeVehiculo"].ToString();
                this.Kilometraje = (int)datos.Rows[0]["Kilometraje"];
                this.Precio = (int)datos.Rows[0]["Precio"];
                this.Placa = datos.Rows[0]["Placa"].ToString();
                this.Matricula = datos.Rows[0]["Matricula"].ToString();
                //-------------------------------------------------------------------------------------------
                vehiculodatos = conexion.ObtenerDatos("Select v.MarcaId, m.Descripcion From Vehiculos v Inner Join Marcas m On v.MarcaId = m.MarcaId where v.VehiculoId =" + this.VehiculoId);

              

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
