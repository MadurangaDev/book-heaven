using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace BookHaven.Helpers
{
    public class DBConnect
    {
        private string server = "104.152.222.128";
        private string database = "advertis_book_haven";
        private string uid = "advertis_roun411";
        private string password = "Thot4hm!";

        private MySqlConnection _connection;

        //constructor
        public DBConnect()
        {
            Initialize();
        }

        // initialize values
        private void Initialize()
        {
            string connectionString = $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password};";

            _connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                try
                {
                    _connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int Insert(string query)
        {
            // Open connection
            if (this.OpenConnection())
            {
                // Create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, _connection);

                int res;
                // Execute command
                try
                {
                    cmd.ExecuteNonQuery();
                    res = (int)cmd.LastInsertedId; // Get the last inserted ID
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    res = -1;
                }

                // Close connection
                this.CloseConnection();
                return res;
            }
            else
            {
                return -404;
            }
        }

        public void Update(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = _connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public MySqlDataReader Select(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //return list to be displayed
                return dataReader;
            }
            else
            {
                return null;
            }
        }

        //Count statement
        public int Count(string query)
        {
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, _connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}