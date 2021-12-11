using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für Training_Plus_Minus.xaml
    /// </summary>
    public partial class Training_Plus_Minus : Page
    {
        public Training_Plus_Minus()
        {
            InitializeComponent();
            this.DataContext = ViewModel.vmdc;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CheckGuess(tb.Text, Window.GetWindow(this));
        }
    }



}
