using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Domain;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Calculator = new Calculator.Domain.Calculator();
            Calculator.Current = 3;
            Calculator.ProcessOperation(new CalculationOperation(new Add()));
            Calculator.Current = 4;
            Calculator.ProcessOperation(new EqualsOperation());

            Assert.AreEqual(7.0, Calculator.Current);

        }
    }
}
