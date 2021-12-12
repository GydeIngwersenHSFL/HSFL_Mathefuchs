using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;


namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für MainView.xaml
    /// </summary>
    public partial class MainView : Page
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void showAdditionVideo(object sender, RoutedEventArgs e)
        {
            /*
             * "PlusRechnen" Video auswählen und zur Videoansicht wechseln.
             */
            ViewModel.plusvideo = true;
            ViewModel.ChangePage(new Mathefuchs._1_Views.VideoPlayer(), Window.GetWindow(this));
        }

        private void showSubtractionVideo(object sender, RoutedEventArgs e)
        {
            /*
             * "MinusRechnen" Video auswählen und zur Videoansicht wechseln.
             */
            ViewModel.plusvideo = false;
            ViewModel.ChangePage(new Mathefuchs._1_Views.VideoPlayer(), Window.GetWindow(this));
        }
        
        private void Training_Addition_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Additionsübungen auswählen.
             */
            ViewModel.TrainingChoice(true, false, Window.GetWindow(this));
        }

        private void Training_Subtraction_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Subtraktionsübungen auswählen.
             */
            ViewModel.TrainingChoice(false, true, Window.GetWindow(this));
        }
        private void Training_AddSub_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Additions- und Subtraktionsübungen auswählen.
             */
            ViewModel.TrainingChoice(true, true, Window.GetWindow(this));

        }
    }
}
