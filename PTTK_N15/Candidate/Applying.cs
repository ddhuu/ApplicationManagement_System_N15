using BUS;
using Guna.UI2.WinForms.Suite;
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
    public partial class Applying : Form
    {
        private string username;
        private int id_PUT;
        public Applying(string username, int id)
        {
            InitializeComponent();
            this.username = username;
            this.id_PUT = id;
        }

        private void Applying_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable candidateInformation = CandidateBUS.getCandidateInformation(username);
                if (candidateInformation.Rows.Count > 0)
                {
                    nameTB.Text = candidateInformation.Rows[0]["TenUV"].ToString();
                    addrTB.Text = candidateInformation.Rows[0]["DiaChi"].ToString();
                    emailTB.Text = candidateInformation.Rows[0]["Email"].ToString();
                    CCCDTB.Text = candidateInformation.Rows[0]["CCCD"].ToString();
                    phoneNumTB.Text = candidateInformation.Rows[0]["SoDT"].ToString();
                    genderCB.Text = candidateInformation.Rows[0]["GioiTinh"].ToString();
                    if (DateTime.TryParse(candidateInformation.Rows[0]["NgaySinh"].ToString(), out DateTime ngaySinh))
                    {
                        DOBDTP.Value = ngaySinh;
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ.");
                    }
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

        }
    }
}
