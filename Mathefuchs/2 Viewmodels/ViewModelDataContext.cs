using Mathefuchs._3_Model;

namespace Mathefuchs._2_Viewmodels
{
    public class ViewModelDataContext
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
        //Variable für das richtige Ergebnis
        private string resultv;
        public string result
        {
            get { return resultv; }
            set { resultv = value; }
        }
        //Variable für Infotext
        private string infov;
        public string info
        {
            get { return infov; }
            set { infov = value; }
        }
        //Variable für den Operatoren
        private string opv;
        public string op
        {
            get { return opv; }
            set { opv = value; }
        }
        //Variable für die Aufgabenart
        private Training trainingv;
        public Training training
        {
            get { return trainingv; }
            set { trainingv = value; }
        }
        //Variable für das Minispiel
        private Minigame minigamev;
        public Minigame minigame
        {
            get { return minigamev; }
            set { minigamev= value; }
        }
    }
}
