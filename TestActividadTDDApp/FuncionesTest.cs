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

        [TestMethod]
        public void EsContrasenyaValida_Null_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida(null));
        }

        [TestMethod]
        public void EsContrasenyaValida_Vacia_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida(""));
        }

        [TestMethod]
        public void EsContrasenyaValida_MenosDeOchoCaracteres_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("abc#123"));
        }

        [TestMethod]
        public void EsContrasenyaValida_SinAlmohadilla_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("abcdefgh"));
        }

        [TestMethod]
        public void EsContrasenyaValida_CumpleRequisitos_DevuelveTrue()
        {
            Assert.IsTrue(Funciones.EsContrasenyaValida("abcde#123"));
        }
    }
}
