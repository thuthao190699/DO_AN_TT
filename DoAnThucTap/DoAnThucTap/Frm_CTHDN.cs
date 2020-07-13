using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_CTHDN : Form
    {
        XuLyDuLieuDataContext dt = new XuLyDuLieuDataContext();
        
        public Frm_CTHDN()
        {
            InitializeComponent();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int tam;
        int click;
        private void Frm_CTHDN_Load(object sender, EventArgs e)
        {
            click = 0;
            int layMahd = Frm_HDN.mahd;
            CTHDN nv = dt.CTHDNs.Where(s => s.MaHDN == layMahd).FirstOrDefault();
            if (nv != null)
            {
                lbMaSP.Enabled = false;
                txtDonGia.Enabled = false;
                txtSoLuong.Enabled = false;
                tam = 2;
                HoaDonNhap layDLHDN = dt.HoaDonNhaps.Where(s => s.MaHDN == layMahd).FirstOrDefault();

                lbMaHDN.Text = layDLHDN.MaHDN.ToString();

                lbNgay.Text = layDLHDN.NgayNhap.ToString();

               

                NhanVien layDLNV = dt.NhanViens.Where(s => s.MaNV == layDLHDN.MaNV).FirstOrDefault();

                lbTenNV.Text = layDLNV.TenNV;

                NhaCC layDLNCC = dt.NhaCCs.Where(s => s.MaNCC == layDLHDN.MaNCC).FirstOrDefault();

                lbTenNCC.Text = layDLNCC.TenNCC;

                CTHDN layDLCTHDN = dt.CTHDNs.Where(s => s.MaHDN == layMahd).FirstOrDefault();

                txtDonGia.Text = layDLCTHDN.Dongia.ToString();

                txtSoLuong.Text = layDLCTHDN.Soluong.ToString();
                lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));

                SanPham layDLSP = dt.SanPhams.Where(s => s.MaSP == layDLCTHDN.MaSP).FirstOrDefault();

                lbMaSP.Text = layDLSP.TenSP.ToString();
                
            }
            else if (nv == null)
            {
                tam = 1;
                HoaDonNhap layDLHDN = dt.HoaDonNhaps.Where(s => s.MaHDN == layMahd).FirstOrDefault();

                lbMaHDN.Text = layDLHDN.MaHDN.ToString();

                lbNgay.Text = layDLHDN.NgayNhap.ToString();

                NhanVien layDLNV = dt.NhanViens.Where(s => s.MaNV == layDLHDN.MaNV).FirstOrDefault();

                lbTenNV.Text = layDLNV.TenNV;

                NhaCC layDLNCC = dt.NhaCCs.Where(s => s.MaNCC == layDLHDN.MaNCC).FirstOrDefault();

                lbTenNCC.Text = layDLNCC.TenNCC;

                txtDonGia.Text = "";

                txtSoLuong.Text = "";

                lbMaSP.DisplayMember = "TenSP";
                lbMaSP.ValueMember = "MaSP";
                lbMaSP.DataSource = dt.SanPhams.ToList();

                lbMaSP.Text = "";
            }            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Frm_Report f = new Frm_Report();
            f.ShowDialog();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if(tam == 1)
            {
                if (txtDonGia.Text != "" && txtSoLuong.Text != "")
                {
                    lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                }
            }
            else if (tam == 2 && click == 1)
            {
                if (txtDonGia.Text != "" && txtSoLuong.Text != "")
                {
                    lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            click = 1;
            txtDonGia.Enabled = true;
            txtSoLuong.Enabled = true;
            lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (tam == 1)
            {
                if (txtDonGia.Text != "" && txtSoLuong.Text != "")
                {
                    lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                }                
            }
            else if (tam == 2 && click == 1)
            {
                if (txtDonGia.Text != "" && txtSoLuong.Text != "")
                {
                    lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                }                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tam ==2)
            {
                dt.UpdateCTHDN1(Convert.ToInt32(lbMaHDN.Text), Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text));
                Frm_CTHDN_Load(sender, e);
                MessageBox.Show("Luu thanh cong");
            }
            else if(tam ==1)
            {
                dt.ThemCTHDN1(Convert.ToInt32(lbMaSP.SelectedValue.ToString()), Convert.ToInt32(lbMaHDN.Text), Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text));
                Frm_CTHDN_Load(sender, e);
                MessageBox.Show("Luu thanh cong");
            }            
        }
    }
}
