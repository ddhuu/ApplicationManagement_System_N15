using DTO;
using System;
<<<<<<< HEAD
using System.Collections.Generic;
=======
>>>>>>> 567736b8194d5d0b77c24218a907bd8b412ca159
using System.Data.SqlClient;

namespace DAO
{
    public class ContractDAO
    {
<<<<<<< HEAD
        public ContractDAO()
        {

        }


        public static bool checkDate(DateTime dateToCheck)
        {
            // Get the current system date
            DateTime currentDate = DateTime.Now;

            // Check if the year and month are the same
            if (dateToCheck.Year == currentDate.Year && dateToCheck.Month == currentDate.Month)
            {
                // Calculate the difference in days
                int dayDifference = Math.Abs((dateToCheck - currentDate).Days);

                // Check if the difference is within 3 days
                return dayDifference <= 3;
            }

            return false;
        }

        public static List<ContractDTO> getContractsByOutOfDate()
        {
            List<ContractDTO> contracts = new List<ContractDTO>();

            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                {
                    using (new DBProvider.OpenedContext())
                    {
                        string query = "SELECT HD.MaHopDong, HD.TenHopDong, HD.TrangThai, HD.NgayKy, HD.NgayHetHan, HD.MaPhieuDT " +
                                       "FROM HopDong HD " +
                                       "JOIN PhieuDangTuyen PDT ON HD.MaPhieuDT = PDT.MaPhieuDT " +
                                       "WHERE HD.MaPhieuDT IN (SELECT MaPhieuDT FROM HoaDon)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(reader.GetOrdinal("MaHopDong"));
                                    string nameContract = reader.GetString(reader.GetOrdinal("TenHopDong"));
                                    string status = reader.GetString(reader.GetOrdinal("TrangThai"));
                                    DateTime signDate = reader.GetDateTime(reader.GetOrdinal("NgayKy"));
                                    DateTime outOfDate = reader.GetDateTime(reader.GetOrdinal("NgayHetHan"));
                                    int idRecruimentForm = reader.GetInt32(reader.GetOrdinal("MaPhieuDT"));

                                    if (checkDate(outOfDate))
                                    {
                                        ContractDTO contract = new ContractDTO
                                        {
                                            idContract = id,
                                            nameContract = nameContract,
                                            statusContract = status,
                                            signDate = signDate,
                                            outOfDate = outOfDate,
                                            idRecruimentForm = idRecruimentForm
                                        };

                                        contracts.Add(contract);
                                    }
                                }
                            }
                        }
                    }
=======
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
>>>>>>> 567736b8194d5d0b77c24218a907bd8b412ca159
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return contracts;
        }


        public static ContractDTO getDetailContract(int idEnterprise)
        {
            ContractDTO contract = null;
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                {
                    using (new DBProvider.OpenedContext())
                    {
                        string query = "SELECT MaHopDong, TenHopDong, HD.TrangThai, NgayKy, NgayHetHan, HD.MaPhieuDT" +
                                       " FROM HopDong HD JOIN PhieuDangTuyen PDT ON HD.MaPhieuDT = PDT.MaPhieuDT " +
                                       "INNER JOIN DoanhNghiep DN ON DN.MaDN = PDT.MaDN " +
                                       "WHERE DN.MaDN = @idEnterprise";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idEnterprise", idEnterprise);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int id = reader.GetInt32(reader.GetOrdinal("MaHopDong"));
                                    string nameContract = reader.GetString(reader.GetOrdinal("TenHopDong"));
                                    string status = reader.GetString(reader.GetOrdinal("TrangThai"));
                                    DateTime signDate = reader.GetDateTime(reader.GetOrdinal("NgayKy")).Date;
                                    DateTime outOfDate = reader.GetDateTime(reader.GetOrdinal("NgayHetHan")).Date;
                                    int idRecruimentForm = reader.GetInt32(reader.GetOrdinal("MaPhieuDT"));


                                    contract = new ContractDTO
                                    {
                                        idContract = id,
                                        nameContract = nameContract,
                                        statusContract = status,
                                        signDate = signDate,
                                        outOfDate = outOfDate,
                                        idRecruimentForm = idRecruimentForm
                                    };
                                    /*break;*/

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
            return contract;
        }

        public static bool updateOutOfDate(ContractDTO selectedContract)
        {
            SqlConnection conn = DBProvider.GetOpenConnection();

            string query = "UPDATE HopDong SET NgayHetHan = @NgayHetHan WHERE MaHopDong = @MaHopDong";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NgayHetHan", selectedContract.outOfDate);
                cmd.Parameters.AddWithValue("@MaHopDong", selectedContract.idContract);

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    // Log the exception (you can replace this with your logging mechanism)
                    Console.WriteLine("Error updating contract: " + ex.Message);
                    return false;
                }
            }

=======
                Console.WriteLine("SQL Error: " + ex.Message);
            }
>>>>>>> 567736b8194d5d0b77c24218a907bd8b412ca159
        }
    }
}
