using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=idojarasadatok.db;Version=3";

            using (SQLiteConnection conn=new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand sqlc=new SQLiteCommand())
                {
                    sqlc.Connection = conn;
                    sqlc.CommandText = "select * from idojarasadatok where ev>2016";

                    using (SQLiteDataReader reader=sqlc.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["ev"]},{reader["honap"]},{reader["nap"]},{reader["ora"]}");
                            }

                        } else
                        {
                            Console.WriteLine("Nincs ilyen adat!");
                        }


                    }
                }

            }

            //insert
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand sqlc = new SQLiteCommand())
                {
                    sqlc.Connection = conn;
                    //sqlc.CommandText = "INSERT INTO idojarasadatok (ev,honap,nap,ora,homerseklet,szelsebesseg,paratartalom) values (2020,1,1,0,15.1,15.2,15.3)";
                    sqlc.CommandText = "INSERT INTO idojarasadatok (ev,honap,nap,ora,homerseklet,szelsebesseg,paratartalom) values (@ev,@honap,@nap,@ora,@homerseklet,@szelsebesseg,@paratartalom)";
                    sqlc.Parameters.Add("@ev", DbType.Int32).Value = 2021;
                    sqlc.Parameters.Add("@honap", DbType.Int32).Value = 1;
                    sqlc.Parameters.Add("@nap", DbType.Int32).Value = 1;
                    sqlc.Parameters.Add("@ora", DbType.Int32).Value = 0;
                    sqlc.Parameters.Add("@homerseklet", DbType.Double).Value = 15.2;
                    sqlc.Parameters.Add("@szelsebesseg", DbType.Double).Value = 15.2;
                    sqlc.Parameters.Add("@paratartalom", DbType.Double).Value = 15.2;

                    var sor=sqlc.ExecuteNonQuery();

                    Console.WriteLine($"{sor} sor beillesztve");

                   

                    
                }

            }

            //update
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand sqlc=new SQLiteCommand())
                {
                    sqlc.Connection = conn;
                    sqlc.CommandText = "UPDATE idojarasadatok SET ev=@ev where ev=2021";
                    sqlc.Parameters.Add("@ev", DbType.Int32).Value = 2022;
                    var sor = sqlc.ExecuteNonQuery();
                    Console.WriteLine($"{sor} sor módosítva");
                }

            }
            //delete
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand sqlc = new SQLiteCommand())
                {
                    sqlc.Connection = conn;
                    sqlc.CommandText = "DELETE FROM idojarasadatok where ev=2022";
                    var sor = sqlc.ExecuteNonQuery();
                    Console.WriteLine($"{sor} sor törölve");
                }

            }

            Console.ReadKey();
        }
    }
}
