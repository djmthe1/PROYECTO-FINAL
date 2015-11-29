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
    public class NumerosTelefonosTests
    {
        [TestMethod()]
        public void NumerosTelefonosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NumerosTelefonosTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            NumerosTelefonos n = new NumerosTelefonos();
            n.Id = 2;
            Assert.IsTrue(n.Buscar(n.Id));
        }

        [TestMethod()]
        public void EditarTest()
        {
            NumerosTelefonos n = new NumerosTelefonos();
            n.Id = 1;
            n.Telefono = "123";
            Assert.IsTrue(n.Editar());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            NumerosTelefonos n = new NumerosTelefonos();
            n.Id = 1;
            Assert.IsTrue(n.Eliminar());
        }

        [TestMethod()]
        public void InsertarTest()
        {
            NumerosTelefonos n = new NumerosTelefonos();
            n.Telefono = "123";
            Assert.IsTrue(n.Insertar());
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Assert.Fail();
        }
    }
}