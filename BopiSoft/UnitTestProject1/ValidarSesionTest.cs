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


namespace UnitTestProject1
{
    [TestClass]
    public class ValidarSesionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            //Arrange (Organizar)
            var Verificar = new Form1();
            var ID = "";
            var Password = "";
            var esperado = false;

            //Act (Actuar)
            var resultado = Verificar.validarSesion(ID, Password);

            //Assert (Afirmar)
            Assert.AreEqual(esperado, resultado);

        }
    }
}
