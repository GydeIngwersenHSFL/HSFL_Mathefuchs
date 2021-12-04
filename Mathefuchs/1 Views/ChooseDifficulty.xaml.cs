using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Mathefuchs._2_Viewmodels;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für ChooseDifficulty.xaml
    /// </summary>
    public partial class ChooseDifficulty : Page
    {
        public ChooseDifficulty()
        {
            InitializeComponent();
        }

        private void Easy_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SetDifficulty(1, Window.GetWindow(this));
        }
        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SetDifficulty(2, Window.GetWindow(this));
        }
        private void Hard_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SetDifficulty(3, Window.GetWindow(this));
        }
    }
}
