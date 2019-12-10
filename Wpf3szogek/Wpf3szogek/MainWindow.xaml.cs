using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf3szogek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog fajlDialog;
        List<DHaromszog> haromszogek = new List<DHaromszog>();

        public MainWindow()
        {
            InitializeComponent();
            fajlDialog = new OpenFileDialog();
            listboxDerekszogu.SelectionChanged += dh_SelectionChanged;
        }

        private void dh_SelectionChanged(object sender, EventArgs e)
        {
            var kerulet = haromszogek[listboxDerekszogu.SelectedIndex].Kerulet;
            var terulet = haromszogek[listboxDerekszogu.SelectedIndex].Terulet;

            labelkerulet.Content = $"Kerület: {kerulet}";
            labelterulet.Content = $"Terület: {terulet}";

        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            if (fajlDialog.ShowDialog()==true)
            {
                try
                {
                    var sorok = File.ReadAllLines(fajlDialog.FileName,Encoding.Default);
                    for (int i = 0; i < sorok.Length; i++)
                    {
                        try { 
                         haromszogek.Add(new DHaromszog(sorok[i], i + 1));
                         //listboxDerekszogu.Items.Add($"{i + 1}.sor:a={haromszogek[i].a},b={haromszogek[i].b},c={haromszogek[i].c}");    
                        }
                        catch (HaromszogHiba ex)
                        {
                            MessageBox.Show(ex.Message, "Háromszög hiba!");
                            listboxHibak.Items.Add($"{i+1}.sor:{ex.Message}");
                        }
                    }
                }
                
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,"Hiba!");

                }
                foreach (var h in haromszogek)
                {
                    listboxDerekszogu.Items.Add($"{h.SorSzama}.sor:a={h.a},b={h.b},c={h.c}");
                }
            }
        }
    }
}
