using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für EndOfMinigame.xaml
    /// </summary>
    public partial class EndOfMinigame : Page
    {
        public EndOfMinigame()
        {
            InitializeComponent();
        }

        public void Next_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ChangePage(new Mathefuchs._1_Views.MainView(), Window.GetWindow(this));
        }

    }
}
