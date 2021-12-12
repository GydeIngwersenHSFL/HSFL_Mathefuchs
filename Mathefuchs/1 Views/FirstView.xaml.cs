using System.Windows;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartProgram_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Beim klicken des Start-Buttons: Auswählen des "Opening" Videos und wechseln zur Videoansicht.
             */
            ViewModel.openingvideo = true;
            ViewModel.ChangePage(new Mathefuchs._1_Views.VideoPlayer(), Window.GetWindow(this));
        }
    }
}
