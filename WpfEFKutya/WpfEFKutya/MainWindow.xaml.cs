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
using System.Data.Entity;
using System.Diagnostics;

namespace WpfEFKutya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyaContext kutyacontext;
        public MainWindow()
        {
            InitializeComponent();
            kutyacontext = new KutyaContext();
            kutyacontext.Kutyak.Load();
            kutyacontext.Kutyanevek.Load();
            kutyacontext.Kutyafajtak.Load();

            //adatok.ItemsSource = kutyacontext.Kutyak.Local;
            DataContext = kutyacontext.Kutyak.Local;
            kutyanevek.DataContext = kutyacontext.Kutyanevek.Local;
            //DataContext = kutyacontext;
            //DataContext = this;

        }

        private void updateKutyanev_Click(object sender, RoutedEventArgs e)
        {
            kutyacontext.SaveChanges();
        }

        private void buttonsearch_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Kutyak> search=null;
            keresesAdatok.Items.Clear();
            if (searchfajta.Text.Length > 0 && searchnev.Text.Length > 0)
            {
                search = kutyacontext.Kutyak.Local.Where(x => x.Kutyanevek.kutyanev == searchnev.Text && x.Kutyafajtak.nev == searchfajta.Text);
            }
            else if (searchnev.Text.Length > 0)
            {
                search = kutyacontext.Kutyak.Local.Where(x => x.Kutyanevek.kutyanev == searchnev.Text);
            } else if (searchfajta.Text.Length > 0)
            {
                search = kutyacontext.Kutyak.Local.Where(x => x.Kutyafajtak.nev == searchfajta.Text);
            } else
            {
                MessageBox.Show("Adjon meg nevet, vagy fajtát!");
            }


            //Debug.WriteLine(search.Count());
            if (search!=null && search.Count()>0)
            {
                foreach (var i in search)
                {
                    Debug.WriteLine(i.Kutyanevek.kutyanev);
                    Debug.WriteLine(i.eletkor);
                    Debug.WriteLine(i.Kutyafajtak.nev);
                    keresesAdatok.Items.Add(i);
                }
            } else if(search != null && search.Count()==0) {
                MessageBox.Show("Nincs eredmény!");
            }
            else
            {
                MessageBox.Show("Nincs eredmény!");
            }
            
        }
    }
}
