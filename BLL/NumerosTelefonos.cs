﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NumerosTelefonos : ClaseMaestra
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public ConexionDb conexion = new ConexionDb();

        public NumerosTelefonos(int id, string telefono)
        {
            this.Id = id;
            this.Telefono = telefono;
        }

        public NumerosTelefonos()
        {
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable datos = new DataTable();

            datos = conexion.ObtenerDatos("Select * From NumerosTelefono where Id =" + IdBuscado);

            if (datos.Rows.Count > 0)
            {
                this.Id = (int)datos.Rows[0]["Id"];
                this.Telefono = datos.Rows[0]["Telefono"].ToString();
            }
            return datos.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update NumerosTelefono set Telefono='{0}' where Id ={1}", this.Telefono, this.Id));
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
                conexion.Ejecutar(String.Format("Delete From NumerosTelefono where Id={0}", this.Id));
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
                conexion.Ejecutar(String.Format("Insert into NumerosTelefono (Telefono) Values('{0}')", this.Telefono));
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
            return conexion.ObtenerDatos(("Select " + Campos + " from NumerosTelefono where " + Condicion + ordenar));
        }
    }
}
