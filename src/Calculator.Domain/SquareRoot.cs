
namespace Calculator.Domain
{
    public class SquareRoot : IOperation
    {
        public void ProcessOperation(Calculator calculator)
        {
            calculator.Current = System.Math.Sqrt(calculator.Current);
        }
    }
}