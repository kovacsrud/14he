using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WpfNevsor
{
    public class Adapter
    {
        DataTable table;
        SQLiteDataAdapter adapter;
        SQLiteConnection conn;

        public Adapter(string connString)
        {
            conn = new SQLiteConnection(connString);
            table = new DataTable();
            adapter = new SQLiteDataAdapter("", conn);

            adapter.SelectCommand = new SQLiteCommand(conn);
            adapter.SelectCommand.CommandText = "select * from nevsor";

            //insert
            adapter.InsertCommand = new SQLiteCommand(conn);
            adapter.InsertCommand.CommandText = "insert into nevsor "+
                "(vezeteknev,keresztnev,szulev,szulhely) "+
                "values "+
                "(@vezeteknev,@keresztnev,@szulev,@szulhely)";
            adapter.InsertCommand.Parameters.Add("@vezeteknev", DbType.String, 0, "vezeteknev");
            adapter.InsertCommand.Parameters.Add("@keresztnev", DbType.String, 0, "keresztnev");
            adapter.InsertCommand.Parameters.Add("@szulev", DbType.Int32, 0, "szulev");
            adapter.InsertCommand.Parameters.Add("@szulhely", DbType.String, 0, "szulhely");

            //update
            adapter.UpdateCommand = new SQLiteCommand(conn);
            adapter.UpdateCommand.CommandText = "update nevsor "+
                "set "+
                "vezeteknev=@vezeteknev,keresztnev=@keresztnev,szulev=@szulev,szulhely=@szulhely "+
                "where id=@old_id";
            adapter.UpdateCommand.Parameters.Add("@vezeteknev", DbType.String, 0, "vezeteknev");
            adapter.UpdateCommand.Parameters.Add("@keresztnev", DbType.String, 0, "keresztnev");
            adapter.UpdateCommand.Parameters.Add("@szulev", DbType.Int32, 0, "szulev");
            adapter.UpdateCommand.Parameters.Add("@szulhely", DbType.String, 0, "szulhely");
            adapter.UpdateCommand.Parameters.Add("@old_id",DbType.Int32,0,"id").SourceVersion=DataRowVersion.Original;

            //delete
            adapter.DeleteCommand = new SQLiteCommand(conn);
            adapter.DeleteCommand.CommandText = "delete from nevsor where id=@old_id";
            adapter.DeleteCommand.Parameters.Add("@old_id", DbType.Int32, 0, "id").SourceVersion = DataRowVersion.Original;

        }

        public DataTable GetAdatok()
        {
            adapter.Fill(table);
            return table;
        }

        public void UpdateAdatok()
        {
            adapter.Update(table);
        }
        
    }
}
