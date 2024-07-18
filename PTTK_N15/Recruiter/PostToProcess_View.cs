using BUS;
using PTTK_N15.Enterprise;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PTTK_N15.Recruiter
{
    public partial class PostToProcess_View : Form
    {
        private BindingSource _bindingSource;
        private MainFrame _mainFrame;
        private int enterpriseID;
        public PostToProcess_View(int enterpriseID, MainFrame mainFrame)
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = ApplicationBUS.getAllPostToProcess(enterpriseID);
            this.enterpriseID = enterpriseID;
            _mainFrame = mainFrame; 
        }

        private void PostToProcess_View_Load(object sender, EventArgs e)
        {
            
             string eyeIconPath = @"..\..\Resource\eye-icon.png";
             DataGridViewImageColumn eyeIconColumn = new DataGridViewImageColumn();
             eyeIconColumn.Name = "ViewDetails";
             eyeIconColumn.HeaderText = "THỰC HIỆN DUYỆT";
             eyeIconColumn.Image = Image.FromFile(eyeIconPath); // Ensure you have this resource
             eyeIconColumn.DefaultCellStyle.Padding = new Padding(0);
             PostToProcess.Columns.Add(eyeIconColumn);
            PostToProcess.AutoGenerateColumns = false;
            PostToProcess.DataSource = _bindingSource;
            if(PostToProcess.Rows.Count == 0)
            {
                label1.Visible = true;
                label1.Text = "Không có bài đăng nào cần xử lí";
                PostToProcess.Visible = false;
            }
            else
            {
                label1.Visible = false;
            }

        }

        private void PostToProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PostToProcess.Columns[e.ColumnIndex].Name == "ViewDetails")
            {
                if (e.RowIndex >= 0 && e.RowIndex < PostToProcess.Rows.Count)
                {
                    DataGridViewRow row = PostToProcess.Rows[e.RowIndex];
                    int postID = Convert.ToInt32(row.Cells["PostIDCol"].Value);
                    
                    
                    
                    if (_mainFrame.Role.Equals("DoanhNghiep"))
                    {
                        ApproveCandidates processApplication = new ApproveCandidates(postID, _mainFrame);
                        processApplication.PostSuccessEvent += ReLoadData;
                        processApplication.Show();
                    }
                    else
                    {
                        var processApplication = new ProcessApplication(postID, _mainFrame);
                        
                        processApplication.Show();
                    }
                    

                }
            }
        }

        public void ReLoadData()
        {
            this._bindingSource.DataSource = ApplicationBUS.getAllPostToProcess(enterpriseID);
            PostToProcess.DataSource = this._bindingSource;
        }
/*        public void ReLoadData()
        {

        }*/
    }
}
