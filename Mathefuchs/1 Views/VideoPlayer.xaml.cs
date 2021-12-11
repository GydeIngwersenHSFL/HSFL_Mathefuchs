using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Mathefuchs._2_Viewmodels;

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

        private static string CreateAbsolutePathTo(string mediaFile)
        {
            return Path.Combine(new FileInfo(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName).DirectoryName, mediaFile);
        }

        private MediaElement video()
        {
            if (ViewModel.openingvideo == true)
            {
                ViewModel.openingvideo = false;
                openingVideo.Source = new Uri(CreateAbsolutePathTo(@"HSFL_Mathefuchs\Mathefuchs\Videos\Opening.mp4"), UriKind.Absolute);
                return openingVideo;
            }
            else if (ViewModel.plusvideo == true)
            {
                ViewModel.plusvideo = false;
                plusVideo.Source = new Uri(CreateAbsolutePathTo(@"HSFL_Mathefuchs\Mathefuchs\Videos\PlusRechnen.mp4"), UriKind.Absolute);
                return plusVideo;
            }        
            else if (ViewModel.plusvideo == false)
            {
                ViewModel.plusvideo = true;
                minusVideo.Source = new Uri(CreateAbsolutePathTo(@"HSFL_Mathefuchs\Mathefuchs\Videos\MinusRechnen.mp4"), UriKind.Absolute);
                return minusVideo;
            }
            else
            {
                fritzVideo.Source = new Uri(CreateAbsolutePathTo(@"HSFL_Mathefuchs\Mathefuchs\Videos\FritzDerFuchs.mp4"), UriKind.Absolute);
                return fritzVideo;
            }             
        }

        // Für Play- und Pause-Button
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            video().Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            video().Pause();
        }

        private void endeVideo(object sender, RoutedEventArgs e)
        {
            ViewModel.ChangePage(new Mathefuchs._1_Views.MainView(), Window.GetWindow(this));
        }
    }
}
