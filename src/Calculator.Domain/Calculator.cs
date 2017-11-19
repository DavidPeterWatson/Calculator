using System.Collections.Generic;
using System.Linq;

namespace Calculator.Domain
{
    public class Calculator
    {

        public List<Calculation> Calculations { get; set; }
        public double Memory { get; set; }


        public void ProcessOperation(IOperation operation)
        {
            operation.ProcessOperation(this);
        }

    }
}