using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für EndOfTraining.xaml
    /// </summary>
    public partial class EndOfTraining : Page
    {
        public EndOfTraining()
        {
            InitializeComponent();
        }

        public void Next_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ChangePage(new Mathefuchs._1_Views.MinigameView(), Window.GetWindow(this));
        }
    }
}
