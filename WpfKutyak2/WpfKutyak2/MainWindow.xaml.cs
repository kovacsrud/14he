using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfKutyak2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kutyacontext kutyaContext;

        public MainWindow()
        {
            InitializeComponent();
            kutyaContext = new Kutyacontext();
            kutyaContext.Kutyak.Load();
            kutyaContext.Kutyanevek.Load();
            kutyaContext.Kutyafajtak.Load();

            DataContext = kutyaContext.Kutyak.Local;
            kutyanevAdatok.DataContext = kutyaContext.Kutyanevek.Local;
            kutyafajtaAdatok.DataContext = kutyaContext.Kutyafajtak.Local;

        }

        private void kutyanevUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kutyaContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Az adat nem törölhető!");
                
            }
            
        }

        private void kutyafajtaUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kutyaContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Az adat nem törölhető!");

            }
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            searchAdatok.Items.Clear();
            var search = kutyaContext.Kutyak.Local.Where(x=>x.Kutyanevek.kutyanev==searchNev.Text);

            foreach (var i in search)
            {
                searchAdatok.Items.Add(i);
                Debug.WriteLine(i.eletkor);
                Debug.WriteLine(i.id);
                Debug.WriteLine(i.Kutyafajtak.nev);
            }
        }
    }
}
