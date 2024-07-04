using DAO;
using DTO;

namespace BUS
{
    public class JobDetailBUS
    {
        public static int AddJobDetail(JobDetailDTO job)
        {
            return JobDetailDAO.AddJobDetail(job);
        }
    }
}
