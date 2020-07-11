using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_Login : Form
    {
        public class TTNV
        {
            static public int Manv;
        }
        public Frm_Login()
        {
            InitializeComponent();
        }
        string tkDoiMK = "";
        public string MaHoa(string txt)
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
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NhanVien nv = kn.NhanViens.Where(s => s.TK == txtName.Text).Where(s => s.MK == MaHoa(txtPass.Text)).FirstOrDefault();
            if (nv != null)
            {
                if (nv.MaCV == 1)
                {
                    TTNV.Manv = nv.MaNV;
                    this.Hide();
                    Frm_Main main = new Frm_Main();
                    main.nhanTenNV = nv.TenNV.ToString();
                    main.Show();
                }
                else if (nv.MaCV == 2)
                {

                }
            }
            else if (nv == null)
            {
                MessageBox.Show("User name/ Password incorrect !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoatforgot_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnThoatchange_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnXNforgot_Click(object sender, EventArgs e)
        {
            NhanVien nv = kn.NhanViens.Where(s => s.Email == txtEmail.Text.Trim()).Where(s => s.TK == txtAccount.Text.Trim()).FirstOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Email or Account wrong !! \n Try Again");
                txtEmail.Focus();
            }
            else
            {
                tkDoiMK = txtAccount.Text.Trim();
                string bodyemail = "Xin Chào " + nv.TenNV + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                                    + "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
                                    + "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
                                    + "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
                                    + "\t\t=> Mã Xác Minh Của Bạn Là: " + nv.MK.Remove(6, 26)
                                    + "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu";
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("thao9089554@gmail.com");
                    mail.To.Add(nv.Email);
                    mail.Subject = "Yêu cầu đổi mật khẩu của bạn";
                    mail.Body = bodyemail;
                    SmtpClient smptClient = new SmtpClient();
                    smptClient.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential credential = new NetworkCredential();
                    credential.UserName = "thao9089554@gmail.com";
                    credential.Password = "thao456789";
                    smptClient.Credentials = credential;
                    smptClient.Port = 587;
                    smptClient.EnableSsl = true;
                    smptClient.Send(mail);


                    MessageBox.Show("Đã gửi mã xác minh về Email Mời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void btnXNchange_Click(object sender, EventArgs e)
        {
            NhanVien nv = kn.NhanViens.Where(s => s.TK == tkDoiMK.Trim()).Where(s => s.MK.Remove(6, 26) == txtOTP.Text.Trim()).FirstOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Bạn Đã Nhập Sai Mã Xác Minh Vui Lòng Check Mail Hoặc Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                kn.updateMK(nv.MaNV, MaHoa(txtNewPass.Text.Trim()));
                MessageBox.Show("Bạn đã đổi mật khẩu thành công");
                panel3.Visible = false;
                panel1.Visible = true;

            }
        }

        private void lbForgot_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }
    }

}
