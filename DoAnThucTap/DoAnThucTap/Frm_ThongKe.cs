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
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            var a = kn.tongtienthangtruoc().FirstOrDefault();
            var b = kn.tongtienthangnay().FirstOrDefault();
            if (a == null)
            {
                lbThangTruoc.Text = "Tháng trước: " + 0;
            }
            else if (a != null)
            {
                lbThangTruoc.Text = "Tháng trước: " + a.thanhtien;
            }



            if (b == null)
            {
                lbThangNay.Text = "Tháng này:" + 0;
            }
            else if (b != null)
            {
                lbThangNay.Text = "Tháng này:" + b.ThanhTien;

            }
            chart1.Series["Doanh thu mỗi tháng"].XValueMember = "Thang";
            chart1.Series["Doanh thu mỗi tháng"].YValueMembers = "ThanhTien";
            chart1.DataSource = kn.ThongKe(2020);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
