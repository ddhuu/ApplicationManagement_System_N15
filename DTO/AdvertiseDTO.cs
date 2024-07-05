using System;

namespace DTO
{
    public class AdvertiseDTO
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public string AdType { get; set; }

        public AdvertiseDTO(string adType, DateTime startDate, DateTime EnDate)
        {
            this.AdType = adType;
            this.StartDate = startDate;
            this.EndDate = EnDate;
        }

    }
}
