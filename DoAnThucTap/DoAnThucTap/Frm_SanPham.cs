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
            th = new Thread(MoFormMain);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MoFormMain()
        {
            Application.Run(new Frm_Main());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = 1;
            btnAdd.Enabled = false;
            btnRefresh.Enabled = true;
            btnSave.Enabled = true;
            dataGridView1.Enabled = false;

            //able();
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = true;
            txtGiaSP.Enabled = true;
            txtSoLuongSP.Enabled =false;
            cbLoaiSP.Enabled = true;
            var a = kn.SanPhams.OrderByDescending(s => s.MaSP).FirstOrDefault();
            txtMaSP.Text = Convert.ToString(a.MaSP + 1);
            btnSave.Enabled = true;

        }
        private void Clear()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnRefresh.Enabled = false;
            btnSave.Enabled = false;
            btnXoa.Enabled = false;
            dataGridView1.Enabled = true;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuongSP.Text = "0";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            choose = 2;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            dataGridView1.Enabled = false;


            btnSave.Enabled = true;
            txtSoLuongSP.Enabled = false;
            txtTenSP.Enabled = true;
            txtGiaSP.Enabled = true;
            cbLoaiSP.Enabled = true;
            btnLoaiSP.Enabled = true;
            //able();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


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
                        MessageBox.Show("Thêm thành công ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frm_SanPham_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nho chen hinh", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            Convert.ToInt32(cbLoaiSP.SelectedValue));
                        DialogResult dr = MessageBox.Show("Sửa thành công ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            this.Close();
                            th = new Thread(LoadForm);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        Frm_SanPham_Load(sender, e);
                    }
                    else
                    {
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
                        Frm_SanPham_Load(sender, e);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnUpdate.Enabled = true;
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
                }
                catch (Exception) { }
            }
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(MoFormThemLoaiSP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MoFormThemLoaiSP()
        {
            Application.Run(new Frm_ThemLoaiSP());
        }

        private void btnHetHang_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_ThongKeSLSP tk = new Frm_ThongKeSLSP(ShowFrm);

            tk.ShowDialog();
            //th = new Thread(MoFromThongKe);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
        }
        private void ShowFrm()
        {
            this.Visible = true;
        }
        private void MoFromThongKe()
        {
            Application.Run(new Frm_ThongKe());
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
            }
            catch (Exception) { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            Frm_SanPham_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Khong the xoa", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            //if (result==DialogResult.Yes)
            //try
            //{
            //    kn.DeleteSanPham(Convert.ToInt32(txtMaSP.Text));
            //    dataGridView1.DataSource = kn.SanPhams;
            //    Frm_SanPham_Load(sender, e);
            //}
            //catch
            //{
            //}

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
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.HotPink;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aquamarine;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Green;

            Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kn.SanPhams.ToList();

            cbLoaiSP.DisplayMember = "TenTL";
            cbLoaiSP.ValueMember = "MaTL";
            cbLoaiSP.DataSource = kn.LoaiSPs;

            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtGiaSP.Enabled = false;
            txtSoLuongSP.Enabled = false;
            cbLoaiSP.Enabled = false;
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
            else
            {
                dataGridView1.DataSource = kn.SanPhams.ToList();
            }
        }

        private void txtGiaSP_Leave(object sender, EventArgs e)
        {
            try { Convert.ToDouble(txtGiaSP.Text); }
            catch
            {
                txtGiaSP.Text = "0";
            }

        }
    }
}
