namespace Calculator.Domain
{
    public class AddToMemory : IOperation
    {
        public void ProcessOperation(Calculator calculator)
        {
            calculator.Memory += calculator.Current;
        }

    }
}