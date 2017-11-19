namespace Calculator.Domain
{
    public class Add : IOperator
    {
        public int Precedence { get => 5; }

        public double Calculate(Calculation calculation, Calculation nextCalculation)
        {
            return calculation.Number + nextCalculation.Number;
        }
    }
}