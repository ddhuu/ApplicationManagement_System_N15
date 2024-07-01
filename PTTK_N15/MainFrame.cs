using PTTK_N15.Recruiter;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PTTK_N15
{
    public partial class MainFrame : Form
    {
        private Form currentForm;
        public string UserName;
        public string Role;

        public static SqlConnection con = Login.conn;

        public MainFrame()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public MainFrame(string userName, string role)
        {
            this.Size = new Size(1800, 1100);
            InitializeComponent();
            this.UserName = userName;
            this.Role = role;
            Console.WriteLine($"UserName: {this.UserName}, Role: {this.Role}");
            RenderUI(this.UserName, this.Role);
        }








        private void RenderUI(string userName, string role)
        {
            pnlCommon111.Controls.Clear();
            ShowComponent(role);

        }
        private void ShowComponent(string role)
        {
            HideAllButtons();


            switch (role)
            {
                case "DoanhNghiep":
                    btnRequestPost.Visible = true;
                    btnViewPosts.Visible = true;
                    lbUserRole.Text = "Doanh Nghiệp";
                    break;
                case "BanLanhDao":
                    break;
                case "NhanVienDangTuyen":
                    btnPostJob.Visible = true;
                    lbUserRole.Text = "Nhân viên đăng tuyển";
                    break;
                case "UngVien":

                    break;
                default:
                    break;
            }


            InitForm(role);
        }

        private void HideAllButtons()
        {
            btnPostJob.Visible = false;
            btnRequestPost.Visible = false;
            btnViewPosts.Visible = false;

        }

        private void InitForm(string role)
        {
            Form formToLoad = null;

            switch (role)
            {
                case "DoanhNghiep":
                    lbTitle.Text = "Yêu cầu đăng tuyển";
                    formToLoad = new Enterprise.RequestPost();
                    break;
                case "BanLanhDao":
                    break;
                case "NhanVienDangTuyen":
                    lbTitle.Text = "Đăng tuyển dụng";
                    formToLoad = new
                        PostJob();
                    break;
                case "UngVien":
                    break;
                default:
                    MessageBox.Show("Unknown role. No form to load.");
                    return;
            }

            if (formToLoad != null)
            {
                formToLoad.TopLevel = false;
                formToLoad.FormBorderStyle = FormBorderStyle.None;
                formToLoad.Dock = DockStyle.Fill;
                pnlCommon111.Controls.Clear();
                pnlCommon111.Controls.Add(formToLoad);
                formToLoad.Show();
            }
        }




        private void OpenChildForm(Form childForm, object sender)
        {
            // Nếu form mới cùng loại với form đang mở
            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {
                return;
            }

            // Đóng và release form hiện tại

            if (currentForm != null)
            {
                this.pnlCommon111.Controls.Remove(currentForm);
                currentForm.Dispose();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm form mới vào

            this.pnlCommon111.Controls.Add(childForm);
            this.pnlCommon111.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            return;


        }





        #region Enterprise


        private void btnRequestPost_Click_1(object sender, EventArgs e)
        {
            lbTitle.Text = "Yêu cầu đăng tuyển";
            OpenChildForm(new Enterprise.RequestPost(), sender);
        }

        private void btnXemBaiDangTuyen_Click_1(object sender, EventArgs e)
        {
            lbTitle.Text = "Xem bài đăng tuyển";
            OpenChildForm(new Enterprise.ViewPosts(), sender);
        }


        #endregion Enterprise




        #region Recruiter

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Đăng tuyển dụng";
            OpenChildForm(new PostJob(), sender);

        }

        #endregion Recruiter




        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            this.Dispose();

        }
    }
}
