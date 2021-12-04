using Mathefuchs._3_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathefuchs._2_Viewmodels
{
    public class ViewModelDataContext
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

        private string resultv;
        public string result
        {
            get { return resultv; }
            set { resultv = value; }
        }

        private string infov;
        public string info
        {
            get { return infov; }
            set { infov = value; }
        }

        private string opv;
        public string op
        {
            get { return opv; }
            set { opv = value; }
        }

        private Training trainingv;
        public Training training
        {
            get { return trainingv; }
            set { trainingv = value; }
        }
        
    }
}
