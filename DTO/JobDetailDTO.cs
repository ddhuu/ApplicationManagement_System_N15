using System;

namespace DTO
{
    public class JobDetailDTO
    {
        public string Position { get; set; }

        public int Quantity { get; set; }

        public int DayPosting { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public JobDetailDTO(string position, int quantity, DateTime startDate, DateTime endDate)
        {
            Position = position;
            Quantity = quantity;
            StartDate = startDate;
            EndDate = endDate;
            DayPosting = (endDate - startDate).Days;
        }

    }


}
