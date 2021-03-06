﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void btnESC_Click(object sender, EventArgs e)
        {
            Frm_KhachHang_Load(sender, e);
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aquamarine;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Green;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kn.select_KhachHang();
            dataGridView1.Enabled = true;

            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_ThemKhachHang themkh = new Frm_ThemKhachHang();
            themkh.ShowDialog();
            Frm_KhachHang_Load(sender, e);
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            lbmakh.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;

            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView1.CurrentRow.Index;
                DialogResult mess = MessageBox.Show("Ban co muon xoa khach hang nay khong ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mess == DialogResult.Yes)
                {
                    kn.DeleteKhachHang(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                    Frm_KhachHang_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Ban khong the xoa", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtTimSDT.Text != null || txtTimSDT.Text != "")
            {
                dataGridView1.DataSource = kn.TimSDT(txtTimSDT.Text);
            }
            else
            {
                dataGridView1.DataSource = kn.KhachHangs.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                kn.UpdateKhachHang(Convert.ToInt32(lbmakh.Text), txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text);
                Frm_KhachHang_Load(sender, e);
        }
        private bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!isEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng", "Thông Báo");
                txtEmail.Text = "";
            }
        }
    }
}
