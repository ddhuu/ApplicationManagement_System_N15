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
        public ViewPosts()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable posts = CandidateBUS.getPosts();
            if (posts.Rows.Count > 0)
            {
                List<string> columnNames = new List<string>()
                {
                    "#",
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

        private void listPostsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());
        }

    }
}
