using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Borealis
{
    public class Database_Functions
    {
        //Define the name of the SQLite database file
        public static string DB_File = "BorealisDB.sqlite";

        public static void InitializeDatabase()
        {
            //Check if the SQLite database file already exists, and create it if it doesn't
            if (File.Exists(DB_File))
            {
                Console.WriteLine("Database Already Exists.");
            }
            else
            {
                Console.WriteLine("Database does not exist.  Creating Database...");
                SQLiteConnection.CreateFile(DB_File);
                CreateTableOutline();
                GenerateBorealisData();
            }
        }

        public static void CreateTableOutline()
        {
            //Connect to the database
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DB_File};Version=3;");
            m_dbConnection.Open();

            //Create Control Panel Table Data
            string sql = "CREATE TABLE borealis_data (hostname VARCHAR(15), ip_address VARCHAR(15), guid VARCHAR(36))";
            SQLiteCommand generateCPTable = new SQLiteCommand(sql, m_dbConnection);
            generateCPTable.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        public static void GenerateBorealisData()
        {
            //Connect to the database
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DB_File};Version=3;");
            m_dbConnection.Open();

            //Pull the local agent data to be populated into the agent database table
            string GUID = Guid.NewGuid().ToString();
            string IP = (Dns.GetHostAddresses(Dns.GetHostName())[1].ToString());
            string HOSTNAME = Dns.GetHostName();
            string sql = $"insert into borealis_data (hostname, ip_address, guid) values ({HOSTNAME}, {IP}, {GUID})";

            //Insert the data into the agent table
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public Shared_Classes.ControlPanel QueryBorealisData()
        {
            //Connect to the database
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DB_File};Version=3;");
            m_dbConnection.Open();

            //Pull the local agent data to be populated into the agent database table
            string sql = "SELECT * from borealis_data";

            //Populate the Borealis table data into multiple outputs that can be read by the API upon request from the DB
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            m_dbConnection.Close();

            return new Shared_Classes.ControlPanel
            {
                HOSTNAME = reader["hostname"].ToString(),
                IP = reader["ip_address"].ToString(),
                GUID = reader["guid"].ToString()
            };
        }
    }
}
