using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Atributos : ClaseMaestra
    {
        public int AtributosId { set; get; }
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

        public Atributos() { }

        public ConexionDb conexion = new ConexionDb();

        public override bool Insertar()
        {
            bool retotno = false;
            try
            {

                conexion.Ejecutar(String.Format("Insert into Atributos (EspejoRetrovisorInterno, EspejoRetrovisorInterno, EspejoRetrovisorIzquierdo, Radio, Gato, Gomas, GomaDeRepuesto, Alfombras, Botiquin, TaponDeGasolina, TaponDeRadiador, Encendedor, ManualDeUsuario, DuplicadoDeLlaveDeEncendido, LlaveDeRueda) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", this.EspejoRetrovisorInterno, this.EspejoRetrovisorInterno, this.EspejoRetrovisorIzquierdo, this.Radio, this.Gato, this.Gomas, this.GomaDeRepuesto, this.Alfombras, this.Botiquin, this.TaponDeGasolina, this.TaponDeRadiador, this.Encendedor, this.ManualDeUsuario, this.DuplicadoDeLlaveDeEncendido, this.LlaveDeRueda));
                retotno = true;
            }
            catch (Exception ex) { throw ex; }
            return retotno;
        }

        public override bool Editar()
        {
            bool retotno = false;
            try
            {

                conexion.Ejecutar(String.Format("Update Atributos set EspejoRetrovisorInterno='{0}', EspejoRetrovisorInterno='{1}', EspejoRetrovisorIzquierdo='{2}', Radio='{3}', Gato='{4}', Gomas='{5}', GomaDeRepuesto='{6}', Alfombras='{7}', Botiquin='{8}', TaponDeGasolina='{9}', TaponDeRadiador='{10}', Encendedor='{11}', ManualDeUsuario='{12}', DuplicadoDeLlaveDeEncendido='{13}', LlaveDeRueda='{14}' where AtributoId ={15}", this.EspejoRetrovisorInterno, this.EspejoRetrovisorInterno, this.EspejoRetrovisorIzquierdo, this.Radio, this.Gato, this.Gomas, this.GomaDeRepuesto, this.Alfombras, this.Botiquin, this.TaponDeGasolina, this.TaponDeRadiador, this.Encendedor, this.ManualDeUsuario, this.DuplicadoDeLlaveDeEncendido, this.LlaveDeRueda, this.AtributosId));
                retotno = true;
            }
            catch (Exception ex) { throw ex; }
            return retotno;
        }

        public override bool Eliminar()
        {
            bool retotno = false;
            try
            {

                conexion.Ejecutar(String.Format("Delete from Atributos where AtributoId ={0}", this.AtributosId));
                retotno = true;
            }
            catch (Exception ex) { throw ex; }
            return retotno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Atributos Where AtributoId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.AtributosId = (int)dt.Rows[0]["AtributoId"];
                this.EspejoRetrovisorInterno = (bool)dt.Rows[0]["EspejoRetrovisorInterno"];
                this.EspejoRetrovisorDerecho = (bool)dt.Rows[0]["EspejoRetrovisorDerecho"];
                this.EspejoRetrovisorIzquierdo = (bool)dt.Rows[0]["EspejoRetrovisorIzquierdo"];
                this.Radio = (bool)dt.Rows[0]["Radio"];
                this.Gato = (bool)dt.Rows[0]["Gato"];
                this.Gomas = (bool)dt.Rows[0]["Gomas"];
                this.GomaDeRepuesto = (bool)dt.Rows[0]["GomaDeRepuesto"];
                this.Alfombras = (bool)dt.Rows[0]["Alfombras"];
                this.Botiquin = (bool)dt.Rows[0]["Botiquin"];
                this.TaponDeGasolina = (bool)dt.Rows[0]["TaponDeGasolina"];
                this.TaponDeRadiador = (bool)dt.Rows[0]["TaponDeRadiador"];
                this.Encendedor = (bool)dt.Rows[0]["Encendedor"];
                this.ManualDeUsuario = (bool)dt.Rows[0]["ManualDeUsuario"];
                this.DuplicadoDeLlaveDeEncendido = (bool)dt.Rows[0]["DuplicadoDeLlaveDeEncendido"];
                this.LlaveDeRueda = (bool)dt.Rows[0]["LlaveDeRueda"];
            }
            return dt.Rows.Count > 0;
        }


        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = "orden by" + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Atributos where " + Condicion+" "+Orden));
        }
    }
}

