using Microsoft.VisualStudio.TestTools.UnitTesting;
using labNetPractica2.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.ExtensionMethods.Tests
{
    [TestClass()]
    public class IntegerExtensionsTests
    {
        [TestMethod()]
        [DataRow(5)]
        [DataRow(-3)]
        [DataRow(0)]
        public void DividirPorCeroCualquierNumeroRetornaCeroTest(int dividendo)
        {
            decimal retornoEsperado = 0;
            decimal retorno = IntegerExtensions.DividirPorCero(dividendo, null);
            Assert.AreEqual(retorno, retornoEsperado);
        }
    }
}