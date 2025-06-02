using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Helpers
{
    public static class QueryHelper
    {
        public static MySqlCommand GetUsersQuery(string userID)
        {
            string query = "SELECT * FROM users WHERE userID = @userID;";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@userID", userID);

            return cmd;
        }
    }
}
