namespace Calculator.Domain
{
    public interface ICalculation
    {

        double Calculate(Calculation calculation, Calculation previousCalculation);
        int Precedence { get; }

    }
}