using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für Minigame.xaml
    /// </summary>
    public partial class Minigame : Page
    {
        public Minigame()
        {
            InitializeComponent();
            ViewModel.NewMinigame();
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.checkMinigameguess("a", Window.GetWindow(this));
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.checkMinigameguess("b", Window.GetWindow(this));
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.checkMinigameguess("c", Window.GetWindow(this));
        }
    }


}
