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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DisplayMember = "TenCV";
            gunaDataGridView1.AutoGenerateColumns = false;
            gunaGroupBox1.Enabled = false;
            gunaGroupBox2.Enabled = false;
        }


        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtTK.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //kn.ThemNhanVien(Convert.ToInt32(lbMaNV.Text), txtTenNV.Text, txtSDT.Text, txtEmail.Text, txtTK.Text, Mahoa(txtMK.Text), Convert.ToInt32(cbChucVu.SelectedValue));

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThemNV themnv = new Frm_ThemNV();
            themnv.ShowDialog();
        }
    }
}
