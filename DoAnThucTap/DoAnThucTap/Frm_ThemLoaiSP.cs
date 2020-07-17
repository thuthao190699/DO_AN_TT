using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_ThemLoaiSP : Form
    {
        Thread th;
        public Frm_ThemLoaiSP()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(LoadForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenTL.Text == null || txtTenTL.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên loại sản phẩm !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTL.Focus();
            }
            else
            {
               
                kn.ThemLoaiSP(Convert.ToInt32(lbMaTL.Text), txtTenTL.Text);
                this.Close();
                th = new Thread(LoadForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void LoadForm()
        {
            Application.Run(new Frm_SanPham());
        }

        private void Frm_ThemLoaiSP_Load(object sender, EventArgs e)
        {
            var a = kn.LoaiSPs.OrderByDescending(s => s.MaTL).FirstOrDefault();
            lbMaTL.Text = Convert.ToString(a.MaTL + 1);
        }
    }
}
