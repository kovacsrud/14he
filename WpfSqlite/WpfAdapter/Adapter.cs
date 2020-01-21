using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace WpfAdapter
{
    public class Adapter
    {
        SQLiteConnection conn;
        SQLiteDataAdapter adapter;
        DataTable table;

        public Adapter(string connectionString)
        {
            conn = new SQLiteConnection(connectionString);
            table = new DataTable();
            adapter = new SQLiteDataAdapter("", conn);
            //select
            adapter.SelectCommand = new SQLiteCommand(conn);
            adapter.SelectCommand.CommandText = "SELECT rowid,* FROM idojarasadatok";
            //insert
            adapter.InsertCommand = new SQLiteCommand(conn);
            adapter.InsertCommand.CommandText = "INSERT INTO idojarasadatok "+
                "(ev,honap,nap,ora,homerseklet,szelsebesseg,paratartalom) "+
                "VALUES "+
                "(@ev,@honap,@nap,@ora,@homerseklet,@szelsebesseg,@paratartalom)";
            adapter.InsertCommand.Parameters.Add("@ev", DbType.Int32, 0, "ev");
            adapter.InsertCommand.Parameters.Add("@honap", DbType.Int32, 0, "honap");
            adapter.InsertCommand.Parameters.Add("@nap", DbType.Int32, 0, "nap");
            adapter.InsertCommand.Parameters.Add("@ora", DbType.Int32, 0, "ora");
            adapter.InsertCommand.Parameters.Add("@homerseklet", DbType.Double, 0, "homerseklet");
            adapter.InsertCommand.Parameters.Add("@szelsebesseg", DbType.Double, 0, "szelsebesseg");
            adapter.InsertCommand.Parameters.Add("@paratartalom", DbType.Double, 0, "paratartalom");

        }
    
    }
}
