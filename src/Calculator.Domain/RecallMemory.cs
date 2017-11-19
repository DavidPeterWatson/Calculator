namespace Calculator.Domain
{
    public class RecallMemory: IOperation
    {
        public void ProcessOperation(Calculator calculator)
        {
            calculator.Current = calculator.Memory;
        }
    }
}