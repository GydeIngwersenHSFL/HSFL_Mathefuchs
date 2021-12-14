using System;
using System.Windows;
using System.Windows.Controls;
using Mathefuchs._3_Model;

namespace Mathefuchs._2_Viewmodels
{
    public class ViewModel
    {
        static int nrOfTaks = 10;
        //Variable Aufgabenanzahl
        static bool plus = false;
        //Variable Plusaufgaben erlaubt
        static bool minus = false;
        //Variablen Minusaufgaben erlaubt
        static int max = 0;
        //Variable maximale Zahl pro Aufgabe
        static bool tenTransition = false;
        //Variable Zehnerübergang
        static Training training;
        //Variable Trainingsauswahl
        public static ViewModelDataContext vmdc;

        public static bool plusvideo = true;
        //Variable Plusvideo abspielen
        public static bool openingvideo = true;
        //Variable Minusvideo abspielen

        internal static void GoToMinigame(Window window)
        {
            /*
             * Wechseln der Ansicht zum Minigame
             */
            //here you can add a random generator and then route to other minigame views
            ChangePage(new Mathefuchs._1_Views.MinigameView(), window);
        }   

        internal static void SetTasks(int tasks, Window window)
        {
            /*
             * Aufbau der Aufgaben
             */
            nrOfTaks = tasks;
            training = new Training(plus, minus, nrOfTaks, max, tenTransition);

            vmdc = new ViewModelDataContext();
            vmdc.training = training;

            NextTask(window);

            ChangePage(new Mathefuchs._1_Views.Training_Plus_Minus(), window); 
        }

        public static void NextTask(Window window)
        {
            /*
             * Nächste Aufgabe
             * Zuweisung der Zufallsvariablen n1 und n2, sowie des Operatoren und des richtigen Ergebnisses.
             */
            MTask task = training.tasks[vmdc.training.tasksSolved];
            vmdc.training.tasksSolved++;
            vmdc.n1 = task.n1;
            vmdc.n2 = task.n2;
            vmdc.op = task.opstr;
            vmdc.result = task.result.ToString();
        }

        public static void CheckGuess(string guess, Window window)
        {
            /*
             * Überprüfung der Eingabe
             * Wechseln der Ansicht zur Endansicht wenn die zuvor ausgewählte Anzahl der Aufgaben erreicht ist.
             */
            if (guess == vmdc.result.ToString())
            {
                vmdc.info = "Super!";
                if (vmdc.training.tasksSolved < nrOfTaks) 
                {
                    NextTask(window);
                    ChangePage(new Mathefuchs._1_Views.Training_Plus_Minus(), window);
                }
                else
                {
                    ChangePage(new Mathefuchs._1_Views.EndOfTraining(), window);
                }
            }
            else
            {
                vmdc.info = "Fast! Versuche es noch einmal!";
                ChangePage(new Mathefuchs._1_Views.Training_Plus_Minus(), window);
            }
        }

        internal static void SetDifficulty(int diff, Window window)
        {
            /*
             * Setzen des Schwierigkeitsgrades (1=leicht, 2=mittel, 3=schwer)
             * Wechseln der Ansicht zur Auswahl der Aufgabenanzahl
             */
            if (diff == 1 || diff == 3) { tenTransition = true; }
            else { tenTransition = false; }

            if(diff == 1) { max = 20; }
            else { max = 100; }

            ChangePage(new Mathefuchs._1_Views.ChooseNrOfTasks(), window);

        }
        public static void TrainingChoice(bool plus1, bool minus1, Window window)
        {
            /*
             * Auswahl der Übungen (Plus/ Minus/ Plus und Minus)
             * Wechseln der Ansicht zur Auswahl des Schwierigkeitsgrades
             */
            plus = plus1;
            minus = minus1;
            ChangePage(new Mathefuchs._1_Views.ChooseDifficulty(), window);

        }

        /*
        public static void NewMinigame()
        {
            vmdc.minigame = new Minigame();
        }

        public static void checkMinigameguess(string guess, Window window)
        {
            if (guess == vmdc.minigame.solution)
            {
                //goTo Minigame End
                ChangePage(new Mathefuchs._1_Views.EndOfMinigame(), window);
            }
            else
            {
                ChangePage(new Mathefuchs._1_Views.MinigameView(), window);
                vmdc.info = "Hier bin ich leider falsch...";
            }
        }
        */

        
        public static void ChangePage(Page page, Window window)
        {
            /*
             * Navigation
             */
            window.Content = page;
        }
    }
}
