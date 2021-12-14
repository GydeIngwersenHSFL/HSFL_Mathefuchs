
namespace Mathefuchs._3_Model
{
    public class MTask
    {
        //Zufallsvariable 1
        private string n1v;
        public string n1
        {
            get { return n1v; }
            set { n1v = value; }
        }
        //Zufallsvariable 2
        private string n2v;
        public string n2
        {
            get { return n2v; }
            set { n2v = value; }
        }
        //Variable für Operator
        public Operator mOperator;
        //Variable 
        private string opstrv = "";
        public string opstr
        {
            get { return opstrv; }
            set { opstrv = value; }
        }
        //Variable für Ergebnis
        public int result;
        public MTask(int n1, int n2, Operator opval)
        {
            /*
             * Zufallsvariablen und Operator zu Aufgaben zusammensetzen
             */
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

        public bool CheckGuess(int guess) { 
            /*
             * Überprüfung der Ergebniseingabe
             */
            return guess == result; 
        }

        public override string ToString()
        {
            /*
             * Überschreibung der ToString-Methode: Ausgabe der Variablen (n1, n2, opstr, result)
             */
            return ($"n1: {n1}, n2: {n2}, op: {opstr}, result: {result}");
        }
    }
}
