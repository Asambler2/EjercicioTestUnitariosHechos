using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Vehiculos.Motores;

namespace FigurasNET.Test.Vehiculos.Motores
{
    [TestClass]
    public class UnitTestMotorNuclear
    {
        private MotorNuclear motorNuclear = new MotorNuclear(12, 20);

        [TestMethod]
        public void damePotencia()
        {
            Assert.AreEqual(motorNuclear.damePotencia(), 1200);
        }

        [TestMethod]
        public void dameCoste()
        {
            Assert.AreEqual(motorNuclear.dameCoste(), 20);
        }
    }
}
