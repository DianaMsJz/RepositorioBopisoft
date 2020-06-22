using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using BopiSoft.Presentacion;
using BopiSoft;
using System.IO;

namespace Prueba2
{
    [TestClass]
    public class PruebaCarrera
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange (Organizar)
            var Verificar = new _24Carrera();
            var ID = "";
            var Nombre = "";
            var esperado = false;

            //Act (Actuar)
            var resultado = Verificar.validarCarreraVacia(ID, Nombre);

            //Assert (Afirmar)
            Assert.AreEqual(esperado, resultado);
            
        }
    }
}
