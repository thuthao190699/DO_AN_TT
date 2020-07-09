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
    public partial class Frm_ThemLoaiSP : Form
    {
        public Frm_ThemLoaiSP()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenTL.Text != "")
            {
               kn.ThemLoaiSP(Convert.ToInt32(lbMaTL.Text), txtTenTL.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên loại sản phẩm !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTL.Focus();
            }
        }

        private void Frm_ThemLoaiSP_Load(object sender, EventArgs e)
        {

        }
    }
}
