namespace DTO
{
    public class JobPostingDTO
    {
        public string Status { get; set; }

        public double TotalPrice { get; set; }

        public int IdCompany { get; set; }


        public JobPostingDTO(string status, double totalPrice, int enterprise)
        {
            this.Status = status;
            this.TotalPrice = totalPrice;
            this.IdCompany = enterprise;
        }




    }



}
