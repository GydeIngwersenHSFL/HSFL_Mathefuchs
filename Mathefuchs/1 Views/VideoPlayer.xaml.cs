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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mathefuchs._1_Views
{
    /// <summary>
    /// Interaktionslogik für VideoPlayer.xaml
    /// </summary>
    public partial class VideoPlayer : Page
    {
        public VideoPlayer()
        {
            InitializeComponent();
            video().Play(); //Video beginnt automatisch
        }
        //
         MediaElement video()
        {
            if (ViewModel.openingvideo == true)
            {
                ViewModel.openingvideo = false;
                return openingVideo;
            }
            else if (ViewModel.plusvideo == true)
            {
                ViewModel.plusvideo = false;
                return plusVideo;
            }
                
            else if (ViewModel.plusvideo == false)
            {
                ViewModel.plusvideo = true;
                return minusVideo;
            }
            else
                return fritzVideo;
        }
        // Für Play- und Pause-Button
        // private void btnPlay_Click(object sender, RoutedEventArgs e)
        // {
        //     video().Play();
        // }
        // private void btnPause_Click(object sender, RoutedEventArgs e)
        // {
        //     video().Pause();
        // }
        // private void endeVideo(object sender, RoutedEventArgs e)
        // {
        //     ViewModel.ChangePage(new Mathefuchs._1_Views.MainView(), Window.GetWindow(this));
        // }
    }
}
