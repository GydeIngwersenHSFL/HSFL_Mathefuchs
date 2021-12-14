using System;

namespace Mathefuchs._3_Model
{
    public class Training
    {
        public bool plus { get; set; }
        //Variable Plusaufgaben erlaubt
        public bool minus { get; set; }
        //Variable Minusaufgaben erlaubt
        public int nrOfTasks { get; set; }
        //Variable Aufgabenanzahl
        public int tasksSolved { get; set; }
        //Variable Aufgaben gelöst
        public int tasksSolvedAtFirstTry { get; set; }
        //Variable Aufgaben beim ersten Mal gelöst
        public int max { get; set; }
        //Variable maximaler Zahl pro Aufgabe
        public bool tenTransition { get; set; }
        //Variable Zehnerübergang
        public MTask[] tasks { get; set; }
        //Variable Aufgabe

        public static Random rnd;
        //Variable Zufallszahl

        public Training(bool plus, bool minus, int nrOfTasks, int max, bool tenTransition)
        {
            /*
             * Auswahl der Aufgabenart und der jeweiligen zufällig generierten Aufgaben
             */
            this.plus = plus;
            this.minus = minus;
            this.nrOfTasks = nrOfTasks;
            this.max = max;
            this.tenTransition = tenTransition;
            tasksSolved = 0;
            tasksSolvedAtFirstTry = 0;
            rnd = new Random();

            tasks = new MTask[nrOfTasks];
            MTask t;
            for (int i = 0; i < nrOfTasks; i++)
            {
                if (plus && minus)
                {
                    int r = rnd.Next(0,2);
                    Console.WriteLine(r);
                    if (r == 0) { t = generatePlusTask(max, tenTransition); }
                    else { t = generateMinusTask(max, tenTransition); }
                }
                else if (plus && !minus) { t = generatePlusTask(max, tenTransition); }
                else if (minus && !plus){ t = generateMinusTask(max, tenTransition); }
                else { t = null; }

                tasks[i] = t;
            }
        }

        private MTask generatePlusTask(int max, bool tenTransition)
        {
            /*
             * Generierung zufällinger Plusaufgaben
             */
            int num1 = rnd.Next(1, max);
            int num2;
            if (tenTransition) { num2 = rnd.Next(1, max - num1); }
            else {
                num2 = rnd.Next(1, 10 - num1 % 10);
            }

            return new MTask(num1, num2, Operator.Plus);
        }

        private MTask generateMinusTask(int max, bool tenTransition)
        {
            /*
             * Generierung zufällinger Minusaufgaben
             */
            int num1 = rnd.Next(1, max);
            int num2;
            if (tenTransition) { num2 = rnd.Next(1, num1); }
            else
            {
                int n10 = num1 % 10;
                if(n10 != 0) { num2 = rnd.Next(1, num1 % 10); }
                else { num2 = rnd.Next(1, 10); }   
            }

            return new MTask(num1, num2, Operator.Minus);
        }

        public override string ToString()
        {
            /*
             * Überschreibung der ToString-Methode: Ausgabe der Aufgaben
             */
            string print = "";
            foreach (MTask task in tasks)
            {
                print += task.ToString() + "\n";
            }
            return print;
        }

    }
}
