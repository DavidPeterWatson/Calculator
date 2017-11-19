namespace Calculator.Domain
{
    public class Add : ICalculation
    {
        public int Precedence { get => 5; }

        public double Calculate(Calculation operation, Calculation previousOperation)
        {
            return previousOperation.Number + operation.Number;
        }
    }
}