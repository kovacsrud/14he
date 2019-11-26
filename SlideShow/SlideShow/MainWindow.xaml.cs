using Microsoft.Win32;
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
using System.Windows.Threading;

namespace SlideShow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openDialog;
        string[] fajlok;
        int szamlalo;
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            szamlalo = 0;
            timer = new DispatcherTimer(TimeSpan.FromMilliseconds(1000),DispatcherPriority.Normal,Kepvalto,Dispatcher.CurrentDispatcher);
            timer.Stop();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;

            if (openDialog.ShowDialog()==true)
            {
                fajlok = openDialog.FileNames;
                Debug.WriteLine(fajlok[0]);
                timer.Start();
                Debug.WriteLine(timer.Interval);
            }

        }

        private void Kepvalto(object sender,EventArgs e)
        {
            kep.Source = new BitmapImage(new Uri(fajlok[szamlalo]));
            szamlalo++;
            if (szamlalo>=fajlok.Length)
            {
                szamlalo = 0;
            }
        }


    }
}
