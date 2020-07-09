using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_SanPham : Form
    {
        Thread th;
        public Frm_SanPham()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();
        int choose;
        private void gunaLineTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = 1;
            //able();
            //txtTenSP.Enabled = true;
            //txtGiaSP.Enabled = true;
            //cbLoaiSP.Enabled = true;
            //btnLoaiSP.Enabled = true;
            //var a = kn.SanPhams.OrderByDescending(s => s.MaSP).FirstOrDefault();
            //txtMaSP.Text = Convert.ToString(a.MaSP + 1);
            //btnSave.Enabled = true;
        }
        private void Clear()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuongSP.Text = "0";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            choose = 2;
            //btnUpdate.Enabled = false;

            //btnSave.Enabled = true;
            //btnCancel.Enabled = true;
            //txtSoluong.Enabled = true;
            //txtTenSP.Enabled = true;
            //txtGiaSP.Enabled = true;
            //cbLoaiSP.Enabled = true;
            //btnLoaiSP.Enabled = true;
            //able();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            //Clear();
            //btnAdd.Enabled = true;
            //dataGridView1.Enabled = true;
            //btnUpdate.Enabled = false;
            //btnSave.Enabled = false;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                if (txtTenSP.Text == "" || txtGiaSP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (pic_AnhSach.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        pic_AnhSach.Image.Save(stream, ImageFormat.Jpeg);
                        kn.ThemSanPham(Convert.ToInt32(txtMaSP.Text), txtTenSP.Text,
                            Convert.ToDouble(txtGiaSP.Text), stream.ToArray(),
                            Convert.ToInt32(txtSoLuongSP.Text),
                            Convert.ToInt32(cbLoaiSP.SelectedValue.ToString()));
                        DialogResult dr = MessageBox.Show("Thêm thành công ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            Frm_SanPham_Load(sender, e);
                        }
                    }
                }
            }
            if (choose == 2)
            {
                if (txtTenSP.Text == "" || txtGiaSP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (pic_AnhSach.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        pic_AnhSach.Image.Save(stream, ImageFormat.Jpeg);
                        kn.UpdateSanPham(Convert.ToInt32(txtMaSP.Text), txtTenSP.Text,
                            Convert.ToDouble(txtGiaSP.Text), stream.ToArray(),
                            Convert.ToInt32(txtSoLuongSP.Text),
                            Convert.ToInt32(cbLoaiSP.SelectedValue.ToString()));
                        DialogResult dr = MessageBox.Show("Sửa thành công ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            this.Close();
                            th = new Thread(LoadForm);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                    else {
                        kn.UpdateSanPham(Convert.ToInt32(txtMaSP.Text), txtTenSP.Text,
                                Convert.ToDouble(txtGiaSP.Text), null,
                                Convert.ToInt32(txtSoLuongSP.Text),
                                Convert.ToInt32(cbLoaiSP.SelectedValue.ToString()));
                        DialogResult dr = MessageBox.Show("Sửa thành công ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            this.Close();
                            th = new Thread(LoadForm);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                }
            }
            //btnSave.Enabled = false;
            //Clear();
            //unAble();
        }

        private void LoadForm()
        {
            Application.Run(new Frm_SanPham());
        }

        private void able()
        {
            txtTenSP.Enabled = true;
            //txtSoluong.Enabled = true;
            txtGiaSP.Enabled = true;
            cbLoaiSP.Enabled = true;
        }
        private void unAble()
        {
            txtTenSP.Enabled = false;
            txtSoLuongSP.Enabled = false;
            txtGiaSP.Enabled = false;
            cbLoaiSP.Enabled = false;
        }

        private void txtGiaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMaSP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

            txtTenSP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGiaSP.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtSoLuongSP.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            cbLoaiSP.SelectedValue = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
            SanPham s = kn.SanPhams.Where(ss => ss.MaSP == Convert.ToInt32(txtMaSP.Text)).FirstOrDefault();
            if (s == null || s.HinhAnh == null) pic_AnhSach.Image = null;
            else
            {
                try
                {
                    MemoryStream stream = new MemoryStream(s.HinhAnh.ToArray());
                    Image img = Image.FromStream(stream);
                    if (img == null) return;
                    else
                    {
                        pic_AnhSach.Image = img;
                    }
                } catch (Exception) { }
            }
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            Frm_ThemLoaiSP themloaisp = new Frm_ThemLoaiSP();
            themloaisp.Show();
        }

        private void btnHetHang_Click(object sender, EventArgs e)
        {
            Frm_ThongKeSLSP tkslsp = new Frm_ThongKeSLSP();
            tkslsp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileImage.ShowDialog();
                string file = OpenFileImage.FileName;
                if (string.IsNullOrEmpty(file)) return;
                Image myimage = Image.FromFile(file);
                pic_AnhSach.Image = myimage;
            } catch (Exception) { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Frm_SanPham_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.DeleteSanPham(Convert.ToInt32(txtMaSP.Text));
            dataGridView1.DataSource = kn.SanPhams;
            Frm_SanPham_Load(sender, e);
        }

        private void load()
        {
            cbLoaiSP.DisplayMember = "TenTL";
            cbLoaiSP.ValueMember = "MaTL";
            cbLoaiSP.DataSource = kn.LoaiSPs;

            dataGridView1.DataSource = kn.SanPhams.ToList();

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuongSP.Text = "0";
            pic_AnhSach.Image = null;
        }
        
        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kn.SanPhams.ToList();

            cbLoaiSP.DisplayMember = "TenTL";
            cbLoaiSP.ValueMember = "MaTL";
            cbLoaiSP.DataSource = kn.LoaiSPs;

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuongSP.Text = "0";
            pic_AnhSach.Image = null;
        }

        private void txtTimTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTenSP.Text != null || txtTimTenSP.Text != "")
            {
                dataGridView1.DataSource = kn.TimSanPham(txtTimTenSP.Text);
            }
            else {
                dataGridView1.DataSource = kn.SanPhams.ToList();
            }
        }
    }
}
