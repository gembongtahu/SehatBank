using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    public class Activities
    {
        public static List<string> GetActivitiesList()
        {
            string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";
            List<string> list = new List<string>();
            using (NpgsqlConnection connection = new NpgsqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT activities_name FROM activities";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string activitiesName = reader["activities_name"].ToString();
                                list.Add(activitiesName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return list;
        }
    }
}
