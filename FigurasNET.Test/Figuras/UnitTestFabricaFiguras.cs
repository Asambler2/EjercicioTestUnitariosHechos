using FigurasNET.Figuras;

namespace FigurasNET.Test
{
    [TestClass]
    public class UnitTestFabricaFiguras
    {
        FabricaDeFiguras01 fab  = new ();
        FabricaFiguras02 fabrica = new();
        [TestMethod]
        public void dameCuadrado01()
        {
            var figura = fab.dameFigura(TipoFigura.Cuadrado);
            Assert.IsInstanceOfType(figura, typeof(Cuadrado));
            Assert.AreEqual(4, figura.dameArea());
            Assert.AreEqual(8, figura.damePerimetro());
        }
        [TestMethod]
        public void dameRectangulo01()
        {
            var figura = fab.dameFigura(TipoFigura.Rectangulo);
            Assert.IsInstanceOfType(figura, typeof(Rectangulo));
            Assert.AreEqual(12, figura.dameArea());
            Assert.AreEqual(16, figura.damePerimetro());
        }

        [TestMethod]
        public void dameTriangulo01()
        {
            var figura = fab.dameFigura(TipoFigura.Triangulo);
            Assert.IsInstanceOfType(figura, typeof(Triangulo));
            Assert.AreEqual(0, figura.dameArea());
            Assert.AreEqual(12, figura.damePerimetro());
        }
        [TestMethod]
        public void dameCuadrado02()
        {
            var figura = fabrica.dameFigura(TipoFigura.Cuadrado);
            Assert.IsInstanceOfType(figura, typeof(Cuadrado));
            Assert.AreEqual(64, figura.dameArea());
            Assert.AreEqual(32, figura.damePerimetro());
        }


    }
}