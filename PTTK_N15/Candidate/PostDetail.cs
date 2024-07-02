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

namespace PTTK_N15.Candidate
{
    public partial class PostDetail : Form
    {
        private int id;
        private string username;
        public PostDetail(int id, string username)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
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
                        descriptionBuilder.AppendLine(row["MoTa"].ToString());
                    }
                    descriptionTB.Text = descriptionBuilder.ToString().Trim();
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
            this.Close();
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            Applying applyForm = new Applying(username, id);
            applyForm.ShowDialog();
        }

    }
}
