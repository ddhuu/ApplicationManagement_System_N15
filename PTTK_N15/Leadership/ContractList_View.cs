using BUS;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PTTK_N15.Leadership
{
    public partial class ContractList_View : Form
    {
/*        private List<ContractDTO> listContract;*/
        private BindingSource bindingSource;
        public ContractList_View()
        {
            InitializeComponent();
/*            listContract = new List<ContractDTO>();*/
            bindingSource = new BindingSource();
            bindingSource.DataSource = ContractBUS.getContractsByOutOfDate();
            ContractList_View_Load();
        }

        private void ContractList_View_Load()
        {
            // Sample data
            contractList.AutoGenerateColumns = false;
            contractList.DataSource = bindingSource;
            contractCount.Text = contractList.Rows.Count.ToString() + " hợp đồng";
            
            /*contractList.Rows.Add(1, "Tech Company 1", "tech@gmail.com", "20/06/2020", "20/06/2024");
            contractList.Rows.Add(2, "Tech Company 2", "tech@gmail.com", "20/07/2022", "20/07/2024");
            contractList.Rows.Add(3, "Tech Company 3", "tech@gmail.com", "23/06/2023", "23/06/2024");
            contractList.Rows.Add(4, "Tech Company 4", "tech@gmail.com", "15/07/2022", "15/07/2024");
            contractList.Rows.Add(5, "Tech Company 5", "tech@gmail.com", "15/07/2021", "15/07/2024");*/

            string eyeIconPath = @"..\..\Resource\eye-icon.png";
            DataGridViewImageColumn eyeIconColumn = new DataGridViewImageColumn();
            eyeIconColumn.Name = "viewDetails";
            eyeIconColumn.HeaderText = "XEM CHI TIẾT";
            contractList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eyeIconColumn.Image = Image.FromFile(eyeIconPath); // Ensure you have this resource
            eyeIconColumn.DefaultCellStyle.Padding = new Padding(0);
            contractList.Columns.Add(eyeIconColumn);
            contractList.CellMouseEnter += (sender, e) =>
            {
                if (e.ColumnIndex == contractList.Columns["viewDetails"].Index &&
                    e.RowIndex >= 0 && e.RowIndex < contractList.Rows.Count)
                {
                    contractList.Cursor = Cursors.Hand;
                }
            };

            // Chinh lai cusor default khi khong click vao eye icon
            contractList.CellMouseLeave += (sender, e) =>
            {
                if (e.ColumnIndex == contractList.Columns["viewDetails"].Index &&
                    e.RowIndex >= 0 && e.RowIndex < contractList.Rows.Count)
                {
                    contractList.Cursor = Cursors.Default;
                }
            };

            contractList.CellContentClick += contractList_CellContentClick;
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToLower();

            contractList.CurrentCell = null;

            foreach (DataGridViewRow row in contractList.Rows)
            {
                bool visible = row.Cells["nameContractCol"].Value.ToString().ToLower().Contains(searchValue) ||
                               row.Cells["signDateCol"].Value.ToString().ToLower().Contains(searchValue) ||
                               row.Cells["outOfDateCol"].Value.ToString().ToLower().Contains(searchValue);
                row.Visible = visible;
            }
        }

        private void contractList_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            // Check if the clicked cell is in the eye icon column
            if (contractList.Columns[e.ColumnIndex].Name == "viewDetails")
            {
                // Ensure the row index is valid
                if (e.RowIndex >= 0 && e.RowIndex < contractList.Rows.Count)
                {
                    var item = contractList.Rows[e.RowIndex].DataBoundItem as ContractDTO;
                    if (item != null)
                    {
                        var detailForm = new DetailInfo_View(item);
                        detailForm.Show();
                    }
                }
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = ContractBUS.getContractsByOutOfDate();
            contractList.DataSource = bindingSource;
            contractCount.Text = contractList.Rows.Count.ToString() + " hợp đồng";
        }
    }
}
