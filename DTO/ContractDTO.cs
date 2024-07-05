using System;

namespace DTO
{
    public class ContractDTO
    {
<<<<<<< HEAD
        public int idContract { get; set; }
        public string nameContract { get; set; }
        public string statusContract { get; set; }
        public DateTime signDate { get; set; }
        public DateTime outOfDate { get; set; }
        public int idRecruimentForm { get; set; }
=======
        public DateTime SignDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Status { get; set; }

        public ContractDTO(DateTime signDate, DateTime expiredDate, string status)
        {
            SignDate = signDate;
            ExpiredDate = expiredDate;
            Status = status;
        }
>>>>>>> 567736b8194d5d0b77c24218a907bd8b412ca159
    }
}
