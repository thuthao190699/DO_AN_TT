using System;
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
    public partial class Frm_ThemNV : Form
    {
        public Frm_ThemNV()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();
        public class TranferData
        {
            public static int done;
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
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int dem = 0;
                foreach(var a in kn.NhanViens)
                {
                    if(a.TK == txtUserName.Text)
                    {
                        dem++;
                    }
                }
                if (dem == 0)
                {
                    kn.ThemNhanVien(Convert.ToInt32(lbMaNV.Text), txtTenNV.Text, txtSDT.Text, txtEmail.Text, txtUserName.Text, txtPass.Text, Convert.ToInt32(cbChucVu.SelectedValue.ToString()));
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    this.Close();
                }
                else MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
        }

        private void Frm_ThemNV_Load(object sender, EventArgs e)
        {
            var a = kn.NhanViens.OrderByDescending(s => s.MaNV).FirstOrDefault();
            lbMaNV.Text = Convert.ToInt32(a.MaNV + 1).ToString();
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DataSource = kn.ChucVus;
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
