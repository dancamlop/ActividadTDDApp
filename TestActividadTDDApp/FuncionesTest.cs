using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            Assert.AreEqual(-1L, Funciones.CalcularFactorial(-3));
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            Assert.AreEqual(1L, Funciones.CalcularFactorial(0));
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_DevuelveCientoVeinte()
        {
            Assert.AreEqual(120L, Funciones.CalcularFactorial(5));
        }

        [TestMethod]
        public void CalcularFactorial_Seis_DevuelveSetecientosVeinte()
        {
            Assert.AreEqual(720L, Funciones.CalcularFactorial(6));
        }
    }
}
