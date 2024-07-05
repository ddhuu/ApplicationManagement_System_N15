using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NVThanhToanBUS
    {
        public static PhieuDangTuyenChoTT getAPhieuDT(int MaPhieuDT, ref string response)
        {
            return NVThanhToanDAO.getAPhieuDT(MaPhieuDT, ref response);
        }

        public static string getSoTienConLai(int MaPhieuDT,int LanThanhToan, ref string response)
        {
            return NVThanhToanDAO.getSoTienConLai(MaPhieuDT, LanThanhToan, ref response);
        }

        public static string getHighestBatch(int MaPhieuDT, int LanThanhToan, ref string response)
        {
            return NVThanhToanDAO.getHighestBatch(MaPhieuDT, LanThanhToan, ref response);
        }

        public static void insertThanhToan(int SoTien, string HinhThuc, int LanGiaHan, int DotThanhToan, int MaPhieuDT, int MaNV, ref string response)
        {
            NVThanhToanDAO.insertThanhToan(SoTien,HinhThuc, LanGiaHan, DotThanhToan, MaPhieuDT, MaNV,ref response);
        }

        public static string getMaNV(string userName, ref string response)
        {
            return NVThanhToanDAO.getMaNV(userName,ref response);
        }

        public static DataTable getListTT(ref string response) {
            return NVThanhToanDAO.getListTT(ref response);
        }
    }
}
