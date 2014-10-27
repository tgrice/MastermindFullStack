using System;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MM.Core.Test
{
    [TestClass]
    public class CodeGeneratorTests
    {
        private CodeGenerator _creator;

        private bool ValidateCodeDigits(string code)
        {
            for (var i = 0; i < code.Length; i++)
            {
                var num = code.Substring(i, 1);
                var digit = Convert.ToInt32(num);
                if (digit > 9) return false;
            }
            return true;
        }

        [TestInitialize]
        public void Setup()
        {
            _creator = new CodeGenerator();
        }

        [TestMethod]
        public void TestCreation()
        {
            Assert.IsNotNull(_creator);
        }

        [TestMethod]
        public void TestCodeLength()
        {
            string code = _creator.GenerateCode();
            Assert.AreEqual(4, code.Length);
        }

        [TestMethod]
        public void TestCodeContents()
        {
            string code = _creator.GenerateCode();
            Assert.AreEqual(true, ValidateCodeDigits(code));
        }
    }
}
