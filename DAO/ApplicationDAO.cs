using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAO
{
    public class ApplicationDAO
    {
        public static int changeApplicationStatus(List<KeyValuePair<int, string>> applicationStatus)
        {
            int count = 0;
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    foreach(var entry in applicationStatus)
                    {
                        string query = "UPDATE PhieuUngTuyen SET TrangThai = @status WHERE MaPhieuUT = @applicationID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@status", entry.Value);
                        cmd.Parameters.AddWithValue("@applicationID", entry.Key);
                        count += cmd.ExecuteNonQuery();
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
            }
        }
        public static ApplicationDetailDTO viewApplicantDetail(int applicantID)
        {
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    string name = "";
                    string gender = "";
                    string address = "";
                    string phone = "";
                    string email = "";
                    string filePath = "";
                    DateTime dob = DateTime.Now;
                    
                    string query = "SELECT UngVien.TenUV, UngVien.GioiTinh, UngVien.DiaChi, UngVien.SoDT, UngVien.Email, UngVien.NgaySinh, PhieuUngTuyen.MaHoSo " +
                               "FROM PhieuUngTuyen " +
                               "JOIN UngVien ON PhieuUngTuyen.MaUV = UngVien.MaUV " +
                               "WHERE PhieuUngTuyen.MaPhieuUT = @applicantID";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicantID", applicantID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader.GetString(reader.GetOrdinal("TenUV"));
                            gender = reader.GetString(reader.GetOrdinal("GioiTinh"));
                            address = reader.GetString(reader.GetOrdinal("DiaChi"));
                            phone = reader.GetString(reader.GetOrdinal("SoDT"));
                            email = reader.GetString(reader.GetOrdinal("Email"));
                            filePath = reader.GetString(reader.GetOrdinal("MaHoSo"));
                        }
                        reader.Close();
                    }

                    
                    return new ApplicationDetailDTO { 
                        Address = address,
                        ApplicantName = name,
                        Email = email,
                        PhoneNumber = phone,
                        record = filePath,
                        DOB = dob };

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
        public static List<ApplicationDTO> getAllApplicationOfAPost(int postID, int enterpriseID)
        {
            List<ApplicationDTO> applicants = new List<ApplicationDTO>();
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                using (new DBProvider.OpenedContext())
                {
                    string query = "SELECT UngVien.TenUV, PhieuUngTuyen.NgayNop, PhieuUngTuyen.MaPhieuUT, PhieuUngTuyen.TrangThai " +
                       "FROM PhieuDangTuyen " +
                       "JOIN PhieuUngTuyen ON PhieuDangTuyen.MaPhieuDT = PhieuUngTuyen.MaPhieuDT " +
                       "JOIN UngVien ON PhieuUngTuyen.MaUV = UngVien.MaUV " +
                       "WHERE PhieuDangTuyen.MaPhieuDT = @postID";
                    if(enterpriseID > 0)
                    {
                        query += " AND PhieuUngTuyen.TrangThai = N'Đã xử lý'";
                    }
                    else
                    {
                        query += " AND PhieuUngTuyen.TrangThai = N'Đang xét duyệt'";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@postID", postID);
                    ApplicationDTO applicant = null;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       
                        while(reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("TenUV"));
                            DateTime submittedDate = reader.GetDateTime(reader.GetOrdinal("NgayNop"));
                            string status = reader.GetString(reader.GetOrdinal("TrangThai"));
                            int id = reader.GetInt32(reader.GetOrdinal("MaPhieuUT"));
                            
                            
                            applicant = new ApplicationDTO { ApplicantName = name, SubmittedDate = submittedDate, ApplicationStatus = status, ApplicationID = id };
                            applicants.Add(applicant);
                        }

                        reader.Close();
                        
                        
                    }
                    
                     
        
                }
            } catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                
              
            }
            return applicants;
        }
        public static List<PostToProcessDTO> getAllPostToProcess(int enterpriseID)
        {
            List<PostToProcessDTO> posts = new List<PostToProcessDTO>();
            try
            {
                SqlConnection conn = DBProvider.GetOpenConnection();
                SqlCommand cmd = null;
                using (new DBProvider.OpenedContext())
                {

                    string query = "SELECT PhieuDangTuyen.MaPhieuDT, NoiDungDangTuyen.SoLuongTuyen, NoiDungDangTuyen.MoTa, NoiDungDangTuyen.ViTriCanTuyen " +
                        " FROM PhieuDangTuyen" +
                        " JOIN NoiDungDangTuyen ON PhieuDangTuyen.MaND = NoiDungDangTuyen.MaND";
                       
                    if (enterpriseID != 0)
                    {
                        query += " WHERE EXISTS(SELECT *  From PhieuUngTuyen WHERE PhieuUngTuyen.MaPhieuDT = PhieuDangTuyen.MaPhieuDT AND PhieuUngTuyen.TrangThai = N'Đã xử lý') AND PhieuDangTuyen.MaDN = @enterpriseID;";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@enterpriseID", enterpriseID);

                    }
                    else
                    {
                        query += " WHERE EXISTS(SELECT *  From PhieuUngTuyen WHERE PhieuUngTuyen.MaPhieuDT = PhieuDangTuyen.MaPhieuDT AND PhieuUngTuyen.TrangThai = N'Đang xét duyệt')";
                        cmd = new SqlCommand(query, conn);

                    }
                    
                    PostToProcessDTO postToProcessDTO = null;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int PostId = reader.GetInt32(reader.GetOrdinal("MaPhieuDT"));
                            int Amount = reader.GetInt32(reader.GetOrdinal("SoLuongTuyen"));
                            string description = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? "" : reader.GetString(reader.GetOrdinal("MoTa"));
                            string occupation = reader.GetString(reader.GetOrdinal("ViTriCanTuyen"));
                            postToProcessDTO = new PostToProcessDTO { Amount = Amount, Description = description, PostID = PostId, Occupation = occupation };
                            posts.Add(postToProcessDTO);
                        }

                        reader.Close();
                        

                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");


            }
            return posts;
        }
        
    }
    
}
