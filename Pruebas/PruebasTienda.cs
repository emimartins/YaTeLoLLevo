using System;
using AccesoADatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasTienda
    {
        [TestMethod]
        public void crearTenant()
        {
            int i = 0;
            ADTienda controlador = new ADTienda();
            controlador.crearTenant("tenant2");
            Assert.AreEqual(0, i);
        }
    }
}
