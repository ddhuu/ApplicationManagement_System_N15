﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class EnterpriseBUS
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
        public static void createAUser(string username, string password,string recheckPass, string companyName, string taxCode, string nameDD, string address, string email, ref string response)
        {
            if (username == "" || password == "" || recheckPass == "" || companyName == "" || taxCode == "" || nameDD == "" || address == "" || !IsValidEmail(email))
            {
                response = "Thông tin không hợp lệ";
                return;
            }
            if (password != recheckPass)
            {
                response = "Xác nhận mật khẩu không trùng khớp";
                return;
            }
            
            EnterpriseDAO.createAUser(username, password,companyName,taxCode,nameDD,address,email, ref response);
        }
    }
}