using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Domain;
using System;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            var Random = new System.Random();
            double Answer = 0.0;

            var Calculator = new Calculator.Domain.Calculator();
            Calculator.Current = Random.Next();
            Answer += Calculator.Current;
            Calculator.ProcessOperation(new CalculationOperation(new Add()));

            Calculator.Current = Random.Next();
            Answer += Calculator.Current;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

        [TestMethod]
        public void TestSubtraction()
        {
            var Random = new System.Random();
            double Answer = 0.0;

            var Calculator = new Calculator.Domain.Calculator();
            Calculator.Current = Random.Next();
            Answer += Calculator.Current;
            Calculator.ProcessOperation(new CalculationOperation(new Subtract()));

            Calculator.Current = Random.Next();
            Answer -= Calculator.Current;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

        [TestMethod]
        public void TestMultiplication()
        {
            var Random = new System.Random();
            double Answer = 0.0;

            var Calculator = new Calculator.Domain.Calculator();
            Calculator.Current = Random.Next();
            Answer += Calculator.Current;
            Calculator.ProcessOperation(new CalculationOperation(new Multiply()));

            Calculator.Current = Random.Next();
            Answer *= Calculator.Current;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

        [TestMethod]
        public void TestDivision()
        {
            var Random = new System.Random();
            double Answer = 0.0;

            var Calculator = new Calculator.Domain.Calculator();
            Calculator.Current = Random.Next();
            Answer += Calculator.Current;
            Calculator.ProcessOperation(new CalculationOperation(new Divide()));

            Calculator.Current = Random.Next();
            Answer /= Calculator.Current;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

    }
}
