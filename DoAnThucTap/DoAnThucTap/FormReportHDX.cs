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
    public partial class FormReportHDX : Form
    {
        public FormReportHDX()
        {
            InitializeComponent();
        }

        private void FormReportHDX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetHDX.selectReportXuat' table. You can move, or remove it, as needed.
            this.selectReportXuatTableAdapter.Fill(this.DataSetHDX.selectReportXuat, Frm_HDX.mahdx);
            // TODO: This line of code loads data into the 'DataSetHDX.selectReportTongTienXuat' table. You can move, or remove it, as needed.
            this.selectReportTongTienXuatTableAdapter.Fill(this.DataSetHDX.selectReportTongTienXuat, Frm_HDX.mahdx);

            this.reportViewer1.RefreshReport();
        }
    }
}
