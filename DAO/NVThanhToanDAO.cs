using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NVThanhToanDAO
    {
        public static PhieuDangTuyenChoTT getAPhieuDT(int MaPhieuDT, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    SqlCommand cmd = new SqlCommand("getAPhieuDT", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDT", MaPhieuDT);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = Int32.Parse(reader["MaPhieuDT"].ToString());
                            int TongTien = Int32.Parse(reader["TongTien"].ToString());
                            int LanThanhToan = Int32.Parse(reader["LanGiaHan"].ToString()) + 1;
                            return new PhieuDangTuyenChoTT { MaPhieuDT = MaPhieuDT, TongTien = TongTien, LanThanhToan = LanThanhToan };
                        }
                        else
                        {
                            response = "NOTFOUND";
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = ex.Message;
                return null;
            }
        }

        public static string getSoTienConLai(int MaPhieuDT,int LanThanhToan, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    SqlCommand cmd = new SqlCommand("getTienConLai", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDT", MaPhieuDT);
                    cmd.Parameters.AddWithValue("@LanThanhToan", LanThanhToan);
                    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    var result = returnParameter.Value;
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = ex.Message;
                return null;
            }
        }

        public static string getHighestBatch(int MaPhieuDT, int LanThanhToan, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    SqlCommand cmd = new SqlCommand("getHighestBatch", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDT", MaPhieuDT);
                    cmd.Parameters.AddWithValue("@LanThanhToan", LanThanhToan);
                    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    var result = returnParameter.Value;
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = ex.Message;
                return null;
            }
        }

        public static void insertThanhToan(int SoTien,string HinhThuc,int LanGiaHan,int DotThanhToan,int MaPhieuDT,int MaNV, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    SqlCommand cmd = new SqlCommand("INSERTTHANHTOAN", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SoTien", SoTien);
                    cmd.Parameters.AddWithValue("@HinhThuc", HinhThuc);
                    cmd.Parameters.AddWithValue("@LanGiaHan", LanGiaHan);
                    cmd.Parameters.AddWithValue("@DotThanhToan", DotThanhToan);
                    cmd.Parameters.AddWithValue("@MaPhieuDT", MaPhieuDT);
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = ex.Message;
            }
        }

        public static string getMaNV(string userName, ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    SqlCommand cmd = new SqlCommand("getMaNV", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    var result = returnParameter.Value;
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = ex.Message;
                return null;
            }
        }

        public static DataTable getListTT(ref string response)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                DataTable dt = new DataTable();
                using (new DBProvider.OpenedContext())
                {
                    SqlCommand cmd = new SqlCommand("getListTT", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                response = ex.Message;
                return null;
            }
        }
    }
}
