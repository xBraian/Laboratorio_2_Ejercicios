using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        [ExpectedException (typeof(DivideByZeroException))]
        public void Division_DivisorEsCero_LanzarDivideByZeroException()
        {
            double dividendo = 10.0;
            double divisor = 0.0;
            Calculadora.Division(dividendo, divisor);
        }

        [TestMethod]
        public void Division_RealiceCalculo_ResultadoEsperado()
        {
            double dividendo = 10.0;
            double divisor = 2.0;
            double resultadoEsperado = 5.0;
            double aux = Calculadora.Division(dividendo, divisor);
            Assert.AreEqual(resultadoEsperado, aux);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RaizCuadrada_RadicandoEsNegativo_LanzarArgumentException()
        {
            double radicando = -10;
            Calculadora.RaizCuadrada(radicando);
        }

        [TestMethod]
        public void RaizCuadrada_RealiceCalculo_ResultadoEsperado()
        {
            double radicando = 81.0;
            double resultadoEsperado = 9.0;
            double aux = Calculadora.RaizCuadrada(radicando);
            Assert.AreEqual(resultadoEsperado, aux);
        }
    }
}