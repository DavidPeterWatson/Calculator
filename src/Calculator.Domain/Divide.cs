namespace Calculator.Domain
{
    public class Divide: IOperator
    {
        public int Precedence => 3;

        public double Calculate(Calculation calculation, Calculation nextCalculation)
        {
            return calculation.Number / nextCalculation.Number;
        }
        
    }
}