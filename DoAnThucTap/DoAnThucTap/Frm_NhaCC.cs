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
    public partial class Frm_NhaCC : Form
    {
        public Frm_NhaCC()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();
        int choose = 0;

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unAbleTextBox()
        {
            txtTenNCC.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        private void OpenTextBox()
        {
            txtTenNCC.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
        }
        private void ClearforAddNew()
        {
            lbMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void Frm_NhaCC_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kn.NhaCungCap();
            unAbleTextBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = 1;
            btnAdd.Enabled = false;
            var r = kn.NhaCCs.OrderByDescending(s => s.MaNCC).FirstOrDefault();
            lbMaNCC.Text = Convert.ToString(Convert.ToInt32(r.MaNCC) + 1);

            OpenTextBox();
            dataGridView1.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                kn.ThemNhaCungCap(Convert.ToInt32(lbMaNCC.Text), txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                btnAdd.Enabled = true;
                Frm_NhaCC_Load(sender, e);
                ClearforAddNew();

            }
            if (choose == 2)
            {
                kn.UpdateNhaCungCap(Convert.ToInt32(lbMaNCC.Text), txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                btnAdd.Enabled = true;
                Frm_NhaCC_Load(sender, e);
                ClearforAddNew();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearforAddNew();
            btnAdd.Enabled = true;
            Frm_NhaCC_Load(sender, e);
            dataGridView1.Enabled = true;
            
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            ClearforAddNew();
            unAbleTextBox();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            dataGridView1.Enabled = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            lbMaNCC.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenTextBox();
            choose = 2;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult mess = MessageBox.Show("Ban co muon xoa nha cung cap nay khong?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mess == DialogResult.Yes)
                {
                    kn.DeleteNhaCungCap(Convert.ToInt32(lbMaNCC.Text));
                    dataGridView1.DataSource = kn.NhaCCs;
                }
                Frm_NhaCC_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Ban khong the xoa", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
