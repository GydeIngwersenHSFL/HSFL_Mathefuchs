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
using Mathefuchs._3_Model;

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
