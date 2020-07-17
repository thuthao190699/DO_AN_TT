using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadReport();
        }
        public FormReportHDX(int ID, string filename)
        {
            InitializeComponent();
            GetFileInvoice(ID, filename);
        }
        private void FormReportHDX_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadReport()
        {
            // TODO: This line of code loads data into the 'DataSetHDX.selectReportXuat' table. You can move, or remove it, as needed.
            this.selectReportXuatTableAdapter.Fill(this.DataSetHDX.selectReportXuat, Frm_HDX.mahdx);
            // TODO: This line of code loads data into the 'DataSetHDX.selectReportTongTienXuat' table. You can move, or remove it, as needed.
            this.selectReportTongTienXuatTableAdapter.Fill(this.DataSetHDX.selectReportTongTienXuat, Frm_HDX.mahdx);

            this.reportViewer1.RefreshReport();
        }
        public void GetFileInvoice(int id, string link)
        {
            this.reportViewer1.RefreshReport();
            this.selectReportXuatTableAdapter.Fill(this.DataSetHDX.selectReportXuat, id);
            // TODO: This line of code loads data into the 'DataSetHDX.selectReportTongTienXuat' table. You can move, or remove it, as needed.
            this.selectReportTongTienXuatTableAdapter.Fill(this.DataSetHDX.selectReportTongTienXuat, id);

            byte[] temp = reportViewer1.LocalReport.Render("PDF");
            var fullpath = Path.Combine(link, id.ToString() + ".pdf");
            File.WriteAllBytes(fullpath, temp);

        }
    }
}
