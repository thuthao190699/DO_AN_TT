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
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aquamarine;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Green;
           
            btnChiTiet.Visible = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.selectlistHoaDonNhap();

            cbNhaCC.DisplayMember = "TenNCC";
            cbNhaCC.ValueMember = "MaNCC";
            cbNhaCC.DataSource = dt.NhaCCs.ToList();

            cbTenNV.DisplayMember = "TenNV";
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.DataSource = dt.NhanViens.ToList();

            cbNhaCC.Enabled = false;
            cbTenNV.Enabled =false;
            txtThanhTien.Enabled = false;
            dateTimePicker1.Enabled = false;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            mahd = 0;
            lbMaHDN.Text = "";
            cbNhaCC.Text = "";
            cbTenNV.Text = "";
            dateTimePicker1.Text = "";
            txtThanhTien.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChiTiet.Visible = true;
            int i = dataGridView1.CurrentRow.Index;

            lbMaHDN.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbNhaCC.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbTenNV.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtThanhTien.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            mahd = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Frm_CTHDN f = new Frm_CTHDN();
            f.ShowDialog();
            f.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = dt.HoaDonNhaps.OrderByDescending(s => s.MaHDN).FirstOrDefault();
            lbMaHDN.Text = Convert.ToString(a.MaHDN + 1);
            
           

            cbNhaCC.Enabled = true;
            cbTenNV.Enabled = true;
            dateTimePicker1.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt.ThemHoaDonNhap(Convert.ToInt32(lbMaHDN.Text), Convert.ToInt32(cbNhaCC.SelectedValue.ToString()), Convert.ToInt32(cbTenNV.SelectedValue.ToString()), (dateTimePicker1.Value));
            Frm_HDN_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cbNhaCC.Enabled = true;
            cbTenNV.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

            dateTimePicker1.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Frm_HDN_Load(sender, e);
        }

        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
