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
        public static string DB_File = "AgentDB.sqlite";

        public static void InitializeDatabase()
        {
            //Define the name of the SQLite database file
            string DB_File = "BorealisDB.sqlite";

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
                GenerateControlPanelData();
            }
        }

        public static void CreateTableOutline()
        {
            //Connect to the database
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DB_File};Version=3;");
            m_dbConnection.Open();

            //Create Control Panel Table Data
            string sql = "CREATE TABLE controlpanel_data (ip_address VARCHAR(15), guid VARCHAR(36))";
            SQLiteCommand generateCPTable = new SQLiteCommand(sql, m_dbConnection);
            generateCPTable.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        public static void GenerateControlPanelData()
        {
            //Connect to the database
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={DB_File};Version=3;");
            m_dbConnection.Open();

            //Pull the local agent data to be populated into the agent database table
            string GUID = Guid.NewGuid().ToString();
            string IP = (Dns.GetHostAddresses(Dns.GetHostName())[1].ToString());
            string HOSTNAME = Dns.GetHostName();
            string sql = $"insert into agent_data (ip_address, guid) values ({IP}, {GUID})";

            //Insert the data into the agent table
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
    }
}
