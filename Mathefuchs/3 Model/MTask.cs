using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathefuchs._3_Model
{
    public class MTask
    {
        private string n1v;
        public string n1
        {
            get { return n1v; }
            set { n1v = value; }
        }

        private string n2v;
        public string n2
        {
            get { return n2v; }
            set { n2v = value; }
        }
        public Operator mOperator;

        private string opstrv = "";

        public string opstr
        {
            get { return opstrv; }
            set { opstrv = value; }
        }


        public int result;
        public MTask(int n1, int n2, Operator opval)
        {
            this.mOperator = opval;

            if (opval == Operator.Plus)
            {
                result = n1 + n2;
                opstr = "+";
            }
            else
            {
                result = n1 - n2;
                opstr = "-";
            }

            this.n1 = n1.ToString();
            this.n2 = n2.ToString();
        }

        public bool CheckGuess(int guess) { return guess == result; }

        public override string ToString()
        {
            return ($"n1: {n1}, n2: {n2}, op: {opstr}, result: {result}");
        }
    }
}
