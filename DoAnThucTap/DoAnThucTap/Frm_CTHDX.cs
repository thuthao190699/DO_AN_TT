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
    public partial class Frm_CTHDX : Form
    {
        public Frm_CTHDX()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_CTHDX_Load(object sender, EventArgs e)
        {
            lbMaHDX.Text = Frm_HDX.mahdx.ToString();
            CTHDX cthdx = kn.CTHDXes.Where(s => s.MaHDX == Frm_HDX.mahdx).FirstOrDefault();
            HoaDonXuat hdx = kn.HoaDonXuats.Where(s => s.MaHDX == Frm_HDX.mahdx).FirstOrDefault();
            SanPham tensp = kn.SanPhams.Where(s => s.MaSP == cthdx.MaSP).FirstOrDefault();
            lbTenSP.Text = tensp.TenSP;
            KhachHang tenkh = kn.KhachHangs.Where(s => s.MaKH == hdx.MaKH).FirstOrDefault();
            lbTenKH.Text = tenkh.TenKH;
            lbNgayXuat.Text = hdx.NgayXuat.ToString();
            NhanVien tennv = kn.NhanViens.Where(s => s.MaNV == hdx.MaNV).FirstOrDefault();
            lbTenNV.Text = tennv.TenNV;
            txtSoLuong.Text = cthdx.Soluong.ToString();
            txtGia.Text = tensp.Gia.ToString();

            txtGia.Enabled = false;
            txtSoLuong.Enabled = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            FormReportHDX f = new FormReportHDX();
            f.ShowDialog();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
