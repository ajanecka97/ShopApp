using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;

namespace ShopCore.Data
{
    public class DatabaseManager
    {
        private const String DataSource = "C:\\Users\\szjan\\Desktop\\Programowanie\\Kodv2\\Data\\Database.db";

        private SQLiteConnection _connection;
        private SQLiteCommand _command;

        public DatabaseManager()
        {
        }

        /// <summary>
        /// Method estabilishes connection with SQLite database
        /// </summary>
        private void SetConnection()
        {
            _connection = new SQLiteConnection("Data Source=" + DataSource + ";Version=3;New=False;Compress=True");
        }

        /// <summary>
        /// Method open connection to the database. Then it executes querry on the database. When the operation is finished, connection with database is closed.
        /// </summary>
        /// <param name="txtQuery">Body of querry to execute</param>
        public void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            _connection.Open();
            _command = _connection.CreateCommand();
            _command.CommandText = txtQuery;
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        /// <summary>
        /// Method loads data from database
        /// </summary>
        /// <param name="command">Body of querry to execute</param>
        /// <returns></returns>
        public DataTable Load(String command)
        {
            SetConnection();
            _connection.Open();
            _command = _connection.CreateCommand();
            SQLiteDataAdapter DB = new SQLiteDataAdapter(command, _connection);
            DataTable DT = new DataTable();
            DB.Fill(DT);
            _connection.Close();
            return DT;
        }

        /// <summary>
        /// Method loads last index of asked table.
        /// </summary>
        /// <param name="tableName">Name of table</param>
        /// <returns>Returns last index of the table</returns>
        public int LastRowID(String tableName)
        {
            string sql = "select seq from sqlite_sequence where name='" + tableName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, _connection);
            _connection.Open();
            Debug.Write("Last row: " + cmd.ExecuteScalar());
            int lastID;
            Int32.TryParse(cmd.ExecuteScalar().ToString(), out lastID);
            _connection.Close();

            return lastID;
        }


    }
}
