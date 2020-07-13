﻿using DevExpress.Data.ODataLinq.Helpers;
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
    public partial class Frm_HDX : Form
    {
        public Frm_HDX()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();
        public static int mahdx;
        int k = 0;

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(lbMaHDX.Text.Trim() != null || lbMaHDX.Text.Trim() != "")
            {
                int i = dataGridView1.CurrentRow.Index;

                lbMaHDX.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                cbTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                cbTenNV.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                dpNgayXuat.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtThanhTien.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
               

                mahdx = Convert.ToInt32(lbMaHDX.Text.Trim());
                CTHDX cthdx = kn.CTHDXes.Where(s => s.MaHDX == mahdx).FirstOrDefault();
                SanPham tensp = kn.SanPhams.Where(s => s.MaSP == cthdx.MaSP).FirstOrDefault();
                cbTenSP.Text = tensp.TenSP;
                txtSoLuong.Text = Convert.ToString(cthdx.Soluong);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            k = 1;
            var a = kn.HoaDonXuats.OrderByDescending(s => s.MaHDX).FirstOrDefault();
            lbMaHDX.Text = Convert.ToString(a.MaHDX + 1);

            lbMaHDX.Enabled = true;
            cbTenSP.Enabled = true;
            cbTenKH.Enabled = true;
            cbTenNV.Enabled = true;
            dpNgayXuat.Enabled = true;
            txtThanhTien.Enabled = false;
            txtGia.Enabled = false;
            txtSoLuong.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

            cbTenKH.Text = "";
            cbTenNV.Text = "";
            dpNgayXuat.Text = "";
            txtThanhTien.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            cbTenSP.Text = "";
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Frm_CTHDX f = new Frm_CTHDX();
            f.ShowDialog();
            f.Close();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            k = 2;
            cbTenKH.Enabled = true;
            cbTenNV.Enabled = true;
            cbTenSP.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGia.Enabled = false;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

            dpNgayXuat.Enabled = true;
        }

        private void Frm_HDX_Load(object sender, EventArgs e)
        {
            k = 0;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kn.selectHoaDonXuat();

            cbTenNV.DisplayMember = "TenNV";
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.DataSource = kn.NhanViens.ToList();

            cbTenKH.DisplayMember = "TenKH";
            cbTenKH.ValueMember = "MaKH";
            cbTenKH.DataSource = kn.KhachHangs.ToList();

            cbTenSP.DisplayMember = "TenSP";
            cbTenSP.ValueMember = "MaSP";
            cbTenSP.DataSource = kn.SanPhams.ToList();

            cbTenKH.Enabled = false;
            cbTenNV.Enabled = false;
            txtThanhTien.Enabled = false;
            txtSoLuong.Enabled = false;
            dpNgayXuat.Enabled = false;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            lbMaHDX.Text = "";
            cbTenKH.Text = "";
            cbTenNV.Text = "";
            cbTenSP.Text = "";
            dpNgayXuat.Text = "";
            txtThanhTien.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                if (txtSoLuong.Text != "" && cbTenSP.Text != "" &&cbTenNV.Text != "" &&cbTenKH.Text != "")
                {
                    kn.ThemHoaDonXuat(Convert.ToInt32(lbMaHDX.Text), Convert.ToInt32(cbTenKH.SelectedValue),
                    Convert.ToInt32(cbTenNV.SelectedValue), Convert.ToDateTime(dpNgayXuat.Text),
                    Convert.ToInt32(txtThanhTien.Text));
                    kn.ThemCTHDX(Convert.ToInt32(cbTenSP.SelectedValue), Convert.ToInt32(lbMaHDX.Text),
                     Convert.ToInt32(txtSoLuong.Text));
                    Frm_HDX_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui long nhap du thong tin");
                }
                
            }
            else if (k == 2)
            {
                if (txtSoLuong.Text != "" && cbTenSP.Text != "" && cbTenNV.Text != "" && cbTenKH.Text != "")
                {
                    kn.UpdatetHDX(Convert.ToInt32(lbMaHDX.Text), Convert.ToInt32(cbTenKH.SelectedValue),
                    Convert.ToInt32(cbTenNV.SelectedValue), Convert.ToDateTime(dpNgayXuat.Text),
                    Convert.ToInt32(txtThanhTien.Text));
                    kn.UpdatetCTHDX(Convert.ToInt32(lbMaHDX.Text), Convert.ToInt32(cbTenSP.SelectedValue),
                         Convert.ToInt32(txtSoLuong.Text));
                    Frm_HDX_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui long nhap du thong tin");
                }                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Frm_HDX_Load(sender, e);
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham sp = kn.SanPhams.Where(s => s.MaSP == Convert.ToInt32(cbTenSP.SelectedValue.ToString())).FirstOrDefault();
            if (sp != null)
            {
                txtGia.Text = sp.Gia.ToString();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Text != ""&& txtGia.Text != "")
            {
                txtThanhTien.Text = Convert.ToString(Convert.ToInt32(txtSoLuong.Text)*Convert.ToInt32(txtGia.Text));
            }
        }
    }
}
