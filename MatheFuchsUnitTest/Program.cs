using Mathefuchs._3_Model;
using System;
using System.Collections.Generic;

namespace MatheFuchsUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 1; i++)
            {
                plusminustest(true, false, 10, 20, true);
            }
        }

        private static void plusminustest( bool plus, bool minus, int nrOfTasks, int max, bool tenTransition){
            Training training = new Training(plus, minus, nrOfTasks, max, tenTransition);

            bool resultcheck = true;
            bool withinRange = true;
            bool differentTasks = true;
            bool operatorsCorrect = true;

            //are ther plus/minus operators?
            int plusops = 0;
            int minusops = 0;

            List<string> n1s = new List<string>();
            List<string> n2s = new List<string>();
            
            foreach (MTask task in training.tasks)
            {
                //operator count and result check
                if (task.opstr == "+") { 
                    plusops++; 
                    if(Int16.Parse(task.n1) + Int16.Parse(task.n2) != task.result){ resultcheck = false; }
                }
                else { 
                    minusops++;
                    if (Int16.Parse(task.n1) - Int16.Parse(task.n2) != task.result) { resultcheck = false; }
                }

                //number check for max number
                if(Int16.Parse(task.n1) > max || Int16.Parse(task.n2) > max|| task.result > max || task.result < 0) { withinRange = false; }

                //check for different taks

                if(n1s.Contains(task.n1) && n2s.Contains(task.n2)) { differentTasks = false; }

                n1s.Add(task.n1);
                n2s.Add(task.n2);
            }

            if (plus) { if (plusops <= 0) { operatorsCorrect = false; } }
            if (minus) { if (minusops <= 0 ) { operatorsCorrect = false; } }
            

            Console.WriteLine($"Unit Test: \n" +
                $"\nresults: {resultcheck}, " +
                $"\nNrRange: {withinRange}, " +
                $"\nDifferentTaks: {differentTasks}, " +
                $"\nOperatorsCorrect: {operatorsCorrect}" +
                $"\nplus : {plusops}, minus: {minusops}\n" +
                $"{training.ToString()}"
                );

            

        }


    }
}
