using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTK_N15.Candidate
{
    public partial class PostDetail : Form
    {
        private int id;
        private string username;
        private MainFrame mainFrame;
        private Label lbTitle;
        public PostDetail(int id, string username, MainFrame form, Label lbTitle)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
            mainFrame = form;
            this.lbTitle = lbTitle;
        }

        private void ViewPostDetail_Load(object sender, EventArgs e)
        {
            bussinessTB.ReadOnly = true;
            addrTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            numRecruitTB.ReadOnly = true;
            jobTB.ReadOnly = true;
            startDTP.Enabled = false;
            endDTP.Enabled = false;
            descriptionTB.ReadOnly = true;
            descriptionTB.Multiline = true;
            requirementTB.ReadOnly = true;
            requirementTB.Multiline = true;
            try
            {
                DataTable postDetail = CandidateBUS.getPostDetail(id);
                if (postDetail.Rows.Count > 0)
                {
                    bussinessTB.Text = postDetail.Rows[0]["TenDN"].ToString();
                    addrTB.Text = postDetail.Rows[0]["DiaChi"].ToString();
                    emailTB.Text = postDetail.Rows[0]["Email"].ToString();
                    numRecruitTB.Text = postDetail.Rows[0]["SoLuongTuyen"].ToString();
                    jobTB.Text = postDetail.Rows[0]["ViTriCanTuyen"].ToString();
                    descriptionTB.Text = postDetail.Rows[0]["MoTa"].ToString();
                    if (DateTime.TryParse(postDetail.Rows[0]["NgayBatDau"].ToString(), out DateTime ngayBatDau))
                    {
                        startDTP.Value = ngayBatDau;
                    }
                    else
                    {
                        MessageBox.Show("Ngày bắt đầu không hợp lệ.");
                    }
                    if (DateTime.TryParse(postDetail.Rows[0]["NgayKetThuc"].ToString(), out DateTime ngayKetThuc))
                    {
                        endDTP.Value = ngayKetThuc;
                    }
                    else
                    {
                        MessageBox.Show("Ngày kết thúc không hợp lệ.");
                    }
                    StringBuilder descriptionBuilder = new StringBuilder();
                    foreach (DataRow row in postDetail.Rows)
                    {
                        descriptionBuilder.AppendLine(row["TieuChi"].ToString());
                    }
                    requirementTB.Text = descriptionBuilder.ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Không có chi tiết bài đăng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết bài đăng: {ex.Message}");
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Các vị trí ứng tuyển";
            mainFrame.OpenChildForm(new Candidate.ViewPosts(username, mainFrame, lbTitle), sender);
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Thông tin ứng tuyển";
            mainFrame.OpenChildForm(new Applying(username, id, mainFrame, lbTitle), sender);
        }

        private void descriptionTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
