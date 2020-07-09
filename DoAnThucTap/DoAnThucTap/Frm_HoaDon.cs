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
    public partial class Frm_HoaDon : Form
    {
        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Frm_HDN hdn = new Frm_HDN();
            hdn.ShowDialog();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Frm_HDX hdx = new Frm_HDX();
            hdx.ShowDialog();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
