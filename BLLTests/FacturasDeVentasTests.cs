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
    public class FacturasDeVentasTests
    {
        [TestMethod()]
        public void FacturasDeVentasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FacturasDeVentasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTelefonoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LimpiarTelefonoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            FacturasDeVentas f = new FacturasDeVentas();
            f.FacturaId = 2;
            Assert.IsTrue(f.Buscar(f.FacturaId));
        }

        [TestMethod()]
        public void EditarTest()
        {

            FacturasDeVentas f = new FacturasDeVentas();
            f.FacturaId = 1;
            f.Fecha = "qwe";
            f.PagoInicialEnEfectivo = 346;
            f.PagoInicialEnCheque = 36;
            f.PrecioAPagar = 5444;
            f.ClienteId = 1;
            f.VehiculoId = 1;
            f.AutorizadoPor = "s";

            Assert.IsTrue(f.Editar());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            FacturasDeVentas f = new FacturasDeVentas();
            f.FacturaId = 2;
            Assert.IsTrue(f.Eliminar());
        }

        [TestMethod()]
        public void InsertarTest()
        {
            FacturasDeVentas f = new FacturasDeVentas();

                
            f.Fecha = "qwe";
            f.PagoInicialEnEfectivo = 346;
            f.PagoInicialEnCheque = 36;
            f.PrecioAPagar = 5444;
            f.ClienteId = 1;
            f.VehiculoId = 1;
            f.AutorizadoPor = "s";

            Assert.IsTrue(f.Insertar());
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Assert.Fail();
        }
    }
}