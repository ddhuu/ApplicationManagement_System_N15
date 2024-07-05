using BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PTTK_N15.Recruiter
{
    public partial class PostJob : Form
    {
        private Form currentForm = null;
        public string UserName;
        public int UserId;
        public int IdPost;

        public PostJob(string userName, int userId)
        {
            InitializeComponent();
            this.UserName = userName;
            this.UserId = userId;
        }

        private void PostJob_Load(object sender, System.EventArgs e)
        {
            GetListPaymentPost();

        }

        private void GetListPaymentPost()
        {
            try
            {
                DataSet data = JobPostingBUS.GetListPaymentPost();
                dgv_JobPost.AutoGenerateColumns = true;
                dgv_JobPost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_JobPost.DataSource = data.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading DataGridView: " + ex.Message);
            }
        }

        private void dgv_JobPost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_JobPost.Rows[e.RowIndex];

                if (selectedRow.Cells["ID"].Value != null)
                {
                    this.IdPost = Convert.ToInt32(selectedRow.Cells["ID"].Value.ToString());
                    var childForm = new PostJobDetail(IdPost, UserId);
                    childForm.PostSuccessEvent += ChildForm_PostSuccessEvent;
                    OpenChildForm(childForm, sender);
                }
            }
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {
                return;
            }

            if (currentForm != null)
            {
                this.Controls.Remove(currentForm);
                currentForm.Close();
            }


            childForm.FormClosed += (s, args) => currentForm = null;

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.Controls.Add(childForm);
            this.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void ChildForm_PostSuccessEvent()
        {
            GetListPaymentPost();
        }


    }
}
