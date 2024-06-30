using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EnterpriseDAO
    {
        public static void createAUser(string username, string password,string companyName,string taxCode,string nameDD,string address,string email, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext(conn))
                {
                    string query = "SELECT Top 1 Vaitro FROM NguoiDung WHERE TenDangNhap = @username";
                    SqlCommand cmdGetID = new SqlCommand(query, conn);
                    cmdGetID.Parameters.AddWithValue("@username", username);
                    object result = cmdGetID.ExecuteScalar();
                    if (result == null)
                    {
                        SqlCommand cmd = new SqlCommand("addUserDN", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@companyName", companyName);
                        cmd.Parameters.AddWithValue("@taxCode", taxCode);
                        cmd.Parameters.AddWithValue("@nameDD", nameDD);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        response = "Đã có tài khoản";
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = ex.Message;
            }
        }
    }
}
