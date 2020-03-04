using RadioApp;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Radio r; // builds object r

        public MainWindow()
        {
            r = new Radio(); 
            r.Read();
            InitializeComponent();
        }
        // off button object with the methods within
        private void offButton(object sender, RoutedEventArgs e)
        {
            r.TurnOff();
            r.Write();
            radioStatus.Text = "Radio off";
            volumeStatus.Text = "Off";
            MusicPlayer.Stop();

        }
        // on button object with methods within
        private void onButton(object sender, RoutedEventArgs e)
        {
            r.TurnOn();
            r.Read();
            radioStatus.Text = $"{r.Play()}";
            volumeStatus.Text = $"{r.VolumeUpDown()}";
            MusicPlayer.Play();
        }


        // if radio On == true then play music from source specified in the uri, status will also be updated in central feed.
        private void channel_1(object sender, RoutedEventArgs e)
        {
            r.Channel = 1; ;
            if (r.On == true)
            {
                radioStatus.Text = $"{r.Play()}";
                MusicPlayer.Source = new Uri(@"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 5\Music\Channel 1\song 1.mp3");
                MusicPlayer.Play();
            }
            radioStatus.Text = $"{r.Play()}";
        }


        private void channel_2(object sender, RoutedEventArgs e)
        {
            r.Channel = 2;
            if (r.On == true)
            {
                radioStatus.Text = $"{r.Play()}";
                MusicPlayer.Source = new Uri(@"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 5\Music\Channel 2\song 2.mp3");
                MusicPlayer.Play();
            }
            radioStatus.Text = $"{r.Play()}";

        }


        private void channel_3(object sender, RoutedEventArgs e)
        {
            r.Channel = 3;
            if(r.On == true)
            { 
            radioStatus.Text = $"{r.Play()}";
            MusicPlayer.Source = new Uri(@"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 5\Music\Channel 3\song 3.mp3");
            MusicPlayer.Play();
            }
            radioStatus.Text = $"{r.Play()}";
        
        }


        private void channel_4(object sender, RoutedEventArgs e)
        {
            r.Channel = 4;
            if (r.On == true)
            {
                radioStatus.Text = $"{r.Play()}";
                MusicPlayer.Source = new Uri(@"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 5\Music\Channel 4\song 4.mp3");
                MusicPlayer.Play();
            }
            radioStatus.Text = $"{r.Play()}";
           
        }

        //Volume status is being updated with the volumeUpDown metho
        private void Volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            volumeStatus.Text = $"{r.VolumeUpDown()}";
        }

        // increases volume by one and shows the new value in the volume status via string 
        private void volumeUp_Click(object sender, RoutedEventArgs e)
        {
            r.Volume += 1;
            volumeStatus.Text = $"{r.Volume}";
        }

        // same logic as above but decreases
        private void volumeDown_Click(object sender, RoutedEventArgs e)
        {
            r.Volume -= 1;
            volumeStatus.Text = $"{r.Volume}";
        }

        private void RadioOff_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        //calls write method as the window closes
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            r.Write();
        }

        private void volumeStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            r.VolumeUpDown();
        }


        //failure
        //private void MusicPlay()
        //{
        //    if (r.On == true)
        //    {
        //        MusicPlayer.Play();
        //    }
        
    }
}
             
        

