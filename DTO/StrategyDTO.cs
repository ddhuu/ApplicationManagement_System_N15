using System;

namespace DTO
{
    public class StrategyDTO
    {
        public int idStrategy { get; set; }
        public string nameStrategy { get; set; }
        public string descriptionStrategy { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int amountEndow { get; set; }
    }
}
