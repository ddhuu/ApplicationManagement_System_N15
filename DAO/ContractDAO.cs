using DTO;
using System;
using System.Data.SqlClient;

namespace DAO
{
    public class ContractDAO
    {
        public static SqlConnection conn = DBProvider.GetOpenConnection();

        public static void AddContract(ContractDTO cont, int idPost)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("AddContract", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@signDate", cont.SignDate);
                    cmd.Parameters.AddWithValue("@expiredDate", cont.ExpiredDate);
                    cmd.Parameters.AddWithValue("@idPost", idPost);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
        }
    }
}
