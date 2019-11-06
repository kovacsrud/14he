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

namespace WpfDinamikus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gombok(100);
        }

        public void Gombok(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Button button = new Button();
                button.Content = i;
                button.FontSize = 25;
                button.Margin = new Thickness(10);
                gombok.Children.Add(button);
            }
        }

        private void buttonGyart_Click(object sender, RoutedEventArgs e)
        {
            gombok.Children.Clear();
            
        }
    }
}
