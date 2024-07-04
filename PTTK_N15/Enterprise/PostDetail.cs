using BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PTTK_N15.Enterprise
{
    public partial class PostDetail : Form
    {
        private int ID;
        public PostDetail()
        {
            InitializeComponent();
        }

        public PostDetail(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }



        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostDetail_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet data = JobPostingBUS.GetPostById(ID);
                DataTable dataTable = data.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    tbxPosition.Text = dataTable.Rows[0]["VT"].ToString();
                    tbxQuantity.Text = dataTable.Rows[0]["SL"].ToString();
                    tbxDescript.Text = dataTable.Rows[0]["MT"].ToString();
                    dtpStartDate.Value = Convert.ToDateTime(dataTable.Rows[0]["NBD"]);
                    dtpEndDate.Value = Convert.ToDateTime(dataTable.Rows[0]["NKT"]);
                    tbxTypeAd.Text = dataTable.Rows[0]["HTDT"].ToString();
                    tbxTotalPrice.Text = Convert.ToDecimal(dataTable.Rows[0]["TT"]).ToString("N0") + " đ";
                }
                else
                {
                    MessageBox.Show("This post does not have nay data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
