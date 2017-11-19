using System.Linq;

namespace Calculator.Domain
{
    public class EqualsOperation : IOperation
    {
        public void ProcessOperation(Calculator calculator)
        {
            //Continuously loop through operations reducing the highest precendence operation into the number of the operation before it until there is only 1 operation left

            var lastCalculation = new Calculation();
            lastCalculation.Number = calculator.Current;
            lastCalculation.Operator = new Add();

            calculator.Calculations.Add(lastCalculation);

            while (calculator.Calculations.Count > 1)
            {

                var PrecedenceQuery =
                from Calculation findCalculation in calculator.Calculations
                where findCalculation != lastCalculation
                orderby findCalculation.Operator.Precedence ascending
                select findCalculation;

                var calculation = PrecedenceQuery.FirstOrDefault();

                var nextCalculation = calculator.Calculations[calculator.Calculations.IndexOf(calculation) + 1];

                nextCalculation.Number = calculation.Calculate(nextCalculation);

                calculator.Calculations.Remove(calculation);

            }

            calculator.Current = calculator.Calculations.Last().Number;

        }
    }
}