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
    public partial class Frm_ThongTinNV : Form
    {
        public Frm_ThongTinNV()
        {
            InitializeComponent();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // NhanVien nv = net.NhanViens.Where(s => s.MaNV == Frm_NhanVien.tranferData.maNV).FirstOrDefault();
           // ChucVu cv = net.ChucVus.Where(s => s.MaCV == nv.MaCV).FirstOrDefault();
           // net.UpdateStaff(Frm_NhanVien.tranferData.maNV, lbTenNV.Text, txtSDT.Text, txtEmail.Text, cv.MaCV);
        }

        private void Frm_ThongTinNV_Load(object sender, EventArgs e)
        {
           // lbTenNV.Text = Frm_NhanVien.tranferData.tenNV.ToString();
           // lbChucVu.Text = Frm_NhanVien.tranferData.chucVU.ToString();
           // NhanVien nv = net.NhanViens.Where(s => s.MaNV == Frm_NhanVien.tranferData.maNV).FirstOrDefault();
          //  ChucVu cv = net.ChucVus.Where(s => s.MaCV == nv.MaCV).FirstOrDefault();
           // lbChucVu.Text = Convert.ToString(cv.TenCV);
           // txtSDT.Text = Frm_NhanVien.tranferData.SDT.ToString();
          //  txtEmail.Text = Frm_NhanVien.tranferData.Email.ToString();
        }
    }
}
