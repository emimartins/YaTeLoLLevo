using System;
using AccesoADatos;
using Compartido.Datatypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasTienda
    {
        [TestMethod]
        public void crearTienda()
        {
            int i = 0;
            ADTienda controlador = new ADTienda();
            DataTienda t = new DataTienda();
            t.Nombre = "Burguer King";
            t.Logo = null;
            t.TipoTienda = TipoTienda.Restaurante;
            t.URL = "dada";
            t.ColorPrincipal = null;
            t.ColorSecundario = null;
            t.Direccion = "Direc";
            controlador.AltaTienda(t);
            Assert.AreEqual(0, i);
        }
    }
}
