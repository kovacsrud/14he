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

namespace WpfNevsor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Adapter adapter;

        public MainWindow()
        {
            InitializeComponent();
            adapter = new Adapter("Data Source=nevsor20k.db;Version=3");
            nevsorAdatok.ItemsSource = adapter.GetAdatok().DefaultView;
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            adapter.UpdateAdatok();
        }
    }
}
