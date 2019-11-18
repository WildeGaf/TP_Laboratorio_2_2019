using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesAbstractas;
using Clases_Instanciables;

namespace TestUnitario
{
    [TestClass]
    public class TestNacionalidadInvalida
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestMethodNacionalidadInvalida()
        {
            Alumno a8 = new Alumno(8, "Rodrigo", "Smith", "22236456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion, Alumno.EEstadoCuenta.AlDia);
        }
    }
}
