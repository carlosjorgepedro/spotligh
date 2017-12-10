using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class IsFizzBuzzTest
    {
        FizzBuzzer subject = new FizzBuzzer();
        [TestMethod]
        public void IsFizzTest()
        {
            var values = new[] { 3, 3 * 2, 3 * 3, 3 * 6, 3 * 8, 3 * 99 };

            foreach(var value in values)
            {
                Assert.AreEqual("Fizz", subject.Check(value));
            }
        }

        [TestMethod]
        public void IsBuzzTest()
        {
            var values = new[] { 5, 5 * 2, 5 * 4, 5 * 7, 5 * 8, 5 * 100 };

            foreach (var value in values)
            {
                Assert.AreEqual("Buzz", subject.Check(value));
            }
        }

        [TestMethod]
        public void IsFizzBuzz()
        {
            var values = new[] { 15, 15 * 2, 15 * 4, 15 * 7, 15 * 8, 15 * 100 };

            foreach (var value in values)
            {
                Assert.AreEqual("FizzBuzz", subject.Check(value));
            }
        }

        [TestMethod]
        public void NotFizzNorBuzz()
        {
            var values = new[] {1,2,7,8,23,133 };
            foreach (var value in values)
            {
                Assert.AreEqual(value.ToString(), subject.Check(value));
            }
        }
    }
}
