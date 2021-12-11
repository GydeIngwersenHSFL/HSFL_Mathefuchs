using System;
namespace Mathefuchs._3_Model
{
    public class Minigame
    {
        private string pngv;
        public string png
        {
            get { return pngv; }
            set { pngv = value; }
        }

        public string solutionv;

        public string solution
        {
            get { return solutionv; }
            set { solutionv = value; }
        }



        public static Random rnd;


        public Minigame()
        {
            int r = rnd.Next(0, 2);

            if(r == 0)
            {
                //minigame b
                png = "/Images/minib";
                solution = "b";
            }
            else
            {
                //minigame c
                png = "/Images/minic";
                solution = "c";
            }
        }

    }
}
