namespace Calculator.Domain
{
    public class CalculationOperation : IOperation
    {
        public IOperator Operator { get; set; }

        public CalculationOperation(IOperator Operator)
        {
            this.Operator = Operator;
        }

        public void ProcessOperation(Calculator calculator)
        {
            var Calculation = new Calculation() { Operator = this.Operator, Number = calculator.Current };

            calculator.Calculations.Add(Calculation);
        }
    }
}