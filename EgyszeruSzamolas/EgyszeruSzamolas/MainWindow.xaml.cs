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

namespace EgyszeruSzamolas
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
                var a = Convert.ToInt32(textboxA.Text);
                var b = Convert.ToInt32(textboxB.Text);
                var c = Convert.ToInt32(textboxC.Text);
                var eredmeny = (a + b) / c;

                //labelEredmeny.Content = $"{eredmeny:0.00}";
                labelEredmeny.Content = $"{eredmeny}";
            }
            catch(FormatException ex)
            {
                MessageBox.Show("A mezőkbe számokat kell megadni!","HIBA!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("A C értéke nem lehet 0!", "HIBA!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HIBA!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           

        }
    }
}
