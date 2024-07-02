using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_N15.Candidate
{
    public partial class ViewPosts : Form
    {
        private string username;
        public ViewPosts(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void listPostsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào tiêu đề cột thì không xử lý
            if (e.RowIndex == -1)
                return;

            DataGridViewRow selectedRow = listPostsDGV.Rows[e.RowIndex];
            object value = selectedRow.Cells[1].Value;

            if (value != null)
            {
                int cellValue = int.Parse(value.ToString());
                PostDetail detailForm = new PostDetail(cellValue, username);
                detailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giá trị của ô là null.");
            }
        }

        private void ViewPosts_Load(object sender, EventArgs e)
        {
            DataTable posts = CandidateBUS.getPosts();
            if (posts.Rows.Count > 0)
            {
                List<string> columnNames = new List<string>()
                {
                    "#",
                    "MaDT",
                    "DOANH NGHIỆP",
                    "EMAIL",
                    "VỊ TRÍ TUYỂN DỤNG",
                    "SỐ LƯỢNG CẦN TUYỂN",
                    "NGÀY BẮT ĐẦU"
                };

                for (int i = 0; i < posts.Columns.Count; i++)
                {
                    posts.Columns[i].ColumnName = columnNames[i];
                }
                listPostsDGV.DataSource = posts;
                listPostsDGV.AutoResizeColumns();
                listPostsDGV.ReadOnly = true;
                listPostsDGV.Columns[1].Visible = false;
                foreach (DataGridViewColumn col in listPostsDGV.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
            }
        }
    }
}
