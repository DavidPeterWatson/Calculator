namespace Calculator.Domain
{
    public class ClearOperation : IOperation
    {
        public void ProcessOperation(Calculator calculator)
        {
            calculator.Calculations.Clear();
            calculator.Memory = 0;
        }
    }
}