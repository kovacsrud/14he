using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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

namespace WpfDbKep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //InsertSzemely();
            GetSzemely();
        }

        public void InsertSzemely()
        {
            byte[] kep = File.ReadAllBytes(@"p2.jpg");
            string connStr = "Data Source=kepdb.db;Version=3";

            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(conn);
            comm.CommandText = "insert into nevsor " +
                "(szemelyiszam,nev,kep) "+
                "values (@szemelyiszam,@nev,@kep)";
            comm.Parameters.Add("@szemelyiszam", DbType.String,8).Value = "3-201212-1234";
            comm.Parameters.Add("@nev", DbType.String, 8).Value = "Ingrid";
            comm.Parameters.Add("@kep", DbType.Binary, kep.Length).Value = kep;

            var sor=comm.ExecuteNonQuery();
            Debug.WriteLine(sor);
            conn.Close();


        }

        public void GetSzemely()
        {
            string connStr = "Data Source=kepdb.db;Version=3";

            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(conn);

            comm.CommandText = "select kep from nevsor where nev='Ingrid'";
            byte[] kep = (byte[])comm.ExecuteScalar();
            MemoryStream ms = new MemoryStream(kep);
            BitmapImage szemelyKep = new BitmapImage();
            szemelyKep.BeginInit();
            szemelyKep.StreamSource = ms;
            szemelyKep.EndInit();
            szemelykep.Source = szemelyKep;
            conn.Close();
        }
    }
}
