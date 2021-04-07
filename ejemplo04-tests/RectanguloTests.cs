using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejemplo04;

namespace ejemplo04_tests
{
    [TestClass]
    public class RectanguloTests
    {
        [TestMethod]
        public void Area_WithValidInput_ReturnArea()
        {
            //Arrange
            Rectangulo rectangulo = new Rectangulo(5, 4);
            double areaEsperada = 20;

            //Act
            double areaObtenida = rectangulo.area();

            //Asset
            Assert.AreEqual(areaObtenida, areaEsperada);

        }

        [TestMethod]
        public void Perimetro_WithValidInput_ReturnPerimetro()
        {
            //Arrange
            Rectangulo rectangulo = new Rectangulo(5, 4);
            double perimetroEsperado = 18;

            //Act
            double perimetroObtenido = rectangulo.perimetro();

            //Asset
            Assert.AreEqual(perimetroObtenido, perimetroEsperado);

        }
    }
}
