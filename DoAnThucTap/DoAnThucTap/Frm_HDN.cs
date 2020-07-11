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
    public partial class Frm_HDN : Form
    {
        XuLyDuLieuDataContext dt = new XuLyDuLieuDataContext();
        public static int mahd = 0;

        public Frm_HDN()
        {
            InitializeComponent();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HDN_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.selectHoaDonNhap();

            cbNhaCC.DisplayMember = "TenNCC";
            cbNhaCC.ValueMember = "MaNCC";
            cbNhaCC.DataSource = dt.NhaCCs.ToList();

            cbTenSP.DisplayMember = "TenSP";
            cbTenSP.ValueMember = "MaSP";
            cbTenSP.DataSource = dt.SanPhams.ToList();

            cbTenNV.DisplayMember = "TenNV";
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.DataSource = dt.NhanViens.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;

            lbMaHDN.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbNhaCC.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbTenNV.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dpNgayLap.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtThanhTien.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            mahd = Convert.ToInt32(lbMaHDN.Text.Trim());
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Frm_CTHDN f = new Frm_CTHDN();
            f.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = dt.HoaDonNhaps.OrderByDescending(s => s.MaHDN).FirstOrDefault();
            lbMaHDN.Text = Convert.ToString(a.MaHDN + 1);

        }
    }
}
