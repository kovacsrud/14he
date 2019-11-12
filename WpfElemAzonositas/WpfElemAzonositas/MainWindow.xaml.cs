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

namespace WpfElemAzonositas
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

        public void Gombok(int darab)
        {
            for (int i = 0; i < darab; i++)
            {
                Button button = new Button();
                button.Content = i + 1;
                button.Click += GombClick;
                button.FontSize = 20;
                button.Margin = new Thickness(5);
                elemek.Children.Add(button);
            }

        }

        public void GombClick(object sender,RoutedEventArgs e)
        {
            Button button = (Button)sender;
            labelStatus.Content = button.Content;
            button.Background = Brushes.BlueViolet;
            //elemek.Children.Remove(button);

        }
    }
}
