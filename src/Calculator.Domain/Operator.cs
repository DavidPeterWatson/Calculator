namespace Calculator.Domain
{
    public interface IOperator
    {
        int Precedence { get; }

        double Calculate(Calculation calculation, Calculation nextCalculation);

    } 
}