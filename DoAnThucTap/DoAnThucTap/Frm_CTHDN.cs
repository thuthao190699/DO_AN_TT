using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_CTHDN : Form
    {
        XuLyDuLieuDataContext dt = new XuLyDuLieuDataContext();
        private static int layMahd = Frm_HDN.mahd;
        public Frm_CTHDN()
        {
            InitializeComponent();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_CTHDN_Load(object sender, EventArgs e)
        {
            HoaDonNhap layDLHDN = dt.HoaDonNhaps.Where(s=>s.MaHDN == layMahd).FirstOrDefault();

                lbMaHDN.Text = layDLHDN.MaHDN.ToString();

                lbNgay.Text = layDLHDN.NgayNhap.ToString();

            NhanVien layDLNV = dt.NhanViens.Where(s=>s.MaNV == layDLHDN.MaNV).FirstOrDefault();

                lbTenNV.Text = layDLNV.TenNV;

            NhaCC layDLNCC = dt.NhaCCs.Where(s=>s.MaNCC == layDLHDN.MaNCC).FirstOrDefault();

                lbTenNCC.Text = layDLNCC.TenNCC;

            CTHDN layDLCTHDN = dt.CTHDNs.Where(s=>s.MaHDN == layMahd).FirstOrDefault();

                lbDonGia.Text = layDLCTHDN.Dongia.ToString();

                txtSoLuong.Text = layDLCTHDN.Soluong.ToString();

            SanPham layDLSP = dt.SanPhams.Where(s => s.MaSP == layDLCTHDN.MaSP).FirstOrDefault();

                lbMaSP.Text = layDLSP.TenSP.ToString();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Frm_Report f = new Frm_Report();
            f.ShowDialog();
        }
    }
}
