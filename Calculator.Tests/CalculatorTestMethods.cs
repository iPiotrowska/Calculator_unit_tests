using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTestMethods
    {
        public Methods Calc = new Methods();

        [TestClass]
        public class AddTest : CalculatorTestMethods
        {
            [TestMethod]
            public void PositiveNumbers()
            {
                double a = 5;
                double b = 5;

                double ExpectedResult = 10;

                var result = Calc.Add(a, b);

                Assert.AreEqual(ExpectedResult, result);

            }

            [TestMethod]
            public void NegativeNumbers()
            {
                double a = -5;
                double b = -5;

                double ExpectedResult = -10;

                var result = Calc.Add(a, b);

                Assert.AreEqual(ExpectedResult, result);

            }

            [TestMethod]
            public void OnePositiveOneNegative()
            {
                double a = -5;
                double b = 5;

                double ExpectedResult = 0;

                var result = Calc.Add(a, b);

                Assert.AreEqual(ExpectedResult, result);

            }


            [TestClass]
            public class SubstractTest : CalculatorTestMethods
            {
                [TestMethod]
                public void PositiveNumbers()
                {
                    double a = 5;
                    double b = 5;

                    double ExpectedResult = 0;

                    var result = Calc.Substract(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }

                [TestMethod]
                public void OnePositiveOneNegative()
                {
                    double a = 5;
                    double b = -5;

                    double ExpectedResult = 10;

                    var result = Calc.Substract(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }

                [TestMethod]
                public void TwoNegative()
                {
                    double a = -5;
                    double b = -5;

                    double ExpectedResult = 0;

                    var result = Calc.Substract(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }


            }

            [TestClass]
            public class MultiplyTest : CalculatorTestMethods
            {
                [TestMethod]
                public void PositiveNumbers()
                {
                    double a = 5;
                    double b = 5;

                    double ExpectedResult = 25;

                    var result = Calc.Multiply(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }
                [TestMethod]
                public void OnePositiveOneNegative()
                {
                    double a = 5;
                    double b = -5;

                    double ExpectedResult = -25;

                    var result = Calc.Multiply(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }

                [TestMethod]
                public void TwoNegative()
                {
                    double a = -5;
                    double b = -5;

                    double ExpectedResult = 25;

                    var result = Calc.Multiply(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }

            }

            [TestClass]
            public class DivideTest : CalculatorTestMethods
            {
                [TestMethod]
                public void PositiveNumbers()
                {
                    double a = 5;
                    double b = 5;

                    var ExpectedResult = 1.ToString();

                    var result = Calc.Divide(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }

                [TestMethod]
                public void bIsZero()
                {
                    double a = 5;
                    double b = 0;

                    var ExpectedResult = "Nie można dzielić przez zero";

                    var result = Calc.Divide(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }
                [TestMethod]
                public void OnePositiveOneNegative()
                {
                    double a = 5;
                    double b = -5;

                    var ExpectedResult = (-1).ToString();

                    var result = Calc.Divide(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }
                [TestMethod]
                public void ZeroByAny()
                {
                    double a = 0;
                    double b = 10;

                    var ExpectedResult = 0.ToString();

                    var result = Calc.Divide(a, b);

                    Assert.AreEqual(ExpectedResult, result);

                }
            }


        }
    }
}