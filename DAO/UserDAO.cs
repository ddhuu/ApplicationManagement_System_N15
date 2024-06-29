using DTO;
using System;
using System.Data.SqlClient;

namespace DAO
{
    public class UserDAO
    {
        public static User CheckLogin(string username, string password)
        {
            try
            {
                using (SqlConnection conn = DBProvider.GetOpenConnection())
                {
                    string query = "SELECT TenDangNhap FROM NguoiDung WHERE TenDangNhap = @username";
                    SqlCommand cmdGetID = new SqlCommand(query, conn);
                    cmdGetID.Parameters.AddWithValue("@username", username);
                    object result = cmdGetID.ExecuteScalar();
                    if (result != null)
                    {
                        string userName = result.ToString();
                        SqlCommand cmd = new SqlCommand("checkLogin", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["VaiTro"].ToString();
                                return new User { UserName = userName, Role = role };
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
