using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class JobPostingDAO
    {
        private static SqlConnection conn = DBProvider.GetOpenConnection();
        public static DataSet GetData(string procedure, params SqlParameter[] param)
        {
            DataSet data = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand(procedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }


            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;

        }

        public static DataSet GetListPost()
        {
            return GetData("GetListPost");
        }

        public static DataSet GetPostByUser(string userName)
        {
            return GetData("GetPostByUser", new SqlParameter("@username", userName));
        }


        public static DataSet GetPostById(int idPost)
        {
            return GetData("GetPostById", new SqlParameter("@idPost", idPost));
        }
        public static int AddJobPost(JobPostingDTO post, int idJobDetail)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("AddJobPost", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@status", post.Status);
                    cmd.Parameters.AddWithValue("@idJobDetail", idJobDetail);
                    cmd.Parameters.AddWithValue("@price", post.TotalPrice);
                    cmd.Parameters.AddWithValue("@idUser", post.IdCompany);

                    SqlParameter outputIdParam = new SqlParameter("@JobPostId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);


                    cmd.ExecuteNonQuery();


                    return (int)outputIdParam.Value;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return -1;
            }
        }





    }

}
