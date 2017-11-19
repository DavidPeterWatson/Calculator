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
            double Number1 = Random.Next();
            double Number2 = Random.Next();
            double Answer = Number1 + Number2;

            var Calculator = new Calculator.Domain.Calculator();

            Calculator.Current = Number1;
            Calculator.ProcessOperation(new CalculationOperation(new Add()));

            Calculator.Current = Number2;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

        [TestMethod]
        public void TestSubtraction()
        {
            var Random = new System.Random();
            double Number1 = Random.Next();
            double Number2 = Random.Next();
            double Answer = Number1 - Number2;

            var Calculator = new Calculator.Domain.Calculator();
            Calculator.Current = Number1;
            Calculator.ProcessOperation(new CalculationOperation(new Subtract()));

            Calculator.Current = Number2;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

        [TestMethod]
        public void TestMultiplication()
        {
            var Random = new System.Random();
            double Number1 = Random.Next();
            double Number2 = Random.Next();
            double Answer = Number1 * Number2;

            var Calculator = new Calculator.Domain.Calculator();
            
            Calculator.Current = Number1;
            Calculator.ProcessOperation(new CalculationOperation(new Multiply()));

            Calculator.Current = Number2;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

        [TestMethod]
        public void TestDivision()
        {
            var Random = new System.Random();
            double Number1 = Random.Next();
            double Number2 = Random.Next();
            double Answer = Number1 / Number2;

            var Calculator = new Calculator.Domain.Calculator();
            Calculator.Current = Number1;
            Calculator.ProcessOperation(new CalculationOperation(new Divide()));

            Calculator.Current = Number2;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }

        [TestMethod]
        public void TestBODMAS()
        {
            var Random = new System.Random();
            double Number1 = Random.Next();
            double Number2 = Random.Next();
            double Number3 = Random.Next();
            double Number4 = Random.Next();

            double Answer = Number1 + Number2 * Number3 - Number4;

            var Calculator = new Calculator.Domain.Calculator();
            
            Calculator.Current = Number1;
            Calculator.ProcessOperation(new CalculationOperation(new Add()));

            Calculator.Current = Number2;
            Calculator.ProcessOperation(new CalculationOperation(new Multiply()));

            Calculator.Current = Number3;
            Calculator.ProcessOperation(new CalculationOperation(new Subtract()));

            Calculator.Current = Number4;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(Answer, Calculator.Current);

        }
    }
}
