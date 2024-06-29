using DAO;
using DTO;

namespace BUS
{
    public class UserBus
    {
        public static User CheckLogin(string userName, string passWord)
        {
            return UserDAO.CheckLogin(userName, passWord);
        }
    }
}
