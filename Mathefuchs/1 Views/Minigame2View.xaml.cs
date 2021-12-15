using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für Minigame.xaml
    /// </summary>
    public partial class Minigame2View : Page
    {
        public Minigame2View()
        {
            InitializeComponent();
        }



        private void Right_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Button richtiger Weg
             * Ansicht wechseln zu EndOfMinigame
             */
            ViewModel.ChangePage(new Mathefuchs._1_Views.EndOfMinigame(), Window.GetWindow(this));
        }

        private void Wrong_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Button falscher Weg
             * Ansicht Minigame beibehalten
             */
            ViewModel.ChangePage(new Mathefuchs._1_Views.Minigame2View(), Window.GetWindow(this));
        }

    }

}
