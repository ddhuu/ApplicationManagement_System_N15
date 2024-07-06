using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class CandidateBUS
    {
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public static void createAUser(string username, string password, string recheckPass, string candidateName, string gender, string address, string cccd, string email,string phoneNumber, string dob, ref string response)
        {
            if (username == "" || password == "" || recheckPass == "" || candidateName == "" || gender == "" || cccd == "" || address == "" || phoneNumber == "" || !int.TryParse(phoneNumber,out _)|| !IsValidEmail(email))
            {
                response = "Thông tin không hợp lệ";
                return;
            }
            if (password != recheckPass)
            {
                response = "Xác nhận mật khẩu không trùng khớp";
                return;
            }

            CandidateDAO.createAUser(username, password, candidateName, gender,address,cccd,phoneNumber,email, dob, ref response);
        }
    
        public static DataTable getPosts()
        {
            DataTable result = new DataTable();
            CandidateDAO.getPosts(ref result);
            return result;
        }
        public static DataTable getPostDetail(int id)
        {
            DataTable result = new DataTable();
            CandidateDAO.getPostDetail(id, ref result);
            return result;
        }
        public static DataTable getCandidateInformation(string username)
        {
            DataTable result = new DataTable();
            CandidateDAO.getCandidateInformation(username, ref result);
            return result;
        }
        public static string addPUT(string viTri, int maUV, int maPhieuDT, string username, ref int maPUT)
        {
            string result = "";
            CandidateDAO.addPUT(viTri, maUV, maPhieuDT, username, ref result, ref maPUT);
            return result;
        }

    }
}
