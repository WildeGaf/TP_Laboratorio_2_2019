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
        public void TestMethodNacionalidadInvalida()
        {
            try
            {
                Alumno a8 = new Alumno(8, "Rodrigo", "Smith", "22226456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion, Alumno.EEstadoCuenta.AlDia);
            }
            catch (NacionalidadInvalidaException)
            {
            }
            
        }
    }
}
