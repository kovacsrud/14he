﻿using System;
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
            //update
            adapter.UpdateCommand = new SQLiteCommand(conn);
            adapter.UpdateCommand.CommandText = "UPDATE idojarasadatok SET "+
                "ev=@ev,honap=@honap,nap=@nap,ora=@ora,homerseklet=@homerseklet "+
                "szelsebesseg=@szelsebesseg, paratartalom=@paratartalom "+
                "WHERE rowid=@old_rowid";
            adapter.UpdateCommand.Parameters.Add("@ev", DbType.Int32, 0, "ev");
            adapter.UpdateCommand.Parameters.Add("@honap", DbType.Int32, 0, "honap");
            adapter.UpdateCommand.Parameters.Add("@nap", DbType.Int32, 0, "nap");
            adapter.UpdateCommand.Parameters.Add("@ora", DbType.Int32, 0, "ora");
            adapter.UpdateCommand.Parameters.Add("@homerseklet", DbType.Double, 0, "homerseklet");
            adapter.UpdateCommand.Parameters.Add("@szelsebesseg", DbType.Double, 0, "szelsebesseg");
            adapter.UpdateCommand.Parameters.Add("@paratartalom", DbType.Double, 0, "paratartalom");
            adapter.UpdateCommand.Parameters.Add("@old_rowid",DbType.Int32,0,"rowid").SourceVersion=DataRowVersion.Original;
            //delete
            adapter.DeleteCommand = new SQLiteCommand(conn);
            adapter.DeleteCommand.CommandText = "DELETE FROM idojarasadatok "+
                "WHERE rowid=@old_rowid";
            adapter.DeleteCommand.Parameters.Add("@old_rowid",DbType.Int32,0,"rowid").SourceVersion=DataRowVersion.Original;



        }

        public DataTable GetData()
        {
            adapter.Fill(table);
            return table;
        }

        public void UpdateData()
        {
            adapter.Update(table);
        }
    
    }
}
