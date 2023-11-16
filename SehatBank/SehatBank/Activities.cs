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
            List<string> list = new List<string>();
            using (NpgsqlConnection connection = new NpgsqlConnection(UserSession.constring))
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
        public static int GetActivitiesId(string activitiesName)
        {
            int activitiesId = -1; // Default value indicating not found

            using (NpgsqlConnection connection = new NpgsqlConnection(UserSession.constring))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT activities_id FROM activities WHERE activities_name = @activitiesName";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@activitiesName", activitiesName);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            activitiesId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return activitiesId;
        }
    }
}
