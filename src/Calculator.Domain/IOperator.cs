namespace Calculator.Domain
{
    public interface ICalculation
    {

        double Calculate(Calculation calculation, Calculation nextCalculation);
        int Precedence { get; }

    }
}