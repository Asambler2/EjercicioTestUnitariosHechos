using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Figuras;

namespace FigurasNET.Test.Figuras
{
    [TestClass]
    public class UnitTestTriangulo1
    {
        private Triangulo triangulo = new Triangulo(3,5,8);

        [TestMethod]
        public void damePerimetro()
        {
            Assert.AreEqual(16, triangulo.damePerimetro());
        }
        [TestMethod]
        public void dameArea()
        {
            Assert.AreEqual(0, triangulo.dameArea());
        }
    }
}
