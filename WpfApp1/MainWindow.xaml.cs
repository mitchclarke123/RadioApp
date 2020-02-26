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
    public partial class MainWindow : Window
    {   
        Radio r = new Radio();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void offButton(object sender, RoutedEventArgs e)
        {
          
            r.TurnOff();
            radioStatus.Text = "Radio off";

        }

        private void onButton(object sender, RoutedEventArgs e)
        {
            r.TurnOn();
            radioStatus.Text = $"{r.Play()}";
        }

        

        private void channel_1(object sender, RoutedEventArgs e)
        {
            r.Channel = 1; ;
            radioStatus.Text = $"{r.Play()}";
        }

        private void channel_2(object sender, RoutedEventArgs e)
        {
            r.Channel = 2;
            radioStatus.Text = $"{r.Play()}";
        }

        private void channel_3(object sender, RoutedEventArgs e)
        {
            r.Channel = 3;
            radioStatus.Text = $"{r.Play()}";
        }

        private void channel_4(object sender, RoutedEventArgs e)
        {
            r.Channel = 4;
            radioStatus.Text = $"{r.Play()}";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioOff_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void upVolume(object sender, RoutedEventArgs e)
        {

        }
    }
}
