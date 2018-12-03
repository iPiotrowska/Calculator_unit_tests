using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            Calc calc = new Calc();
            Assert.AreEqual(3, calc.Add(1, 2));
            Assert.AreEqual(-1, calc.Add(1, -2));
        }

        [TestMethod]
        public void TestMethodSubstr()
        {
            Calc calc = new Calc();
            Assert.AreEqual(3, calc.Subtract(5, 2));
        }

        [TestMethod]
        public void TestMethodMulti()
        {
            Calc calc = new Calc();
            Assert.AreEqual(10, calc.Multiply(5, 2));
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            Calc calc = new Calc();
            Exception e = new DivideByZeroException();
            Assert.AreEqual(2, calc.Divide(4, 2));
        }
    }
}
