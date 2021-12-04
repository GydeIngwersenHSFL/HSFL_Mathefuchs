using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathefuchs._3_Model
{
    class CalculationElement
    {
        public bool isOperator { get; set; }
        public int number { get; set; }
        public Operator op { get; set; }

    public CalculationElement(bool isOperator, int number, Operator op) {
            this.isOperator = isOperator;
            this.number = number;
            this.op = op;
    }
    }
}
