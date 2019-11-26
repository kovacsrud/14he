using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfIdomeres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stopwatch stopper;

        public MainWindow()
        {
            InitializeComponent();
            stopper = new Stopwatch();
        }

        private void buttonStartStop_Click(object sender, RoutedEventArgs e)
        {
            if (stopper.IsRunning)
            {
                stopper.Stop();
                labelIdo.Content = stopper.ElapsedMilliseconds;
                buttonStartStop.Content = "Start";
            } else
            {
                stopper.Reset();
                stopper.Start();
                buttonStartStop.Content = "Stop";
            }
              
            }
    }
}
