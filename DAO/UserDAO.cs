using DTO;
using System;
using System.Data.SqlClient;

namespace DAO
{
    public class UserDAO
    {
        public static UserDTO CheckLogin(string username, string password, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                // Declare variables to store data from the first DataReader
                int id = -1;
                string userName = null;
                string role = null;

                // First query to get ID and UserName
                string query = "SELECT ID, TenDangNhap FROM NguoiDung WHERE TenDangNhap = @username";
                SqlCommand cmdGetID = new SqlCommand(query, conn);
                cmdGetID.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = cmdGetID.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0); // Assuming the first column is ID
                        userName = reader.GetString(1); // Assuming the second column is TenDangNhap
                    }
                } // The using statement ensures the reader is closed here

                // Check if user was found
                if (id != -1 && userName != null)
                {
                    // Second query to check login credentials
                    SqlCommand cmd = new SqlCommand("checkLogin", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader loginReader = cmd.ExecuteReader())
                    {
                        if (loginReader.Read())
                        {
                            role = loginReader["VaiTro"].ToString();
                            // Return UserDTO with ID, UserName, and Role
                            return new UserDTO { Id = id, UserName = userName, Role = role };
                        }
                        else
                        {
                            response = "WRONGPASS";
                            return null;
                        }
                    }
                }
                else
                {
                    response = "NOTFOUND";
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = "ERROR: " + ex.Message;
                return null;
            }
        }
    }
}