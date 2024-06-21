using FigurasNET.Vehiculos.Ruedas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Test.Vehiculos.Ruedas
{
    [TestClass]
    public class UnitTestRuedaCompeticion
    {
        private RuedaCompeticion ruedaCompeticion = new RuedaCompeticion( 1);

        [TestMethod]
        public void dameTipo()
        {
            Assert.AreEqual(ruedaCompeticion.dameGoma(), "competicion");
        }

        [TestMethod]
        public void dameCoste()
        {
            Assert.AreEqual(ruedaCompeticion.dameCoste(), 22);
        }
    }
}
