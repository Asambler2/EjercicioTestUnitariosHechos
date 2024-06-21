using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Vehiculos.Motores;

namespace FigurasNET.Test.Vehiculos.Motores
{
    [TestClass]
    public class UnitTestMotorEstandar
    {
        private MotorEstandar motorEstandar = new(20, 30);

        [TestMethod]
        public void damePotencia()
        {
            Assert.AreEqual(motorEstandar.damePotencia(), 20);
        }

        [TestMethod]
        public void dameCoste()
        {
            Assert.AreEqual(motorEstandar.dameCoste(), 30);
        }
    }
}
