using System.Linq;

namespace Calculator.Domain
{
    public class EqualsOperation : IOperation
    {
        public void ProcessOperation(Calculator calculator)
        {
            //Continuously loop through operations reducing the highest precendence operation into the number of the operation before it until there is only 1 operation left

            var firstCalculation = calculator.Calculations.First();

            while (calculator.Calculations.Count > 1)
            {
    
                var PrecedenceQuery =
                from Calculation findCalculation in calculator.Calculations
                where findCalculation != firstCalculation
                orderby findCalculation.Operator.Precedence ascending
                select findCalculation;

                var nextCalculation = PrecedenceQuery.FirstOrDefault();

                var previousCalculation = calculator.Calculations[calculator.Calculations.IndexOf(nextCalculation) - 1];

                previousCalculation.Number = nextCalculation.Calculate(previousCalculation);

                calculator.Calculations.Remove(nextCalculation);

            }

        }
    }
}