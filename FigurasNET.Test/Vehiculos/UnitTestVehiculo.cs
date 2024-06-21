using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Vehiculos;
using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Test.Vehiculos
{
    [TestClass]
    public class UnitTestVehiculo
    {
        Vehiculo vehiculo = new (new MotorEstandar(4, 6), new RuedaCompeticion(5));
        [TestMethod]
        public void devolverRueda()
        {
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(IRueda));
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameGoma(), "competicion");
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameCoste(), 110);
        }
        [TestMethod]
        public void devolverMotor()
        {
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(IMotor));
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.dameCoste(), 6);
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.damePotencia(), 4); ;
        }
        [TestMethod]
        public void establecerRueda()
        {
            vehiculo.RuedasDelVehiculo1 = new RuedaNormal("caucho", 15);
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(IRueda));
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameGoma(), "caucho");
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameCoste(), 15);
        }
        [TestMethod]
        public void establecerMotor()
        {
            vehiculo.MotorDelVehiculo1 = new MotorNuclear(10,20);
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(IMotor));
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.dameCoste(), 20);
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.damePotencia(), 1000); ;
        }
    }
}
