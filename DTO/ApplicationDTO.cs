using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ApplicationDTO
    {
        public int ApplicationID { get; set; }
        public string ApplicantName { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string ApplicationStatus { get; set; }
    }
}
