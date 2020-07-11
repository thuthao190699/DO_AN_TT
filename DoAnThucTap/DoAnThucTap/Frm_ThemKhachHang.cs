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
    public partial class Frm_ThemKhachHang : Form
    {
        public Frm_ThemKhachHang()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ThemKhachHang_Load(object sender, EventArgs e)
        {
            var a = kn.KhachHangs.OrderByDescending(s => s.MaKH).FirstOrDefault();
            lbMaKH.Text = Convert.ToInt32(a.MaKH + 1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui long dien day du thong tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            kn.ThemKhachHang(Convert.ToInt32(lbMaKH.Text), txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text);
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
