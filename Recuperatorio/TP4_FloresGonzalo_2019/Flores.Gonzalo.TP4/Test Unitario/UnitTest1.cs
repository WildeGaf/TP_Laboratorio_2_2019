using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PaquetesInstanciados()
        {
            Correo c = new Correo();
            Assert.IsNotNull(c.Paquetes);
        }
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void PaquetesRepetidos()
        {
            Correo c = new Correo();
            c += new Paquete("Federico", "12453652");
            c += new Paquete("Davila", "12453652");
        }
    }
}
