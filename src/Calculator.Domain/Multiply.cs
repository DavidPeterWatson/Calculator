namespace Calculator.Domain
{
    public class Multiply : ICalculation
    {
        public int Precedence => 3;

        public double Calculate(Operation operation, Operation previousOperation)
        {
            return previousOperation.Number * operation.Number;
        }
    }
}