using DAO;
using DTO;

namespace BUS
{
    public class UserBus
    {
        public static User CheckLogin(string userName, string passWord, ref string response)
        {
            return UserDAO.CheckLogin(userName, passWord, ref response);
        }
    }
}
