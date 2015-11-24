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
    public class AtributosTests1
    {
        [TestMethod()]
        public void AtributosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Atributos a = new Atributos();
            a.EspejoRetrovisorInterno = true;
            a.EspejoRetrovisorDerecho = true;
            a.EspejoRetrovisorIzquierdo = true;
            a.Radio = true;
            a.Gato = true;
            a.Gomas = true;
            a.GomaDeRepuesto = true;
            a.Alfombras = true;
            a.Botiquin = true;
            a.TaponDeGasolina = true;
            a.TaponDeRadiador = true;
            a.Encendedor = true;
            a.ManualDeUsuario = true;
            a.DuplicadoDeLlaveDeEncendido = true;
            a.LlaveDeRueda = true;
            Assert.IsTrue(a.Insertar());
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