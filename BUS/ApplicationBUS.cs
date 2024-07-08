using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class ApplicationBUS
    {
        public static int changeApplicationStatus(List<KeyValuePair<int, string>> applicationStatus)
        {
            return ApplicationDAO.changeApplicationStatus(applicationStatus);
        }

        public static ApplicationDetailDTO viewApplicantDetail(int applicantID)
        {
            return ApplicationDAO.viewApplicantDetail(applicantID);
        }

        public static List<ApplicationDTO> getAllApplicationOfAPost(int postID, int enterpriseID)
        {
            return ApplicationDAO.getAllApplicationOfAPost(postID, enterpriseID);
        }

        public static List<PostToProcessDTO> getAllPostToProcess(int enterpriseID)
        {
            return ApplicationDAO.getAllPostToProcess(enterpriseID);
        }

    }
}
