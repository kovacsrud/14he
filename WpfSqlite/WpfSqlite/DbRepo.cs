using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Controls;

namespace WpfSqlite
{
    public class DbRepo
    {
        string connectionString;
        DataGrid adatok;

        public DbRepo(string connstring,DataGrid grid)
        {
            connectionString = connstring;
            adatok = grid;
        }

        public void DbLekerdez()
        {
            using (SQLiteConnection conn=new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand sqlc=new SQLiteCommand())
                {
                    sqlc.Connection = conn;
                    sqlc.CommandText = "select * from idojarasadatok";
                    DataTable table = new DataTable();
                    table.Load(sqlc.ExecuteReader());
                    adatok.ItemsSource = table.DefaultView;
                }
            }
        }

    }

    
}
