using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverser.Tests
{
    [TestClass]
    public class ReverserTests
    {
        Reverser subject = new Reverser();

        [TestMethod]
        public void IfStringIsNullReturnNull()
        {
            string value = null;
            var result = subject.Reverse(value);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void IfEmptyReturnEmpty()
        {
            var value = string.Empty;

            var result = subject.Reverse(value);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void IfSingleLineReturnSingleLine()
        {
            var value ="I'm a single line";
            var result = subject.Reverse(value);

            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void IfMultipleLinesReturnInverseOrder()
        {
            var value = "Line 1\r\nLine 2\r\nLine 3";
            var expectedResult = "Line 3\r\nLine 2\r\nLine 1";
            var result = subject.Reverse(value);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
