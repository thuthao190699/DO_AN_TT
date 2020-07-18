using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_Main : Form
    {
        Thread th;

        public string nhanTenNV { get; internal set; }

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(MoFormSanPham);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MoFormSanPham()
        {
            Application.Run(new Frm_SanPham());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Frm_NhanVien nv = new Frm_NhanVien();
            nv.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Frm_KhachHang kh = new Frm_KhachHang();
            kh.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Frm_HoaDon hd = new Frm_HoaDon();
            hd.ShowDialog();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Frm_NhaCC ncc = new Frm_NhaCC();
            ncc.ShowDialog();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Frm_ThongKe tk = new Frm_ThongKe();
            tk.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_Mail mail = new Frm_Mail();
            mail.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/phongvuvietnam");
        }
    }
}
