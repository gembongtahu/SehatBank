using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    public class User
    {
        public static int AuthenticateUser(string username, string password)
        {
            string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";
            using (NpgsqlConnection connection = new NpgsqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT user_id FROM users WHERE user_name = @username AND password = @password";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0;
                }
            }
        }
    }
}
