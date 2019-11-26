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

namespace WpfIdojaras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IdojarasAdatok idoadatok;

        public MainWindow()
        {
            InitializeComponent();
            idoadatok = new IdojarasAdatok("idojaras.csv");
            evek.SelectionChanged += evekChange;
            honapok.SelectionChanged += honapokChange;
            napok.SelectionChanged += napokChange;
            evek.ItemsSource = idoadatok.Evek();
        }

        public void evekChange(object sender,EventArgs e)
        {
            honapok.ItemsSource = idoadatok.Honapok(Convert.ToInt32(evek.SelectedItem));
            adatRacs.ItemsSource = idoadatok.getRacsAdatok(Convert.ToInt32(evek.SelectedItem));
        }

        public void honapokChange(object sender,EventArgs e)
        {
            napok.ItemsSource = idoadatok.Napok(Convert.ToInt32(evek.SelectedItem), Convert.ToInt32(honapok.SelectedItem));
            adatRacs.ItemsSource = idoadatok.getRacsAdatok(Convert.ToInt32(evek.SelectedItem), Convert.ToInt32(honapok.SelectedItem));
        }
        public void napokChange(object sender,EventArgs e)
        {
            adatRacs.ItemsSource = idoadatok.getRacsAdatok(Convert.ToInt32(evek.SelectedItem), Convert.ToInt32(honapok.SelectedItem), Convert.ToInt32(napok.SelectedItem));
        }
    }
}
