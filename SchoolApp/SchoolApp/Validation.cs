using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    internal class Validation
    {
        public static bool UniqueData(string table, string entity, string inputUser)
        {
            Connection conn = new Connection();

            using (MySqlConnection connection = conn.ConnectionToSQL())
            {
                bool isRegistered = false;

                try
                {
                    connection.Open();
                    string query = $"SELECT {entity} FROM {table} WHERE {entity}=@inputUser";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@inputUser", inputUser);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        isRegistered = count > 0;
                        return isRegistered;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi gagal. Error: {ex.Message}");
                }
            }
            return false;
        }
    }
}
