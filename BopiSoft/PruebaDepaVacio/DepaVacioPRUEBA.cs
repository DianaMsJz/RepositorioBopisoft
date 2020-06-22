using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BopiSoft.Presentacion;
using BopiSoft;
using System.IO;

namespace PruebaDepaVacio
{
    [TestClass]
    public class DepaVacioPRUEBA
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange (Organizar)
            var Verificar = new _30Departamento();
            var ID = "";
            var Nombre = "";
            var esperado = false;

            //Act (Actuar)
            var resultado = Verificar.validarDepaVacio(ID, Nombre);

            //Assert (Afirmar)
            Assert.AreEqual(esperado, resultado);

        }
    }
}
