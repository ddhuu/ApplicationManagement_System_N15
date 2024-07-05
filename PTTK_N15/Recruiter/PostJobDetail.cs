using BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PTTK_N15.Recruiter
{
    public partial class PostJobDetail : Form
    {
        private int ID;
        private int IDUser;

        public delegate void PostSuccessHandler();
        public event PostSuccessHandler PostSuccessEvent;
        public PostJobDetail()
        {
            InitializeComponent();
        }

        public PostJobDetail(int idPost, int idUser)
        {
            InitializeComponent();
            this.ID = idPost;
            this.IDUser = idUser;
        }

        private void RequestPost_Load(object sender, EventArgs e)
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

        private void btnRequestPost_Click(object sender, EventArgs e)
        {
            JobPostingBUS.PostJob(ID, IDUser);
            MessageBox.Show(this, "Đăng tuyển thành công");

            PostSuccessEvent?.Invoke();
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
