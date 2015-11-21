﻿using System;
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
        public int EstadoDelVehiculoId { set; get; }
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

        public Vehiculos(int vehiculoId, int estadoDelVehiculoId, int atributosId, int modeloId, int marcaId, int motorId, int colorId, int año, string noChasis, int tipoDeVehiculoId, int kilometraje, int precio, string placa, string matricula)
        {
            this.VehiculoId = vehiculoId;
            this.EstadoDelVehiculoId = estadoDelVehiculoId;
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
        }

        public Vehiculos() { }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Vehiculos Where VehiculoId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.VehiculoId = (int)dt.Rows[0]["VehiculoId"];
                this.EstadoDelVehiculoId = (int)dt.Rows[0]["EstadoDelVehiculoId"];
                this.AtributosId = (int)dt.Rows[0]["AtributosId"];
                this.ModelosId = (int)dt.Rows[0]["ModelosId"];
                this.MarcasId = (int)dt.Rows[0]["MarcasId"];
                this.MotorId = (int)dt.Rows[0]["MotorId"];
                this.ColorId = (int)dt.Rows[0]["ColorId"];
                this.Año = (int)dt.Rows[0]["Año"];
                this.NoChasis = dt.Rows[0]["NoChasis"].ToString();
                this.TipoDeVehiculoId = (int)dt.Rows[0]["TipoDeVehiculoId"];
                this.Kilometraje = (int)dt.Rows[0]["Kilometraje"];
                this.Precio = (int)dt.Rows[0]["Precio"];
                this.Placa = dt.Rows[0]["Placa"].ToString();
                this.Matricula = dt.Rows[0]["Matricula"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Vehiculos set EstadoDelVehiculoId={0}, AtributosId={1}, ModelosId={2}, MarcasId={3}, MotorId={4}, ColorId={5}, Año={6}, NoChasis='{7}', TipoDeVehiculoId={8}, Kilometraje={9}, Precio={10}, Placa='{11}', Matricula='{12}' where VehiculoId={13}", this.EstadoDelVehiculoId, this.AtributosId, this.ModelosId, this.MarcasId, this.MotorId, this.ColorId, this.Año, this.NoChasis, this.TipoDeVehiculoId, this.Kilometraje, this.Precio, this.Placa, this.Matricula, this.VehiculoId));
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

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Vehiculos (EstadoDelVehiculoId, AtributosId, ModelosId, MarcasId, MotorId, ColorId, Año, NoChasis, TipoDeVehiculoId, Kilometraje, Precio, Placa, Matricula) Values({0},{1},{2},{3},{4},{5},{6},'{7}',{8},{9},{10},'{11}','{12}')", this.EstadoDelVehiculoId, this.AtributosId, this.ModelosId, this.MarcasId, this.MotorId, this.ColorId, this.Año, this.NoChasis, this.TipoDeVehiculoId, this.Kilometraje, this.Precio, this.Placa, this.Matricula));
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
            return conexion.ObtenerDatos(("Select " + Campos + " from Vehiculos where " + Condicion + ordenar));
        }
    }
}
