using DAO;
using System.Data;

namespace BUS
{
    public class JobPostingBUS
    {
        public static DataSet GetListPost()
        {
            return JobPostingDAO.GetListPost();
        }

        public static DataSet GetPostByUser(string userName)
        {
            return JobPostingDAO.GetPostByUser(userName);
        }

        public static DataSet GetPostById(int idPost)
        {
            return JobPostingDAO.GetPostById(idPost);
        }

        public static DataSet GetListPaymentPost()
        {
            return JobPostingDAO.GetListPaymentPost();
        }

        public static void PostJob(int idPost, int idUser)
        {
            JobPostingDAO.PostJob(idPost, idUser);
        }
    }
}
