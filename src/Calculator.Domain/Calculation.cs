namespace Calculator.Domain
{
    public class Calculation: IOperation
    {
        public double Number { get; set; }
        public IOperator Operator { get; set; }

        public void ProcessOperation(Calculator calculator)
        {
calculator.Calculations.Add(this);
        }

        public double Calculate(Calculation previousOperation)
        {
             return Operator.Calculate(this, previousOperation);
        }
    }
}