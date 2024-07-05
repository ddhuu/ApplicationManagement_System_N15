using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAO
{
    public class StrategyDAO
    {
        public StrategyDAO() { }
        
        public static List<StrategyDTO> GetStrategies(int idEnterprise) 
        { 
            List<StrategyDTO> strategies = new List<StrategyDTO>();

            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                {
                    using (new DBProvider.OpenedContext())
                    {
                        string query = "SELECT CLUD.MaChienLuoc, TenChienLuoc, NgayKetThuc, UuDai " +
                            "FROM ChienLuocUuDai CLUD LEFT JOIN DoanhNghiep_UuDai DNUD ON CLUD.MaChienLuoc = DNUD.MaChienLuoc AND DNUD.MaDN = @idEnterprise " +
                            "WHERE DNUD.MaDN IS NULL AND CAST(NgayKetThuc AS DATE) < CAST(GETDATE() AS DATE)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idEnterprise", idEnterprise);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(reader.GetOrdinal("MaChienLuoc"));
                                    string nameStrategy = reader.GetString(reader.GetOrdinal("TenChienLuoc"));
                                    DateTime outOfDate = reader.GetDateTime(reader.GetOrdinal("NgayKetThuc"));
                                    int amountEndow = reader.GetInt32(reader.GetOrdinal("UuDai"));

                                    StrategyDTO strategy = new StrategyDTO
                                    {
                                        idStrategy = id,
                                        nameStrategy = nameStrategy,
                                        endDate = outOfDate,
                                        amountEndow = amountEndow
                                    };

                                        strategies.Add(strategy);
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

            return strategies;
        }

        public static bool insertStrategyEnterprise(int idEnterprise, int idStrategy)
        {
            SqlConnection conn = DBProvider.GetOpenConnection();

            string query = "INSERT DoanhNghiep_UuDai (MaChienLuoc, MaDN) VALUES (@idStrategy, @idEnterprise)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idStrategy", idStrategy);
                cmd.Parameters.AddWithValue("@idEnterprise", idEnterprise);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    // Log the exception (you can replace this with your logging mechanism)
                    Console.WriteLine("Error inserting Enterprise_Strategy: " + ex.Message);
                    return false;
                }
            }

        }
    }
}
