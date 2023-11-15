using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms.VisualStyles;
using Npgsql;

namespace SehatBank
{
    public class Food
    {
        public static List<string> GetFoodList()
        {
            string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";
            List<string> list = new List<string>();
            using (NpgsqlConnection connection = new NpgsqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT food_name FROM food";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string foodName = reader["food_name"].ToString();
                                list.Add(foodName);
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

        public static int GetFoodId(string foodName)
        {
            int foodId = -1; // Default value indicating not found
            string constring = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SehatBank";

            using (NpgsqlConnection connection = new NpgsqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT food_id FROM food WHERE food_name = @foodName";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@foodName", foodName);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            foodId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return foodId;
        }
    }
}
