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

namespace WpfTankolas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double megtettKM = Convert.ToDouble(textboxKm.Text);
                double tankoltMennyiseg= Convert.ToDouble(textboxMennyiseg.Text);
                double uzemanyagAr= Convert.ToDouble(textboxUzemanyagAr.Text);
                double atlagFogyasztas = tankoltMennyiseg / (megtettKM / 100);
                double egyKmKoltsege = (atlagFogyasztas / 100) * uzemanyagAr;

                labelEredmeny.Content = $"Átlagfogyasztás:{atlagFogyasztas}, egy km költsége:{egyKmKoltsege}";

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Egyik mező sem lehet üres, vagy szöveg!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba! "+ex.Message);
            }
        }
    }
}
