using System;

namespace DTO
{
    public class RecruimentContentDTO
    {
        public string idContent {  get; set; }
        public string position { get; set; }
        public int amount { get; set; }
        public int timeRecruiment { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
