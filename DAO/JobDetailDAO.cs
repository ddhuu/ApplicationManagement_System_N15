using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class JobDetailDAO
    {
        public static SqlConnection conn = DBProvider.GetOpenConnection();
        public static int AddJobDetail(JobDetailDTO job)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("AddJobDetail", conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@position", job.Position);
                    cmd.Parameters.AddWithValue("@quantity", job.Quantity);
                    cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar, 500) { Value = job.Description });
                    cmd.Parameters.AddWithValue("@startDate", job.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", job.EndDate);
                    cmd.Parameters.AddWithValue("@dayPosting", job.DayPosting);



                    SqlParameter outputIdParam = new SqlParameter("@idDetailJob", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);


                    cmd.ExecuteNonQuery();


                    return (int)outputIdParam.Value;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
