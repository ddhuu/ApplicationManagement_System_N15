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

namespace PTTK_N15.NVThanhToan
{
    public partial class payListForm : Form
    {
        int id;
        public payListForm(string userName)
        {
            InitializeComponent();
            string response = null;
            id = Int32.Parse(NVThanhToanBUS.getMaNV(userName,ref response));  
            paymentList.DataSource = NVThanhToanBUS.getListTT(ref response);
            if(response != null)
            {
                MessageBox.Show(response);
                this.Dispose();
            }
        }

        private void contractList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = paymentList.Rows[e.RowIndex];
                int MaPhieuDT = Int32.Parse(row.Cells["MaPhieuDT"].Value.ToString());
                payForm f = new payForm(MaPhieuDT,id);
                this.Hide();
                f.ShowDialog();
                string response = null;
                paymentList.DataSource = NVThanhToanBUS.getListTT(ref response);
                if(response != null)
                {
                    MessageBox.Show(response);
                    this.Dispose();
                }
                this.Show();
            }
        }

      
    }
}
