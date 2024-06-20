using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PTTK_N15.Leadership
{
    public partial class ContractList_View : Form
    {
        public ContractList_View()
        {
            InitializeComponent();
        }

        private void ContractList_View_Load(object sender, EventArgs e)
        {
            // Sample data
            contractList.Rows.Add(1, "Tech Company 1", "tech@gmail.com", "Full Stack Developer", "2023-06-20", "2023-12-20", 15);
            contractList.Rows.Add(2, "Tech Company 2", "tech@gmail.com", "Full Stack Developer", "2023-06-21", "2023-12-21", 16);
            contractList.Rows.Add(3, "Tech Company 3", "tech@gmail.com", "Full Stack Developer", "2023-06-22", "2023-12-22", 17);
            contractList.Rows.Add(4, "Tech Company 4", "tech@gmail.com", "Full Stack Developer", "2023-06-23", "2023-12-23", 18);
            contractList.Rows.Add(5, "Tech Company 5", "tech@gmail.com", "Full Stack Developer", "2023-06-24", "2023-12-24", 19);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Handle logout
            MessageBox.Show("Logged out!");
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToLower();
            foreach (DataGridViewRow row in contractList.Rows)
            {
                bool visible = row.Cells["Column2"].Value.ToString().ToLower().Contains(searchValue) ||
                               row.Cells["Column3"].Value.ToString().ToLower().Contains(searchValue) ||
                               row.Cells["Column4"].Value.ToString().ToLower().Contains(searchValue);
                row.Visible = visible;
            }
        }

    }
}
