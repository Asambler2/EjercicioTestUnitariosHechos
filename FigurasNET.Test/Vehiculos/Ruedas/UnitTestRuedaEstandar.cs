using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Test.Vehiculos.Ruedas
{
    [TestClass]
    public class UnitTestRuedaEstandar
    {
        private RuedaNormal ruedaNormal = new RuedaNormal("caucho", 100);

        [TestMethod]
        public void dameTipo()
        {
            Assert.AreEqual(ruedaNormal.dameGoma(), "caucho");
        }

        [TestMethod]
        public void dameCoste()
        {
            Assert.AreEqual(ruedaNormal.dameCoste(), 100);
        }
    }
}
