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
            comboUjKutyaId.ItemsSource = kutyaContext.Kutyanevek.Local;
            comboUjFajtaId.ItemsSource = kutyaContext.Kutyafajtak.Local;
            comboModKutyaId.ItemsSource= kutyaContext.Kutyanevek.Local;
            comboModFajtaId.ItemsSource = kutyaContext.Kutyafajtak.Local;
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
            IEnumerable<Kutyak> search=new List<Kutyak>();
            


            if (searchNev.Text.Length>0 && searchFajta.Text.Length>0)
            {
                search = kutyaContext.Kutyak.Local.Where(x => x.Kutyanevek.kutyanev == searchNev.Text && x.Kutyafajtak.nev==searchFajta.Text);
            } else if (searchNev.Text.Length > 0)
            {
                search = kutyaContext.Kutyak.Local.Where(x => x.Kutyanevek.kutyanev == searchNev.Text);

            } else if(searchFajta.Text.Length > 0)
            {
                search = kutyaContext.Kutyak.Local.Where(x =>x.Kutyafajtak.nev == searchFajta.Text);
            } else
            {
                MessageBox.Show("Nem található adat!");
            }

            if (search.Count()>0)
            {
                foreach (var i in search)
                {
                    searchAdatok.Items.Add(i);
                    Debug.WriteLine(i.eletkor);
                    Debug.WriteLine(i.id);
                    Debug.WriteLine(i.Kutyafajtak.nev);
                }
            } else
            {
                MessageBox.Show("Nincs találat!");
            }
            
        }

        private void buttonUjKezeles_Click(object sender, RoutedEventArgs e)
        {
           try {
                Kutyak ujkutya = new Kutyak
                {
                    eletkor = Convert.ToInt32(textBoxUjEletkor.Text),
                    utolsoellenorzes = Convert.ToDateTime(textBoxUjDatum.Text),
                    fajtaid = Convert.ToInt32(comboUjFajtaId.SelectedValue),
                    nevid = Convert.ToInt32(comboUjKutyaId.SelectedValue)
                };
            kutyaContext.Kutyak.Add(ujkutya);
            kutyaContext.SaveChanges();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
        }

        private void ModSelectionChanged(object sender,SelectionChangedEventArgs e)
        {
            Kutyak selectkutya = (Kutyak)kutyaAdatokModositas.SelectedItem;
            textBoxModId.Text = Convert.ToString(selectkutya.id);
            textBoxModEletkor.Text= Convert.ToString(selectkutya.eletkor);
            textBoxModDatum.Text= Convert.ToString(selectkutya.utolsoellenorzes);
            comboModKutyaId.SelectedValue = selectkutya.nevid;
            comboModFajtaId.SelectedValue = selectkutya.fajtaid;
        }

        private void buttonModositas_Click(object sender, RoutedEventArgs e)
        {
            var modositando = kutyaContext.Kutyak.Local.Where(x=>x.id==Convert.ToInt32(textBoxModId.Text));
            modositando.First().eletkor = Convert.ToInt32(textBoxModEletkor.Text);
            modositando.First().utolsoellenorzes = Convert.ToDateTime(textBoxModDatum.Text);
            modositando.First().fajtaid = Convert.ToInt32(comboModFajtaId.SelectedValue);
            modositando.First().nevid = Convert.ToInt32(comboModKutyaId.SelectedValue);

            kutyaContext.SaveChanges();
        }
    }
}
