using BUS;
using DAO;
using DTO;
using System;
using System.Windows.Forms;

namespace PTTK_N15.Enterprise
{
    public partial class RequestPost : Form
    {
        public string UserName;
        public string UserRole;
        public int Id;
        public RequestPost()
        {
            InitializeComponent();
        }

        public RequestPost(string userName, string UserRole, int id)
        {
            InitializeComponent();
            this.UserName = userName;
            this.UserRole = UserRole;
            this.Id = id;
        }

        private void RequestPost_Load(object sender, EventArgs e)
        {
            tbxPosition.Text = string.Empty;
            tbxQuantity.Text = string.Empty;
            tbxDescript.Text = string.Empty;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);
            cbxTypeAd.SelectedIndex = -1;



        }



        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan duration = dtpEndDate.Value - dtpStartDate.Value;
            int daysCount = (int)duration.TotalDays;

            if (daysCount < 0)
            {
                MessageBox.Show(this, "End date must be after the start date!");
                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = DateTime.Today.AddDays(1);

            }

        }

        private void btnRequestPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPosition.Text) || !int.TryParse(tbxQuantity.Text, out int quantity) || quantity < 1 || string.IsNullOrWhiteSpace(tbxDescript.Text))
            {
                MessageBox.Show(this, "Thông tin không hợp lệ!", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RequestPost_Load(sender, e);
            }

            try
            {
                var jobDetail = new JobDetailDTO(tbxPosition.Text, int.Parse(tbxQuantity.Text), tbxDescript.Text, dtpStartDate.Value, dtpEndDate.Value);
                var idJobDetail = JobDetailBUS.AddJobDetail(jobDetail);


                double discount = EnterpriseDAO.GetDiscount(UserName);
                double totalCost = CalculateTotalCost(dtpStartDate.Value, dtpEndDate.Value, cbxTypeAd.SelectedItem.ToString(), discount);
                var jobPostInfo = new JobPostingDTO("Đang xét duyệt", totalCost, Id);
                int JobPostId = JobPostingDAO.AddJobPost(jobPostInfo, idJobDetail);

                var adInfo = new AdvertiseDTO(cbxTypeAd.Text, dtpStartDate.Value, dtpEndDate.Value);
                int adId = AdvertiseBUS.AddAdvertise(adInfo, JobPostId);

                var contract = new ContractDTO(dtpStartDate.Value, dtpEndDate.Value, "Chưa thanh toán");
                ContractBUS.AddContract(contract, JobPostId);


                MessageBox.Show("Request posted successfully!");
                RequestPost_Load(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }



        public static double CalculateTotalCost(DateTime StartDate, DateTime EndDate, string adType, double discountRate)
        {
            TimeSpan duration = EndDate.Subtract(StartDate);
            int daysCount = (int)duration.TotalDays;
            double costPerDay = 50000;
            double typeMultiplier = GetTypeMultiplier(adType);


            double totalCost = daysCount * costPerDay * typeMultiplier * (1 - discountRate);
            return Math.Round(totalCost, 2);
        }

        private static double GetTypeMultiplier(string adType)
        {
            switch (adType)
            {
                case "Báo giấy":
                    return 1.5;
                case "Banner Quảng cáo":
                    return 1.75;
                case "Trang mạng":
                    return 1.25;
                default:
                    return 1.0;
            }
        }



    }
}
