namespace Calculator.Domain
{
    public class SquareRoot : ICalculation
    {
        public int Precedence => 1;

        public double Calculate(Operation operation, Operation previousOperation)
        {
            operation.Number;
        }
    }
}