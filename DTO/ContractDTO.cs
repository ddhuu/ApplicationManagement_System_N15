using System;

namespace DTO
{
    public class ContractDTO
    {
        public DateTime SignDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Status { get; set; }

        public ContractDTO(DateTime signDate, DateTime expiredDate, string status)
        {
            SignDate = signDate;
            ExpiredDate = expiredDate;
            Status = status;
        }
    }
}
