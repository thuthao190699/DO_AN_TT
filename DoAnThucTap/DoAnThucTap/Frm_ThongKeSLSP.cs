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
    public partial class Frm_ThongKeSLSP : Form
    {
        public Frm_ThongKeSLSP()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ThongKeSLSP_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kn.select_ThongKeSLSP();
        }

        private void btnXuatThongKe_Click(object sender, EventArgs e)
        {

        }
    }
}
