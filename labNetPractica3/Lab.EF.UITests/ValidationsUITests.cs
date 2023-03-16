using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.EF.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI.Tests
{
    [TestClass()]
    public class ValidationsUITests
    {
        [TestMethod()]
        [DataRow("'¿'¿''¿")]
        [DataRow("texto")]
        [DataRow("")]
        public void ValidateYesNoInputTestInvalidInput(string input)
        {
            Assert.IsFalse(ValidationsUI.ValidateYesNoInput(input));
        }

        [TestMethod()]
        [DataRow("blablablablabla",7)]
        public void ValidateStringLengthTestInputIsTooLong(string input, int maxLength)
        {
            Assert.IsFalse(ValidationsUI.ValidateStringLength(input, maxLength));
        }

        [TestMethod()]
        [DataRow("blablablablabla", 20)]
        public void ValidateStringLengthTestInputIsOk(string input, int maxLength)
        {
            Assert.IsTrue(ValidationsUI.ValidateStringLength(input, maxLength));
        }
    }
}