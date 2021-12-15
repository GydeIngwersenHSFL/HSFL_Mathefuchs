using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für ChooseNrOfTasks.xaml
    /// </summary>
    public partial class ChooseNrOfTasks : Page
    {
        public ChooseNrOfTasks()
        {
            InitializeComponent();
        }

        private void Tasks5_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Button zum Auswählen von 5 Aufgaben
             */
            ViewModel.SetTasks(5, Window.GetWindow(this));
        }
        private void Tasks10_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Button zum Auswählen von 10 Aufgaben
             */
            ViewModel.SetTasks(10, Window.GetWindow(this));
        }
        private void Tasks20_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Button zum Auswählen von 20 Aufgaben
             */
            ViewModel.SetTasks(20, Window.GetWindow(this));
        }

        /*
        private void ShowTrainingPage()
        {
            var trainingPage = new Mathefuchs._1_Views.Training_Plus_Minus();
            this.Content = trainingPage;
        }
        */
    }
}
