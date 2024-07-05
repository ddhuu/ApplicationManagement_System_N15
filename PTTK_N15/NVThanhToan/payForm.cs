using BUS;
using DTO;
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
    public partial class payForm : Form
    {
        int MaPhieuDt;
        int MaNV;
        PhieuDangTuyenChoTT phieuInfo;
        string DotThanhToan;
        string SoTienCon;
        public payForm(int _MaPhieuDT, int _MaNv)
        {
            InitializeComponent();
            this.MaPhieuDt = _MaPhieuDT;
            this.MaNV = _MaNv;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soTien = Int32.Parse(txbSoTien.Text);
            int tongTien = phieuInfo.TongTien;
            int soTienCon = Int32.Parse(SoTienCon);
            string response = null;
            if ((soTienCon == soTien || soTien > 0.3 * tongTien) && soTien <= soTienCon)
            {
                NVThanhToanBUS.insertThanhToan(soTien, hinhThucCB.Text, phieuInfo.LanThanhToan - 1, Int32.Parse(DotThanhToan), MaPhieuDt, MaNV, ref response);
                if (response != null)
                {
                    MessageBox.Show(response);
                }
                this.Dispose();
            }
            else 
            {
                MessageBox.Show("Số tiền cần thanh toán lớn hơn 30% tổng tiền hoặc bằng số tiền còn thiếu và số tiền phải nhỏ hơn số tiền còn thiếu!!!");
            }

        }

        private void payForm_Load(object sender, EventArgs e)
        {
            string response = null;
            phieuInfo = NVThanhToanBUS.getAPhieuDT(MaPhieuDt, ref response);
            
            if (response == null)
            {
                lbMaPhieu.Text += phieuInfo.MaPhieuDT.ToString();
                lbTongTien.Text += phieuInfo.TongTien.ToString();
                lbLanTT.Text += phieuInfo.LanThanhToan.ToString();
                response = null;
                DotThanhToan = NVThanhToanBUS.getHighestBatch(MaPhieuDt, phieuInfo.LanThanhToan - 1, ref response);
                lbDotTT.Text += DotThanhToan;
                SoTienCon = NVThanhToanBUS.getSoTienConLai(MaPhieuDt, phieuInfo.LanThanhToan - 1, ref response);
                lbSoTienCon.Text += SoTienCon;
                if(response != null)
                {
                    MessageBox.Show(response);
                    this.Dispose();
                }
                if (DotThanhToan == "3") {
                    txbSoTien.Text = SoTienCon;
                    txbSoTien.ReadOnly = true;
                }
                
            }
            else
            {
                MessageBox.Show(response);
                this.Dispose();
            }
        }
    }
}
