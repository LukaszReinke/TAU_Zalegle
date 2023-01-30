using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplyApp;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Program app = new Program();

        [TestMethod]
        public void TestAddNumbers()
        {
            int result = app.AddNumbers(2, 3);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestSubtractNumbers()
        {
            int result = app.SubtractNumbers(5, 3);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestMultiplyNumbers()
        {
            int result = app.MultiplyNumbers(2, 3);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void TestDivideNumbers()
        {
            int result = app.DivideNumbers(6, 3);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestAddNumbersNegative()
        {
            int result = app.AddNumbers(-2, -3);
            Assert.AreEqual(result, -5);
        }

        [TestMethod]
        public void TestSubtractNumbersNegative()
        {
            int result = app.SubtractNumbers(-5, -3);
            Assert.AreEqual(result, -2);
        }

        [TestMethod]
        public void TestMultiplyNumbersNegative()
        {
            int result = app.MultiplyNumbers(-2, -3);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void TestDivideNumbersNegative()
        {
            int result = app.DivideNumbers(-6, -3);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestAddNumbersZero()
        {
            int result = app.AddNumbers(0, 0);
            Assert.AreEqual(result, 0);
        }
    }
}