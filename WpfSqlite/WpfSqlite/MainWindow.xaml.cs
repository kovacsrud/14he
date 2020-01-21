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

namespace WpfSqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbRepo repo;

        public MainWindow()
        {
            InitializeComponent();
            repo = new DbRepo("Data Source=idojarasadatok.db;Version=3",adatok);
            repo.DbLekerdez();
        }

        private void buttonInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sor = repo.DbBeilleszt(ev.Text, honap.Text, nap.Text, ora.Text, homerseklet.Text, szelsebesseg.Text, paratartalom.Text);
                MessageBox.Show($"{sor}.sor beillesztve");
                repo.DbLekerdez();
                adatok.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
           
        }
    }
}
