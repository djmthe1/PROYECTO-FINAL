using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class VehiculosTests
    {
        [TestMethod()]
        public void VehiculosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void VehiculosTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Vehiculos v = new Vehiculos();
           
            v.EstadoDelVehiculo = "jh";
            v.Modelo = "c3";
            v.Marca = "as";
            v.Motor = "as";
            v.Color = "d";
            v.Año = 123;
            v.NoChasis = "43";
            v.TipoDeVehiculo = "sd";
            v.Kilometraje = 234;
            v.Precio = 23;
            v.Placa = "24221";
            v.Matricula = "bnde34";
            v.EspejoRetrovisorInterno = true;
            v.EspejoRetrovisorDerecho = false;
          v.EspejoRetrovisorIzquierdo = true;
            v.Radio = true;
            v.Gato = true;
            v.Gomas = true;
            v.GomaDeRepuesto = true;
            v.Alfombras = true;
            v.Botiquin = true;
            v.TaponDeGasolina = true;
            v.TaponDeRadiador = true;
            v.Encendedor = true;
            v.ManualDeUsuario = true;
            v.DuplicadoDeLlaveDeEncendido = true;
            v.LlaveDeRueda = false;
        Assert.IsTrue(v.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Assert.Fail();
        }
    }
}