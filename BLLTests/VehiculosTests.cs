﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            v.VehiculoId = 1;
            v.EstadoDelVehiculo = "jh";
            v.AtributosId = 1;
            v.Modelo = 1;
            v.Marca = 1;
            v.Motor = 1;
            v.Color = 1;
            v.Año = 123;
            v.NoChasis = "43";
            v.TipoDeVehiculoId = 1;
            v.Kilometraje = 234;
            v.Precio = 23;
            v.Placa = "24221";
            v.Matricula = "bnde34";
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