using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class AdvertiseDAO
    {
        private static SqlConnection con = DBProvider.GetOpenConnection();

        public static int AddAdvertise(AdvertiseDTO ad, int idCompany)
        {
            try
            {
                int adID;
                using (SqlCommand command = new SqlCommand("AddAdvertise", con))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@startDate", ad.StartDate);
                    command.Parameters.AddWithValue("@endDate", ad.EndDate);
                    command.Parameters.AddWithValue("@adType", ad.AdType);
                    command.Parameters.AddWithValue("@idCompany", idCompany);
                    SqlParameter output = new SqlParameter("@AdID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    };
                    command.Parameters.Add(output);
                    command.ExecuteNonQuery();
                    adID = Convert.ToInt32(output.Value);


                }
                return adID;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
    }
}
