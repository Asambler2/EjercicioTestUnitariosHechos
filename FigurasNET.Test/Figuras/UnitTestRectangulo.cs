using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Figuras;

namespace FigurasNET.Test.Figuras
{
    [TestClass]
    public class UnitTestRectangulo
    {
        Rectangulo rectangulo = new Rectangulo(4, 8);

        [TestMethod]
        public void Area()
        {
            Assert.AreEqual(32, rectangulo.dameArea());
        }

        [TestMethod]
        public void Perimetro()
        {
            Assert.AreEqual(24, rectangulo.damePerimetro());
        }
    }
}
