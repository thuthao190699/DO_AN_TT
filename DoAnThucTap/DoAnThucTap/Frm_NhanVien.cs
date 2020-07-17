using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_NhanVien : Form
    {
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        public class tranferData
        {
            public static int maNV;
            public static String tenNV;
            public static String chucVu;
            public static String SDT;
            public static String Email;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.DataSource = kn.select_chucvu();
            cbChucVu.Enabled = false;

            gunaDataGridView1.AutoGenerateColumns = false;
            gunaDataGridView1.DataSource = kn.select_Nhanvien();

            cbChucVu.Enabled = false;
            gunaGroupBox2.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }


        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Mahoa(string txt)
        {
            MD5 mh = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            txt = sb.ToString();
            return txt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtTK.Text == "" )
            {
                MessageBox.Show("Vui long nhap day du thong tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kn.UpdateNhanVien(Convert.ToInt32(lbmanv.Text), txtTenNV.Text, txtSDT.Text, txtEmail.Text, (int)cbChucVu.SelectedValue);
                Frm_NhanVien_Load(sender, e);
                gunaDataGridView1.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThemNV themNV = new Frm_ThemNV();
            themNV.ShowDialog();
            var a = kn.NhanViens.OrderByDescending(s => s.MaNV).FirstOrDefault();
            lbmanv.Text = Convert.ToString(a.MaNV + 1);
            gunaGroupBox1.Enabled = true;
            gunaGroupBox2.Enabled = true;
            btnThem.Enabled = false;
            Frm_NhanVien_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtTK.Text = "";
            gunaDataGridView1.Enabled = true;
          
            btnThem.Enabled = true;
            Frm_NhanVien_Load(sender, e);
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gunaDataGridView1.CurrentRow.Index;

            lbmanv.Text = gunaDataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = gunaDataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = gunaDataGridView1.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = gunaDataGridView1.Rows[i].Cells[3].Value.ToString();
            txtTK.Text = gunaDataGridView1.Rows[i].Cells[4].Value.ToString();
            cbChucVu.Text = gunaDataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           // kn.DeleteNhanVien(Convert.ToInt32(lbmanv.Text));
            //gunaDataGridView1.DataSource = kn.NhanViens;
           // Frm_NhanVien_Load(sender, e);
           
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            gunaDataGridView1.Enabled = false;
            gunaGroupBox2.Enabled = true;            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        public bool isEmail(string inputEmail)
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
