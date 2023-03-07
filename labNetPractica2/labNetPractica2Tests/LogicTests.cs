using Microsoft.VisualStudio.TestTools.UnitTesting;
using labNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labNetPractica2.Exceptions;

namespace labNetPractica2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CustomExceptions))]
        public void ThrowCustomExceptionTestArrojaCustomException()
        {
            Logic.ThrowCustomException();
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void ThrowExceptionTestArrojaException()
        {
            Logic.ThrowException();
        }

        [TestMethod()]

        public void DividirDosDecimalesTest()
        {
            decimal dividendo = 10;
            decimal divisor = 5;
            decimal resultado = 2;

            decimal resultadoMetodo = Logic.DividirDosDecimales((decimal)dividendo, (decimal)divisor, null);

            Assert.AreEqual(resultadoMetodo,resultado);
        }

        [TestMethod()]
        public void DividirDosDecimalesNegativosTest()
        {
            decimal dividendo = -10;
            decimal divisor = -5;
            decimal resultado = 2;

            decimal resultadoMetodo = Logic.DividirDosDecimales((decimal)dividendo, (decimal)divisor, null);

            Assert.AreEqual(resultadoMetodo, resultado);
        }

        [TestMethod()]
        public void DividirDosDecimales_ElDividendoEsNegativoTest()
        {
            decimal dividendo = -10;
            decimal divisor = 5;
            decimal resultado = -2;

            decimal resultadoMetodo = Logic.DividirDosDecimales((decimal)dividendo, (decimal)divisor, null);

            Assert.AreEqual(resultadoMetodo, resultado);
        }

        [TestMethod()]
        public void DividirDosDecimales_ElDivisorEsNegativoTest()
        {
            decimal dividendo = 10;
            decimal divisor = -5;
            decimal resultado = -2;

            decimal resultadoMetodo = Logic.DividirDosDecimales((decimal)dividendo, (decimal)divisor, null);

            Assert.AreEqual(resultadoMetodo, resultado);
        }
    }
}