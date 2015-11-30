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

        public ConexionDb conexion = new ConexionDb();

        public Vehiculos(int vehiculoId, string estadoDelVehiculo, string modelo, string marca, string motor, string color, int año, string noChasis, string tipoDeVehiculo, int kilometraje, int precio, string placa, string matricula, bool espejoRetrovisorInterno, bool espejoRetrovisorDerecho, bool espejoRetrovisorIzquierdo, bool radio, bool gato, bool gomas, bool gomaDeRepuesto, bool alfombras, bool botiquin, bool taponDeGasolina, bool taponDeRadiador, bool encendedor, bool manualDeUsuario, bool duplicadoDeLlaveDeEncendido, bool llaveDeRueda)
        {
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

        }

        public Vehiculos()
        {
            
        }

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder comando = new StringBuilder();
            try
            {

          
                conexion.Ejecutar(String.Format("Insert Into Vehiculos (EstadoDelVehiculo, Año, NoChasis, Kilometraje, Precio, Placa, Matricula, Marca, Modelo, Color, TipoVehiculo, Motor, EspejoRetrovisorInterno, EspejoRetrovisorDerecho,EspejoRetrovisorIzquierdo, Radio, Gato, Gomas, GomaDeRepuesto, Alfombras, Botiquin, TaponDeGasolina, TaponDeRadiador, Encendedor, ManualDeUsuario, DuplicadoDeLlaveDeEncendido, LlaveDeRueda) Values('{0}',{1},'{2}',{3},{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}')", this.EstadoDelVehiculo, this.Año, this.NoChasis, this.Kilometraje, this.Precio, this.Placa, this.Matricula, this.Marca, this.Modelo, this.Color, this.TipoDeVehiculo, this.Motor,this.EspejoRetrovisorInterno,this.EspejoRetrovisorDerecho, this.EspejoRetrovisorIzquierdo, this.Radio, this.Gato, this.Gomas, this.GomaDeRepuesto, this.Alfombras, this.Botiquin, this.TaponDeGasolina, this.TaponDeRadiador, this.Encendedor, this.ManualDeUsuario, this.DuplicadoDeLlaveDeEncendido, this.LlaveDeRueda));
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
                conexion.Ejecutar(String.Format("Update Vehiculos set EstadoDelVehiculo='{0}', Modelo='{1}', Marca='{2}', Motor='{3}', Color='{4}', Año={5}, NoChasis='{6}', TipoVehiculo='{7}', Kilometraje={8}, Precio={9}, Placa='{10}', Matricula='{11}', EspejoRetrovisorInterno='{12}', EspejoRetrovisorDerecho='{13}', EspejoRetrovisorIzquierdo='{14}', Radio='{15}', Gato='{16}', Gomas='{17}', GomaDeRepuesto='{18}', Alfombras='{19}', Botiquin='{20}', TaponDeGasolina='{21}', TaponDeRadiador='{22}', Encendedor='{23}', ManualDeUsuario='{24}', DuplicadoDeLlaveDeEncendido='{25}', LlaveDeRueda='{26}' where VehiculoId={27}", this.EstadoDelVehiculo, this.Modelo, this.Marca, this.Motor, this.Color, this.Año, this.NoChasis, this.TipoDeVehiculo, this.Kilometraje, this.Precio, this.Placa, this.Matricula, this.EspejoRetrovisorInterno, this.EspejoRetrovisorDerecho, this.EspejoRetrovisorIzquierdo, this.Radio, this.Gato, this.Gomas, this.GomaDeRepuesto, this.Alfombras, this.Botiquin, this.TaponDeGasolina, this.TaponDeRadiador, this.Encendedor, this.ManualDeUsuario, this.DuplicadoDeLlaveDeEncendido, this.LlaveDeRueda, this.VehiculoId));
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
            

            datos = conexion.ObtenerDatos("Select * from Vehiculos Where VehiculoId=" + IdBuscado);
            if (datos.Rows.Count > 0)
            {
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
