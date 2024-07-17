using BUS;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_N15.Candidate
{
    public partial class Applying : Form
    {
        private string username;
        private int id_PDT;
        private int maUV;
        private string viTri;
        private MainFrame mainFrame;
        private Label lbTitle;
        private string selectedFilePath;
        public Applying(string username, int id, MainFrame mainFrame, Label lbTitle)
        {
            InitializeComponent();
            this.username = username;
            this.id_PDT = id;
            this.mainFrame = mainFrame;
            this.lbTitle = lbTitle;
            this.selectedFilePath = "";
            this.maUV = 0;
            this.viTri = "";
        }

        private void Applying_Load(object sender, EventArgs e)
        {
            nameTB.ReadOnly = true;
            addrTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            CCCDTB.ReadOnly = true;
            phoneNumTB.ReadOnly = true;
            genderCB.Enabled = false;
            DOBDTP.Enabled = false;
            bussinessTB.ReadOnly = true;
            jobTB.ReadOnly = true;
            fileCancelBTN.Visible = false;
            fileChosen.Visible = false;
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

                    maUV = int.Parse(candidateInformation.Rows[0]["MaUV"].ToString());
                }
                else
                {
                    MessageBox.Show("Không có chi tiết bài đăng.");
                }

                DataTable postDetail = CandidateBUS.getPostDetail(id_PDT);
                if (postDetail.Rows.Count > 0)
                {
                    bussinessTB.Text = postDetail.Rows[0]["TenDN"].ToString();
                    jobTB.Text = postDetail.Rows[0]["ViTriCanTuyen"].ToString();

                    viTri = postDetail.Rows[0]["ViTriCanTuyen"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết bài đăng: {ex.Message}");
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Chi tiết công việc";
            mainFrame.OpenChildForm(new PostDetail(id_PDT, username, mainFrame, lbTitle), sender);
        }
        private void fileCancelBTN_Click(object sender, EventArgs e)
        {
            fileLabel.Text = "Chọn hồ sơ";
            fileChosen.Text = "";
            selectedFilePath = "";
            fileChosen.Visible = false;
            fileCancelBTN.Visible = false;
            chooseFileBTN.Visible = true;
        }
        private void applyBTN_Click(object sender, EventArgs e)
        {
            if (selectedFilePath.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn hồ sơ");
            }
            else
            {
                int maPUT = 0;
                string message = CandidateBUS.addPUT(viTri, maUV, id_PDT, username, ref maPUT);
                if (message.ToLower().Contains("thành công"))
                {
                    string relativeDirectory = @"..\..\..\Resume\";
                    string targetDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeDirectory));

                    Directory.CreateDirectory(targetDirectory);
                    string fileExtension = Path.GetExtension(selectedFilePath);
                    string fileName = $"{id_PDT}_{username}_{maPUT}{fileExtension}";
                    string targetFilePath = Path.Combine(targetDirectory, fileName);
                    File.Copy(selectedFilePath, targetFilePath, true);
                }

                MessageBox.Show(message);
            }
        }
        private void chooseFileBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    selectedFilePath = openFileDialog.FileName;

                    // Display the file name
                    fileLabel.Text = "File đã chọn: ";
                    fileChosen.Text = $"{Path.GetFileName(selectedFilePath)}";
                    fileChosen.Visible = true;
                    fileCancelBTN.Visible = true;
                    chooseFileBTN.Visible = false;
                }
            }
        }

        private void fileChosen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                Process.Start(new ProcessStartInfo(selectedFilePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }
    }
}
