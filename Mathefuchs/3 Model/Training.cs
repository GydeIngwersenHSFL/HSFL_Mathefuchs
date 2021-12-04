using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathefuchs._3_Model
{
    public class Training
    {
        public bool plus { get; set; }
        public bool minus { get; set; }
        public int nrOfTasks { get; set; }
        public int tasksSolved { get; set; }
        public int tasksSolvedAtFirstTry { get; set; }
        public int max { get; set; }
        public bool tenTransition { get; set; }
        public MTask[] tasks { get; set; }

        public static Random rnd = new Random();

        public Training(bool plus, bool minus, int nrOfTasks, int max, bool tenTransition)
        {
            this.plus = plus;
            this.minus = minus;
            this.nrOfTasks = nrOfTasks;
            this.max = max;
            this.tenTransition = tenTransition;
            tasksSolved = 0;
            tasksSolvedAtFirstTry = 0;

            tasks = new MTask[nrOfTasks];
            MTask t;
            Console.WriteLine("before loop");
            for (int i = 0; i < nrOfTasks; i++)
            {
                Console.WriteLine("loop");
                if (plus && minus)
                {
                    if (rnd.Next(1) == 0) { t = generatePlusTask(max, tenTransition); }
                    else { t = generateMinusTask(max, tenTransition); }
                }
                else if (plus) { t = generatePlusTask(max, tenTransition); }
                else { t = generateMinusTask(max, tenTransition); }

                tasks[i] = t;
            }
        }

        private MTask generatePlusTask(int max, bool tenTransition)
        {
            int num1 = rnd.Next(0, max);
            int num2 = rnd.Next(0, max - num1);

            return new MTask(num1, num2, Operator.Plus);
        }

        private MTask generateMinusTask(int max, bool tenTransition)
        {
            int num1 = rnd.Next(0, max);
            int num2 = rnd.Next(0 + num1, max);

            return new MTask(num1, num2, Operator.Minus);
        }

        public override string ToString()
        {
            string print = "";
            foreach (MTask task in tasks)
            {
                print += task.ToString() + "\n";
            }
            return print;
        }

    }
}
