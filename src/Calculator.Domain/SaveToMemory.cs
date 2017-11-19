namespace Calculator.Domain
{
    public class SaveToMemory: IOperation
    {
        public void ProcessOperation(Calculator calculator)
        {
            calculator.Memory = calculator.Current;
        }

    }

}