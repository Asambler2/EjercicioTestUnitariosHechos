using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Vehiculos;
using FigurasNET.Vehiculos.Factoria;
using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Test.Vehiculos.Factoria
{
    [TestClass]
    public class UnitTestFactoriaVehiculos
    {
        private FabricaDeEnero fabrica = new();

        [TestMethod]
        public void dameVehiculoNuclear()
        {
            var vehiculo = fabrica.dameVehiculo(TipoVehiculo.NuclearDeCompeticion);
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));

            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorNuclear));
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.dameCoste(), 100);
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.damePotencia(), 7800);

            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaCompeticion));
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameGoma(), "competicion");
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameCoste(), 22);
        }

        [TestMethod]
        public void dameVehiculoNormal()
        {
            var vehiculo = fabrica.dameVehiculo(TipoVehiculo.Normal);
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));

            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorEstandar));
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.dameCoste(), 100);
            Assert.AreEqual(vehiculo.MotorDelVehiculo1.damePotencia(), 78);

            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaNormal));
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameGoma(), "normal");
            Assert.AreEqual(vehiculo.RuedasDelVehiculo1.dameCoste(), 89);
        }
    }
}
