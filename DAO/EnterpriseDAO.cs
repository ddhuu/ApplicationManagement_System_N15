using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAO
{
    public class EnterpriseDAO

    {
        public static void createAUser(string username, string password,string companyName,string taxCode,string nameDD,string address,string email, ref string response)
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

        public static EnterpriseDTO getBusinessByContractID(int idContract)
        {
            EnterpriseDTO enterprise = new EnterpriseDTO(); // Initialize as null to check later if it has been set

            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                
                    using (new DBProvider.OpenedContext())
                    {
                        string query = "SELECT DN.MaDN AS MaDN, TenDN, NguoiDaiDien, Email, TiemNang " +
                                       "FROM DoanhNghiep DN " +
                                       "JOIN PhieuDangTuyen PDT ON DN.MaDN = PDT.MaDN " +
                                       "INNER JOIN HopDong HD ON HD.MaPhieuDT = PDT.MaPhieuDT " +
                                       "WHERE HD.MaHopDong = @idContract";
                    SqlCommand cmd = new SqlCommand(query, conn);
                        
                            cmd.Parameters.AddWithValue("@idContract", idContract);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            int id = reader.IsDBNull(reader.GetOrdinal("MaDN")) ? 0 : reader.GetInt32(reader.GetOrdinal("MaDN"));
                            string nameEnterprise = reader.IsDBNull(reader.GetOrdinal("TenDN")) ? null : reader.GetString(reader.GetOrdinal("TenDN"));
                            string representative = reader.IsDBNull(reader.GetOrdinal("NguoiDaiDien")) ? null : reader.GetString(reader.GetOrdinal("NguoiDaiDien"));
                            string email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
                            int potential = reader.IsDBNull(reader.GetOrdinal("TiemNang")) ? 0 : reader.GetInt32(reader.GetOrdinal("TiemNang"));

                            enterprise = new EnterpriseDTO
                            {
                                idEnterprise = id,
                                nameEnterprise = nameEnterprise,
                                representative = representative,
                                email = email,
                                potential = potential
                            };

                            Console.WriteLine($"MaDN: {id}, TenDN: {nameEnterprise}, NguoiDaiDien: {representative}, Email: {email}, TiemNang: {potential}");
                        }
                        else
                        {
                            Console.WriteLine("No data found for the given contract ID.");
                        }
                    }     
                      
                 }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                /*Console.WriteLine($"MaDN: {enterprise.idEnterprise}, TenDN: {enterprise.nameEnterprise}, NguoiDaiDien: {enterprise.representative}, Email: {enterprise.email}, TiemNang: {enterprise.potential}");*/

            }

            return enterprise;
        }

        

        public static List<RecruimentContentDTO> getPositions(int idContract)
        {
            List<RecruimentContentDTO> positions = new List<RecruimentContentDTO>();

            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                {
                    using (new DBProvider.OpenedContext())
                    {
                        string query = "SELECT ViTriCanTuyen, SoLuongTuyen " +
                            "FROM NoiDungDangTuyen NDDT JOIN PhieuDangTuyen PDT ON NDDT.MaND = PDT.MaND " +
                            "INNER JOIN HopDong HD ON HD.MaPhieuDT = PDT.MaPhieuDT " +
                            "WHERE MaHopDong = @idContract";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idContract", idContract);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int amount = reader.GetInt32(reader.GetOrdinal("SoLuongTuyen"));
                                    string positionRecruiment = reader.GetString(reader.GetOrdinal("ViTriCanTuyen"));

                                    RecruimentContentDTO position = new RecruimentContentDTO
                                    {
                                        position = positionRecruiment,
                                        amount = amount
                                    };

                                    positions.Add(position);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return positions;
        }
        public static int getEnterpriseID(string username)
        {
            int enterpriseID = -1;
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                {
                    using (new DBProvider.OpenedContext())
                    {
                        string query = "SELECT DoanhNghiep.MaDN" +
                            " From NguoiDung" +
                            " Join DoanhNghiep ON DoanhNghiep.ID_NguoiDung = NguoiDung.ID" +
                            " WHERE NguoiDung.TenDangNhap = @username";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", username);
                        
                         using (SqlDataReader reader = cmd.ExecuteReader())
                         {
                            if (reader.Read())
                            {
                                enterpriseID = reader.GetInt32(reader.GetOrdinal("MaDN"));
                            }
                             
                         }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return enterpriseID;
        }

        public static bool updateEnterprise(EnterpriseDTO selectedEnterprise)
        {
            SqlConnection conn = DBProvider.GetOpenConnection();

            string query = "UPDATE DoanhNghiep SET TiemNang = @potential WHERE MaDN = @idEnterprise";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@potential", selectedEnterprise.potential);
                cmd.Parameters.AddWithValue("@idEnterprise", selectedEnterprise.idEnterprise);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    // Log the exception (you can replace this with your logging mechanism)
                    Console.WriteLine("Error updating Enterprise: " + ex.Message);
                    return false;
                }
            }

        }


    }
}
