using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CandidateDAO
    {
        public static void createAUser(string username, string password, string candidateName,string gender, string address,string cccd,string phoneNumber, string email, ref string response)
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
                        SqlCommand cmd = new SqlCommand("addUserUV", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@candidateName", candidateName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@CCCD", cccd);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
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
    
        public static void getPosts(ref DataTable response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    using (SqlCommand cmd = new SqlCommand("GetPosts", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(response);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void getPostDetail(int id, ref DataTable response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    using (SqlCommand cmd = new SqlCommand("GetPostDetail", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(response);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void getCandidateInformation(string username, ref DataTable response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    using (SqlCommand cmd = new SqlCommand("GetCandidateInformation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", username);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(response);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void addPUT(string viTri, int maUV, int maPhieuDT, string username, ref string response, ref int maPUT)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    using (SqlCommand cmd = new SqlCommand("AddPUT", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ViTri", viTri);
                        cmd.Parameters.AddWithValue("@MaUV", maUV);
                        cmd.Parameters.AddWithValue("@MaPhieuDT", maPhieuDT);
                        cmd.Parameters.AddWithValue("@username", username);

                        SqlParameter messageParam = new SqlParameter("@Message", SqlDbType.NVarChar, 255)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(messageParam);

                        SqlParameter newMaPhieuUTParam = new SqlParameter("@NewMaPhieuUT", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(newMaPhieuUTParam);

                        cmd.ExecuteNonQuery();

                        response = messageParam.Value.ToString();
                        maPUT = int.Parse(newMaPhieuUTParam.Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
