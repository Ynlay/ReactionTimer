using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ReactionTimer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReactionWindow : Page
    {
        private bool isRed;
        private double score;
        private int randomTime;
        private Stopwatch stopwatchRed = new Stopwatch();

        public ReactionWindow()
        {
            this.InitializeComponent();
            Random rng = new Random();
            score = 0;
            isRed = false;
            var stopwatchRed = new Stopwatch(); 
            randomTime = rng.Next(3, 10);
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

       

        private EventHandler<object> EventHandler(object tick)
        {
            throw new NotImplementedException();
        }

        private void background_Tapped(object sender, TappedRoutedEventArgs e)
        {
           this.Frame.Navigate(typeof(ResultWindow));
           // ReactionBackground.Background = new SolidColorBrush(Windows.UI.Colors.Red);
        }

        public bool getColor() // this will only be needed if i allow taps on green screen
        {
            return isRed;
        }

        public double getScore()
        {
            return score;
        }

    }
}
