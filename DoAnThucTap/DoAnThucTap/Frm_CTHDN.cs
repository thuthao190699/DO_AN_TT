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
        private void load()
        {
            int layMahd = Frm_HDN.mahd;
            CTHDN nv = dt.CTHDNs.Where(s => s.MaHDN == layMahd).FirstOrDefault();
            if (nv != null)
            {
                lbMaSP.Enabled = false;
                txtDonGia.Enabled = false;
                txtSoLuong.Enabled = false;
                tam = 2;
                //HoaDonNhap layDLHDN = dt.HoaDonNhaps.Where(s => s.MaHDN == layMahd).FirstOrDefault();

                //lbMaHDN.Text = layDLHDN.MaHDN.ToString();

                //lbNgay.Text = layDLHDN.NgayNhap.ToString();

                //NhanVien layDLNV = dt.NhanViens.Where(s => s.MaNV == layDLHDN.MaNV).FirstOrDefault();

                //lbTenNV.Text = layDLNV.TenNV;

                //NhaCC layDLNCC = dt.NhaCCs.Where(s => s.MaNCC == layDLHDN.MaNCC).FirstOrDefault();

                //lbTenNCC.Text = layDLNCC.TenNCC;

                //CTHDN layDLCTHDN = dt.CTHDNs.Where(s => s.MaHDN == layMahd).FirstOrDefault();

                //txtDonGia.Text = layDLCTHDN.Dongia.ToString();

                //txtSoLuong.Text = layDLCTHDN.Soluong.ToString();
                //lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));

                //SanPham layDLSP = dt.SanPhams.Where(s => s.MaSP == layDLCTHDN.MaSP).FirstOrDefault();

                //lbMaSP.Text = layDLSP.TenSP.ToString();

                var dl = dt.suacthdn(Frm_HDN.mahd).FirstOrDefault();
                lbMaHDN.Text = dl.MaHDN.ToString();
                lbNgay.Text = dl.NgayNhap.ToString();
                lbTenNV.Text = dl.TenNV;
                lbTenNCC.Text = dl.TenNCC;
                txtDonGia.Text = dl.Dongia.ToString();
                txtSoLuong.Text = dl.Soluong.ToString();
                lbthanhtien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text));
                lbMaSP.Text = dl.TenSP.ToString();

            }
            else if (nv == null)
            {
                tam = 1;
                //HoaDonNhap layDLHDN = dt.HoaDonNhaps.Where(s => s.MaHDN == layMahd).FirstOrDefault();

                //lbMaHDN.Text = layDLHDN.MaHDN.ToString();

                //lbNgay.Text = layDLHDN.NgayNhap.ToString();

                //NhanVien layDLNV = dt.NhanViens.Where(s => s.MaNV == layDLHDN.MaNV).FirstOrDefault();

                //lbTenNV.Text = layDLNV.TenNV;

                //NhaCC layDLNCC = dt.NhaCCs.Where(s => s.MaNCC == layDLHDN.MaNCC).FirstOrDefault();

                //lbTenNCC.Text = layDLNCC.TenNCC;
                var dl = dt.suacthdn(Frm_HDN.mahd).FirstOrDefault();
                lbMaHDN.Text = dl.MaHDN.ToString();
                lbNgay.Text = dl.NgayNhap.ToString();
                lbTenNV.Text = dl.TenNV;
                lbTenNCC.Text = dl.TenNCC;

                txtDonGia.Text = "";

                txtSoLuong.Text = "";

                lbMaSP.DisplayMember = "TenSP";
                lbMaSP.ValueMember = "MaSP";
                lbMaSP.DataSource = dt.SanPhams.ToList();

                lbMaSP.Text = "";
            }
        }

        int tam;
        int click;
        private void Frm_CTHDN_Load(object sender, EventArgs e)
        {
            click = 0;
            load(); 
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
                
                DialogResult dr= MessageBox.Show("Luu thanh cong", "Thông Báo", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    load();
                }
            }
            else if(tam ==1)
            {
                dt.ThemCTHDN1(Convert.ToInt32(lbMaSP.SelectedValue.ToString()), Convert.ToInt32(lbMaHDN.Text), Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text));
                DialogResult dr= MessageBox.Show("Luu thanh cong", "Thông Báo", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    load();
                }
            }            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
