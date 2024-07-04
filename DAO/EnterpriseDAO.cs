using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class EnterpriseDAO
    {
        private static SqlConnection con = DBProvider.GetOpenConnection();
        public static void createAUser(string username, string password, string companyName, string taxCode, string nameDD, string address, string email, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
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

        public static double GetDiscount(string userName)
        {
            try
            {
                double discount = 0;

                using (SqlCommand cmd = new SqlCommand("GetDiscount", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userName", userName);

                    SqlParameter paramID = new SqlParameter("@discount", SqlDbType.Int);
                    paramID.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramID);
                    cmd.ExecuteNonQuery();
                    if (paramID.Value != DBNull.Value)
                    {
                        discount = Convert.ToDouble(paramID.Value) / 100;
                    }

                }
                return discount;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An SQL error occurred: {ex.Message}");
                return 0;
            }
        }
    }
}
