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
    public partial class Frm_ThemNV : Form
    {
        public Frm_ThemNV()
        {
            InitializeComponent();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtUserName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui long dien day du thong tin", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //kn.ThemNhanVien(Convert.ToInt32(lbMaNV.Text), txtTenNV.Text, txtSDT.Text, txtEmail.Text, txtUserName.Text, txtPass.Text, Convert.ToInt32(cbChucVu.SelectedValue.ToString()));
                this.Close();
            }
        }

        private void Frm_ThemNV_Load(object sender, EventArgs e)
        {
           // var a = net.NhanViens.OrderByDescending(s => s.MaNV).FirstOrDefault();
           // lbMaNV.Text = Convert.ToInt32(a.MaNV + 1).ToString();
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";
           // cbChucVu.DataSource = net.ChucVus;
        }
    }
}
