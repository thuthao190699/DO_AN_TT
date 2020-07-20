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
    public partial class Frm_ThemKhachHang : Form
    {
        public Frm_ThemKhachHang()
        {
            InitializeComponent();
        }
        private Voids voids;
        private bool checkExit = false;
        public Frm_ThemKhachHang(Voids vd,bool check)
        {
            InitializeComponent();
            voids = vd;
            checkExit = check;
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            if (checkExit) voids();
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin:", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kn.ThemKhachHang(Convert.ToInt32(lbMaKH.Text), txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text);
                MessageBox.Show("Thêm thành công", "Thông báo");
                if (checkExit) voids();
                this.Close();
            }
            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
