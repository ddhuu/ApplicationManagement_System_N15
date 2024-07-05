using BUS;
using PTTK_N15.Leadership;
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
        public int Id;

        public static SqlConnection con = Login.conn;

        public MainFrame()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public MainFrame(string userName, string role, int id)
        {
            this.Size = new Size(1800, 1100);
            InitializeComponent();
            this.UserName = userName;
            this.Role = role;
            this.Id = id;
            Console.WriteLine($"UserName: {this.UserName}, Role: {this.Role}, Id: {this.Id}");
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
                    approveCandidatesBtn.Visible = true;
                    lbUserRole.Text = "Doanh Nghiệp";
                    break;
                case "BLD":
                    btnViewContract.Visible = true;
                    lbUserRole.Text = "Ban lãnh đạo";
                    break;
                case "NhanVienDangTuyen":
                    btnPostJob.Visible = true;
                    lbUserRole.Text = "Nhân viên đăng tuyển";
                    break;
                case "NhaVienDuyetHS":
                    processAplicationBtn.Visible= true;
                    lbUserRole.Text = "Duyệt hồ sơ";
                    break;
                case "NhanVien":
                    string roleEmp = "";
                    using (SqlCommand cmd = new SqlCommand("checkRoleEmp", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", Id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                roleEmp = reader["ViTri"].ToString();
                            }
                        }
                    }
                    switch (roleEmp)
                    {
                        case "NVDangTuyen":
                            btnPostJob.Visible = true;
                            lbUserRole.Text = "Nhân viên đăng tuyển";

                            break;
                        default:
                            break;
                    }
                    role = roleEmp;
                    break;
                case "UngVien":
                    viewPostsBTN.Visible = true;
                    lbUserRole.Text = "Ứng Viên";
                    break;
                case "NhanVienThanhToan":
                    thanhToanBtn.Visible = true;
                    lbUserRole.Text = "Nhân viên thanh toán";
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
            btnViewContract.Visible = false;
            processAplicationBtn.Visible = false;
            approveCandidatesBtn.Visible = false;
            viewPostsBTN.Visible = false;
            thanhToanBtn.Visible = false;
        }

        private void InitForm(string role)
        {
            Form formToLoad = null;
            lbTitle.Text = "";

            switch (role)
            {
                case "DoanhNghiep":
                    lbTitle.Text = "Yêu cầu đăng tuyển";
                    formToLoad = new Enterprise.RequestPost(UserName, Role, Id);
                    break;
                case "BLD":
                    lbTitle.Text = "Danh sách hợp đồng";
                    formToLoad = new
                        ContractList_View();
                    break;
                case "NVDangTuyen":
                    lbTitle.Text = "Đăng tuyển dụng";
                    formToLoad = new
                        PostJob(UserName, Id);
                    break;
                case "NhanVienDuyetHS":
                    lbTitle.Text = "Xử lí hồ";
                    formToLoad = new PostToProcess_View(0, this);
                    break;
                case "UngVien":
                    lbTitle.Text = "Các vị trí ứng tuyển";
                    formToLoad = new Candidate.ViewPosts(UserName, this, lbTitle);
                    break;
                case "NhanVienThanhToan":
                    lbTitle.Text = "Thanh toán";
                    formToLoad = new NVThanhToan.payListForm(UserName);
                    break;
                default:
                    break;
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




        public void OpenChildForm(Form childForm, object sender)
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
            OpenChildForm(new Enterprise.RequestPost(UserName, Role, Id), sender);
        }

        private void btnXemBaiDangTuyen_Click_1(object sender, EventArgs e)
        {
            lbTitle.Text = "Xem bài đăng tuyển";
            OpenChildForm(new Enterprise.ViewPosts(UserName, Role), sender);
        }


        #endregion Enterprise




        #region Recruiter

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Đăng tuyển dụng";
            OpenChildForm(new PostJob(UserName, Id), sender);

        }

        #endregion Recruiter

        
        private void viewPostsBTN_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Các vị trí ứng tuyển";
            OpenChildForm(new Candidate.ViewPosts(UserName, this, lbTitle), sender);
        }


        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            this.Dispose();

        }

        private void btnViewContract_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Danh sách hợp đồng";
            OpenChildForm(new ContractList_View(), sender);
        }

        private void approveCandidatesBtn_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Duyệt ứng viên";
            OpenChildForm(new PostToProcess_View(EnterpriseBUS.getEnterpriseID(UserName), this), sender);
        }
        
        

        private void MainFrame_Load(object sender, EventArgs e)
        {
            
        }



        private void processAplicationBtn_Click_1(object sender, EventArgs e)
        {
            lbTitle.Text = "Xử lí hồ sơ";
            OpenChildForm(new PostToProcess_View(0, this), sender);
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #region NhanVienThanhToan
        private void thanhToanBtn_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Thanh toán";
            OpenChildForm(new NVThanhToan.payListForm(UserName), sender);
        }
        #endregion NhanVienThanhToan

        private void pnlCommon111_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

    }
}
