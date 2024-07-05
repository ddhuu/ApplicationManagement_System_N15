using System;

namespace DTO
{
    public class ContractDTO
    {
        public int idContract { get; set; }
        public string nameContract { get; set; }
        public string statusContract { get; set; }
        public DateTime signDate { get; set; }
        public DateTime outOfDate { get; set; }
        public int idRecruimentForm { get; set; }
    }
}
