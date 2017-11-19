using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Domain;
using System;

namespace tests
{
    [TestClass]
    public class MemoryTests
    {
        [TestMethod]
        public void TestMemoryRecall()
        {
            var Random = new System.Random();
            double Number1 = Random.Next();
            double Number2 = Random.Next();
            double Answer = Number1 + Number2;

            var Calculator = new Calculator.Domain.Calculator();

            Calculator.Current = Number1;
            Calculator.ProcessOperation(new SaveToMemory());

            Calculator.ProcessOperation(new CalculationOperation(new Add()));

            Calculator.Current = Number2;
            Calculator.ProcessOperation(new EqualsOperation());

            Calculator.ProcessOperation(new RecallMemory());

            Assert.AreEqual(Number1, Calculator.Current);

        }

    }
}
