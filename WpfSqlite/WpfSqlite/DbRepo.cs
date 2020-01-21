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
        public int DbBeilleszt(string ev,string honap,string nap,string ora,string homerseklet,string szelsebesseg,string paratartalom)
        {
            using (SQLiteConnection conn=new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand sqlc=new SQLiteCommand())
                {
                    sqlc.Connection = conn;
                    sqlc.CommandText = "INSERT INTO idojarasadatok "+
                        "(ev,honap,nap,ora,homerseklet,szelsebesseg,paratartalom) "+
                        "VALUES (@ev,@honap,@nap,@ora,@homerseklet,@szelsebesseg,@paratartalom)";
                    sqlc.Parameters.Add("@ev", DbType.Int32).Value = Convert.ToInt32(ev);
                    sqlc.Parameters.Add("@honap", DbType.Int32).Value = Convert.ToInt32(honap);
                    sqlc.Parameters.Add("@nap", DbType.Int32).Value = Convert.ToInt32(nap);
                    sqlc.Parameters.Add("@ora", DbType.Int32).Value = Convert.ToInt32(ora);
                    sqlc.Parameters.Add("@homerseklet", DbType.Double).Value = Convert.ToDouble(homerseklet);
                    sqlc.Parameters.Add("@szelsebesseg", DbType.Double).Value = Convert.ToDouble(szelsebesseg);
                    sqlc.Parameters.Add("@paratartalom", DbType.Double).Value = Convert.ToDouble(paratartalom);

                    var sor = sqlc.ExecuteNonQuery();
                    return sor;

                }

            }


        }

    }

    
}
