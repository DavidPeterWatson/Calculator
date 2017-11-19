using System.Collections.Generic;
using System.Linq;

namespace Calculator.Domain
{
    public class Calculator
    {

        public List<Calculation> Calculations { get; set; }
        public double Memory { get; set; }
        public double Current { get; set; }

        public Calculator()
        {
            Calculations = new List<Calculation>();
        }
        
        public void ProcessOperation(IOperation operation)
        {
            operation.ProcessOperation(this);
        }

    }

}